using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace UI.Win.Forms.MainForm;

public partial class HomePageForm : Form
{
    public HomePageForm()
    {
        InitializeComponent();
        FillAllGrid();
    }

    ISaleService saleService = new SaleManager(new EfSaleDal());
    IProductService productService = new ProductManager(new EfProductDal());
    ISubProductService subProductService = new SubProductManager(new EfSubProductDal());
    ICustomerService customerService = new CustomerManager(new EfCustomerDal());

    public void FillAllGrid()
    {
        var customerList = customerService.GetAll();
        var productList = productService.GetAll();
        var subProductList = subProductService.GetAll();
        if (customerList.IsSuccess && productList.IsSuccess)
        {
            var result = saleService.GetAllAsDto(productList.Data, customerList.Data, subProductList.Data);
            if (result.IsSuccess)
                gridSaleControl.DataSource = result.Data.OrderBy(x => x.SaleDate);
            gridProductControl.DataSource = productList.Data.OrderBy(x => x.ProductAddDate);
        }
        if (subProductList.IsSuccess)
            gridCarPartControl.DataSource = subProductList.Data.OrderBy(x => x.SubProductAddDate);
    }
}
