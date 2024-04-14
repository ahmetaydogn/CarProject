using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using UI.Win.Enums;
using UI.Win.Show;

namespace UI.Win.Forms.CarForms;

public partial class CarListForm : Form
{

    public CarListForm()
    {
        InitializeComponent();
        FillGrid();
    }

    IProductService productService = new ProductManager(new EfProductDal());
    public int returnProductId;
    public decimal returnProductPrice;

    public void FillGrid()
    {
        var result = productService.GetAll();
        if (result.IsSuccess)
            gridControl1.DataSource = result.Data;
    }

    private void gridProduct_DoubleClick(object sender, EventArgs e)
    {
        int productId = Convert.ToInt32(gridProduct.GetFocusedRowCellValue("ProductId"));
        ShowEditForms<CarAddForm>.ShowDialogEditForm(productId, EventType.EntityUpdate);
    }

    private void gridControl1_KeyPress(object sender, KeyPressEventArgs e)
    {
        returnProductId = Convert.ToInt32(gridProduct.GetFocusedRowCellValue("ProductId"));
        returnProductPrice = productService.GetById(returnProductId).Data.SellPrice;
        this.DialogResult = DialogResult.OK;
    }
}
