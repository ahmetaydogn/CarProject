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
    ISubProductService subProductService = new SubProductManager(new EfSubProductDal());
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
        var subProductList = subProductService.GetAll();

        if (productList.IsSuccess && customerList.IsSuccess)
        {
            var result = billService.GetAllAsDto(billNumber, saleService, productList.Data, customerList.Data, subProductList.Data);
            if (result.IsSuccess)
                gridControl1.DataSource = result.Data;
        }
    }

    private void gridBillSale_DoubleClick(object sender, EventArgs e)
    {

        int saleId = Convert.ToInt32(gridBillSale.GetFocusedRowCellValue("SaleId"));
        int? productId = Convert.ToInt32(gridBillSale.GetFocusedRowCellValue("ProductId"));
        int? subProductId = Convert.ToInt32(gridBillSale.GetFocusedRowCellValue("SubProductId"));

        if (subProductId == 0)
        {
            ShowEditForms<SaleAddForm>.ShowDialogEditForm(saleId, EventType.EntityUpdate, productService.GetById(Convert.ToInt32(productId)).Data.SellPrice, true);
        }
        else if (productId == 0)
        {
            ShowEditForms<SaleAddForm>.ShowDialogEditForm(saleId, EventType.EntityUpdate, subProductService.GetById(Convert.ToInt32(subProductId)).Data.SellPrice, false);
        }

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
            SubProduct sP;
            foreach (var sale in sales.Data)
            {
                if (sale.SubProductId == null)
                {
                    p = productService.GetById((int)sale.ProductId).Data;
                    totalMarketPrice += p.MarketPrice * sale.Quantity;
                    totalSellPrice += p.SellPrice * sale.Quantity;
                    totalVATPrice += p.VATPrice * sale.Quantity;
                    totalExcisePrice += p.ExciseDutyPrice * sale.Quantity;
                    totalProfit += p.Profit * sale.Quantity;
                }
                else if (sale.ProductId == null)
                {
                    sP = subProductService.GetById((int)sale.SubProductId).Data;
                    totalMarketPrice += sP.MarketPrice * sale.Quantity;
                    totalSellPrice += sP.SellPrice * sale.Quantity;
                    totalVATPrice += sP.VATPrice * sale.Quantity;
                    totalProfit += sP.Profit * sale.Quantity;
                }
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
