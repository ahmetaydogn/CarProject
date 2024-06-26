﻿using Business.Abstract;
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

    #region VARIABLES

    IProductService productService = new ProductManager(new EfProductDal());

    #endregion

    // Public Functions
    public void FillGrid()
    {
        var result = productService.GetAll();
        if (result.IsSuccess)
            gridControl1.DataSource = result.Data;
    }


    // Event Functions
    private void gridProduct_DoubleClick(object sender, EventArgs e)
    {
        int productId = Convert.ToInt32(gridProduct.GetFocusedRowCellValue("ProductId"));
        ShowEditForms<CarAddForm>.ShowDialogEditForm(productId, EventType.EntityUpdate);
    }
}
