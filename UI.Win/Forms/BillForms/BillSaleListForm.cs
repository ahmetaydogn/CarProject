using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DevExpress.XtraGrid.Views.Grid;
using Entities.Concrete;
using UI.Win.Enums;
using UI.Win.Forms.BaseForm;
using UI.Win.Forms.SaleForm;
using UI.Win.Show;

namespace UI.Win.Forms.BillForms;

public partial class BillSaleListForm : BaseDialogListForm
{
    public BillSaleListForm()
    {
        InitializeComponent();
    }

    public BillSaleListForm(string billNumber) : this()
    {
        this.billNumber = billNumber;
        HideSelectButton();
        RefreshGridControl();
    }

    private readonly string billNumber;
    IBillService billService = new BillManager(new EfBillDal());
    ISaleService saleService = new SaleManager(new EfSaleDal());
    IProductService productService = new ProductManager(new EfProductDal());
    ICustomerService customerService = new CustomerManager(new EfCustomerDal());


    // RibbonControl's Code
    public override void AddEntity()
    {
        ShowEditForms<SaleAddForm>.ShowDialogEditForm(billNumber);
    }

    public override void RefreshGridControl()
    {
        FillGrid();
        FillGaps();
    }


    // GridControl's Code
    public void FillGrid()
    {
        var productList = productService.GetAll();
        var customerList = customerService.GetAll();

        if (productList.IsSuccess && customerList.IsSuccess)
        {
            var result = billService.GetAllAsDto(billNumber, saleService, productList.Data, customerList.Data);
            if (result.IsSuccess)
                gridControl1.DataSource = result.Data;
        }
    }

    private void gridBillSale_DoubleClick(object sender, EventArgs e)
    {
        int saleId = Convert.ToInt32(gridBillSale.GetFocusedRowCellValue("SaleId"));
        int productId = Convert.ToInt32(gridBillSale.GetFocusedRowCellValue("ProductId"));
        ShowEditForms<SaleAddForm>.ShowDialogEditForm(saleId, EventType.EntityUpdate, productService.GetById(productId).Data.SellPrice, billNumber);
        FillGrid();
        FillGaps();
    }


    // Fill Components
    public void FillGaps()
    {
        decimal totalMarketPrice = 0;
        decimal totalSellPrice = 0;
        decimal totalVATPrice = 0;
        decimal totalExcisePrice = 0;
        decimal totalProfit = 0;

        var sales = saleService.GetAllByBillNumber(billNumber);
        if (sales.IsSuccess)
        {
            Product p; 
            foreach (var sale in sales.Data)
            {
                p = productService.GetById(sale.ProductId).Data;
                totalMarketPrice += p.MarketPrice * sale.Quantity;
                totalSellPrice += p.SellPrice * sale.Quantity;
                totalVATPrice += p.VATPrice * sale.Quantity;
                totalExcisePrice += p.ExciseDutyPrice * sale.Quantity;
                totalProfit += p.Profit * sale.Quantity;
            }

            txtAllMarketPrice.Text = totalMarketPrice.ToString();
            txtAllSellPrice.Text = totalSellPrice.ToString();
            txtAllVATPrice.Text = totalVATPrice.ToString();
            txtExciseTaxPrice.Text = totalExcisePrice.ToString();
            txtAllTAX.Text = (totalVATPrice + totalExcisePrice).ToString();
            txtAllProfit.Text = totalProfit.ToString();
            txtDescription.Text = billService.GetByBillNumber(billNumber).Data.Description;
        }
    }
}
