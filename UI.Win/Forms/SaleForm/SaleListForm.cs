using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using UI.Win.Enums;
using UI.Win.Show;

namespace UI.Win.Forms.SaleForm;

public partial class SaleListForm : Form
{
    public SaleListForm()
    {
        InitializeComponent();
        FillGrid();
    }

    #region VARIABLES
    
    ISaleService saleService = new SaleManager(new EfSaleDal());
    ICustomerService customerService = new CustomerManager(new EfCustomerDal());
    IProductService productService = new ProductManager(new EfProductDal());
    ISubProductService subProductService = new SubProductManager(new EfSubProductDal());

    #endregion

    // Public Functions
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

    // Event Functions
    private void gridControl1_DoubleClick(object sender, EventArgs e)
    {
        int saleId = Convert.ToInt32(gridSale.GetFocusedRowCellValue("SaleId"));
        int? productId = Convert.ToInt32(gridSale.GetFocusedRowCellValue("ProductId"));
        int? subProductId = Convert.ToInt32(gridSale.GetFocusedRowCellValue("SubProductId"));

        if (subProductId == 0)
        {
            ShowEditForms<SaleAddForm>.ShowDialogEditForm(saleId, EventType.EntityUpdate, productService.GetById(Convert.ToInt32(productId)).Data.SellPrice, true);
        }
        else if (productId == 0)
        {
            ShowEditForms<SaleAddForm>.ShowDialogEditForm(saleId, EventType.EntityUpdate, subProductService.GetById(Convert.ToInt32(subProductId)).Data.SellPrice, false);
        }
    }
}
