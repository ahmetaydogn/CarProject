using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using UI.Win.Enums;
using UI.Win.Forms.CarForms;
using UI.Win.Show;

namespace UI.Win.Forms.SaleForm;

public partial class SaleListForm : Form
{
    public SaleListForm()
    {
        InitializeComponent();
        FillGrid();
    }

    ISaleService saleService = new SaleManager(new EfSaleDal());
    ICustomerService customerService = new CustomerManager(new EfCustomerDal());
    IProductService productService = new ProductManager(new EfProductDal());

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

    private void gridControl1_DoubleClick(object sender, EventArgs e)
    {
        int saleId = Convert.ToInt32(gridSale.GetFocusedRowCellValue("SaleId"));
        int productId = Convert.ToInt32(gridSale.GetFocusedRowCellValue("ProductId"));
        int customerId = Convert.ToInt32(gridSale.GetFocusedRowCellValue("CustomerId"));
        
        ShowEditForms<SaleAddForm>.ShowDialogEditForm(saleId, EventType.EntityUpdate, productService.GetById(productId).Data.SellPrice);
    }
}
