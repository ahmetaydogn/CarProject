using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using UI.Win.Enums;
using UI.Win.Forms.BaseForm;
using UI.Win.Show;

namespace UI.Win.Forms.CarForms;

public partial class CarDialogListForm : BaseDialogListForm
{
    public CarDialogListForm()
    {
        InitializeComponent();
        FillGrid();
    }

    #region VARIABLES

    IProductService productService = new ProductManager(new EfProductDal());
    public int returnProductId;
    public decimal returnProductPrice;

    #endregion


    // RibbonControl's Code - Public Functions
    public override void AddEntity()
    {
        ShowEditForms<CarAddForm>.ShowDialogEditForm();
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
        var result = productService.GetAll();
        if (result.IsSuccess)
            gridControl1.DataSource = result.Data;
    }


    // Private Functions
    private void SelectFocusedEntity()
    {
        returnProductId = Convert.ToInt32(gridProduct.GetFocusedRowCellValue("ProductId"));
        returnProductPrice = productService.GetById(returnProductId).Data.SellPrice;
        this.DialogResult = DialogResult.OK;
    }

    // Event Functions
    private void gridProduct_DoubleClick(object sender, EventArgs e)
    {
        int productId = Convert.ToInt32(gridProduct.GetFocusedRowCellValue("ProductId"));
        ShowEditForms<CarAddForm>.ShowDialogEditForm(productId, EventType.EntityUpdate, true);
    }

    private void gridControl1_KeyPress_1(object sender, KeyPressEventArgs e)
    {
        SelectFocusedEntity();
    }
}
