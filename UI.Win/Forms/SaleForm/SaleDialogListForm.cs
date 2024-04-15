using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using UI.Win.Enums;
using UI.Win.Forms.BaseForm;
using UI.Win.Forms.CarForms;
using UI.Win.Show;

namespace UI.Win.Forms.SaleForm;

public partial class SaleDialogListForm : BaseDialogListForm
{
    public SaleDialogListForm()
    {
        InitializeComponent();
        FillGrid();
    }

    ISaleService saleService = new SaleManager(new EfSaleDal());
    IProductService productService = new ProductManager(new EfProductDal());
    ICustomerService customerService = new CustomerManager(new EfCustomerDal());
    public int returnSaleId;
    private readonly bool isAlreadyExistBillNumber = true;


    // RibbonControl's Code
    public override void AddEntity()
    {
        string billNumber = gridSale.GetFocusedRowCellValue("BillNumber").ToString();
        ShowEditForms<SaleAddForm>.ShowDialogEditForm(isAlreadyExistBillNumber, billNumber);
    }

    public override void RefreshGridControl()
    {
        FillGrid();
    }

    public override void SelectEntity()
    {
        SelectFocusedEntity();
    }



    // GridControl's Code
    public void FillGrid()
    {
        var customerList = customerService.GetAll();
        var productList = productService.GetAll();
        if (customerList.IsSuccess && productList.IsSuccess)
        {
            var result = saleService.GetAllAsDto(productList.Data, customerList.Data);
            if (result.IsSuccess)
                gridControl1.DataSource = result.Data;
        }
    }

    private void gridSale_DoubleClick(object sender, EventArgs e)
    {
        int saleId = Convert.ToInt32(gridSale.GetFocusedRowCellValue("SaleId"));
        int productId = saleService.GetById(saleId).Data.ProductId;
        ShowEditForms<SaleAddForm>.ShowDialogEditForm(saleId, EventType.EntityUpdate, productService.GetById(productId).Data.SellPrice);
    }

    private void gridControl1_KeyPress(object sender, KeyPressEventArgs e)
    {
        SelectFocusedEntity();
    }


    // Other Functions
    private void SelectFocusedEntity()
    {
        returnSaleId = Convert.ToInt32(gridSale.GetFocusedRowCellValue("SaleId"));
        this.DialogResult = DialogResult.OK;
    }
}
