using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using UI.Win.Enums;
using UI.Win.Forms.CarForms;
using UI.Win.Show;

namespace UI.Win.Forms.CarPartsForms;

public partial class CarPartListForm : Form
{
    public CarPartListForm()
    {
        InitializeComponent();
    }

    ISubProductService subProductService = new SubProductManager(new EfSubProductDal());

    public void FillGrid()
    {
        var result = subProductService.GetAll();
        if (result.IsSuccess)
            gridControl1.DataSource = result.Data;
    }

    private void gridCarPart_DoubleClick(object sender, EventArgs e)
    {
        int productId = Convert.ToInt32(gridCarPart.GetFocusedRowCellValue("ProductId"));
        ShowEditForms<CarAddForm>.ShowDialogEditForm(productId, EventType.EntityUpdate);
    }
}
