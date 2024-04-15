using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using UI.Win.Enums;
using UI.Win.Forms.BaseForm;
using UI.Win.Forms.BillForms;
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
    ISubProductService subProductService = new SubProductManager(new EfSubProductDal());
    ICustomerService customerService = new CustomerManager(new EfCustomerDal());
    public int returnSaleId;
    private readonly bool isAlreadyExistBillNumber = true;


    // RibbonControl's Code
    public override void AddEntity()
    {
        if (Application.OpenForms["BillAddForm"] != null)
        {
            BillAddForm addForm = (BillAddForm)Application.OpenForms["BillAddForm"];
            string billNumber = addForm.BillNumber;
            ShowEditForms<SaleAddForm>.ShowDialogEditForm(isAlreadyExistBillNumber, billNumber);
        }
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
        var subProductList = subProductService.GetAll();
        if (customerList.IsSuccess && productList.IsSuccess)
        {
            var result = saleService.GetAllAsDto(productList.Data, customerList.Data, subProductList.Data);
            if (result.IsSuccess)
                gridControl1.DataSource = result.Data;
        }
    }

    private void gridSale_DoubleClick(object sender, EventArgs e)
    {
        int saleId = Convert.ToInt32(gridSale.GetFocusedRowCellValue("SaleId"));
        
        if (saleService.GetById(saleId).Data.SubProductId == null)
        {
            int productId = (int)saleService.GetById(saleId).Data.ProductId;
            ShowEditForms<SaleAddForm>.ShowDialogEditForm(saleId, EventType.EntityUpdate, productService.GetById(productId).Data.SellPrice, true);

        }
        if (saleService.GetById(saleId).Data.ProductId == null)
        {
            int subProductId = (int)saleService.GetById(saleId).Data.SubProductId;
            ShowEditForms<SaleAddForm>.ShowDialogEditForm(saleId, EventType.EntityUpdate, productService.GetById(subProductId).Data.SellPrice, false);
        }
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
