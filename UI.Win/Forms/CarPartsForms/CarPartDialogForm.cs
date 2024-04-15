using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using UI.Win.Enums;
using UI.Win.Forms.BaseForm;
using UI.Win.Show;

namespace UI.Win.Forms.CarPartsForms;

public partial class CarPartDialogListForm : BaseDialogListForm
{
    public CarPartDialogListForm()
    {
        InitializeComponent();
        FillGrid();
    }

    ISubProductService subProductService = new SubProductManager(new EfSubProductDal());
    public int returnSubProductId;
    public decimal returnSubProductPrice;


    // RibbonControl's Code
    public override void AddEntity()
    {
        ShowEditForms<CarPartsAddForm>.ShowDialogEditForm();
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
        var result = subProductService.GetAll();
        if (result.IsSuccess)
            gridControl1.DataSource = result.Data;
    }

    private void gridCarPart_DoubleClick(object sender, EventArgs e)
    {
        int productId = Convert.ToInt32(gridCarPart.GetFocusedRowCellValue("SubProductId"));
        ShowEditForms<CarPartsAddForm>.ShowDialogEditForm(productId, EventType.EntityUpdate, true);
    }

    private void gridControl1_KeyPress(object sender, KeyPressEventArgs e)
    {
        SelectFocusedEntity();
    }


    // Other Functions
    private void SelectFocusedEntity()
    {
        returnSubProductId = Convert.ToInt32(gridCarPart.GetFocusedRowCellValue("SubProductId"));
        returnSubProductPrice = subProductService.GetById(returnSubProductId).Data.SellPrice;
        this.DialogResult = DialogResult.OK;
    }
}
