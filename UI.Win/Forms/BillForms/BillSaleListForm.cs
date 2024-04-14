using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DevExpress.XtraGrid.Views.Grid;
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
        FillGrid();
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
    }
}
