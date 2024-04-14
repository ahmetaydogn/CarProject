using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DevExpress.XtraEditors;
using Entities.Concrete;
using FluentValidation;
using UI.Win.Enums;
using UI.Win.Forms.BaseForm;
using UI.Win.Utilities;

namespace UI.Win.Forms.CarForms;

public partial class CarAddForm : BaseEditForm
{
    public CarAddForm()
    {
        InitializeComponent();
    }

    public CarAddForm(int id, EventType _eventType) : this()
    {
        var result = productService.GetById(id);
        if (result.IsSuccess)
        {
            OldProduct = result.Data;
            eventType = _eventType;
            FillGaps();
        }
    }

    IProductService productService = new ProductManager(new EfProductDal());
    Product OldProduct;
    EventType eventType = EventType.EntityInsert;


    public override void Save()
    {
        try
        {
            if (eventType == EventType.EntityUpdate && OldProduct != null)
            {
                SendEntityToUpdate();
            }
            else
            {
                SendEntityToAdd();
            }
        }
        catch (ValidationException e)
        {
            Messages.ErrorMessage(e.Message);
        }
    }

    public override void SaveAs()
    {
        try
        {
            if (eventType == EventType.EntityInsert)
            {
                Messages.ItMustBeEntityUpdate();
            }
            else
            {
                SendEntityToAdd();
            }
        } 
        catch (ValidationException e)
        {
            Messages.ErrorMessage(e.Message);
        }
    }

    public override void DeleteEntity()
    {
        if (eventType == EventType.EntityInsert)
        {
            Messages.ItMustBeEntityUpdate();
        }
        else
        {
            var result = productService.Delete(OldProduct);
            if (result.IsSuccess)
            {
                Messages.SuccessMessage(result.Message);
                Closing();
            }
            else
            {
                Messages.ErrorMessage(result.Message);
            }
        }
    }

    public override void FillGaps()
    {
        if (eventType == EventType.EntityUpdate)
        {
            txtProductName.Text = OldProduct.ProductName;
            txtProductModel.Text = OldProduct.ProductModel;
            txtProductKM.Text = OldProduct.ProductKM;
            txtProductColor.Text = OldProduct.ProductColor;
            spnProductMarketPrice.Value = OldProduct.MarketPrice;
            spnProductSellPrice.Value = OldProduct.SellPrice;
            spnProductVAT.Value = OldProduct.VAT;
            spnProductVATPrice.Value = OldProduct.VATPrice;
            spnProductQuantity.Value = OldProduct.Quantity;
            txtDescription.Text = OldProduct.ProductDescription;
            tgsProductSituation.IsOn = OldProduct.ProductSituation == "Sifir" ? false : true;
        }
        else
            Messages.ItMustBeEntityUpdate();
    }

    public override void ClearData()
    {
        foreach (var component in myDataLayoutControl1.Controls)
        {
            switch (component)
            {
                case SpinEdit sedit:
                    sedit.Value = 0;
                    break;
                case MemoEdit medit:
                    medit.Text = null;
                    break;
                case TextEdit tedit:
                    tedit.Text = null;
                    break;
                case ToggleSwitch tgs:
                    tgs.IsOn = false;
                    break;
            }
        }
        OldProduct = null;
        eventType = EventType.EntityInsert;
    }

    public override void SendEntityToAdd()
    {
        var result = productService.Add(CreateProduct());

        if (result.IsSuccess)
        {
            Messages.SuccessMessage(result.Message);
            Closing();
        }
    }

    public override void SendEntityToUpdate()
    {
        Product newProduct = CreateProduct();
        newProduct.ProductId = OldProduct.ProductId;

        var result = productService.Update(newProduct);
        if (result.IsSuccess)
        {
            Messages.SuccessMessage(result.Message);
            Closing();
        }
    }

    private Product CreateProduct()
    {
        Product p = new Product
        {
            ProductName = txtProductName.Text,
            ProductModel = txtProductModel.Text,
            ProductKM = txtProductKM.Text,
            ProductColor = txtProductColor.Text,
            MarketPrice = spnProductMarketPrice.Value,
            SellPrice = spnProductSellPrice.Value,
            VAT = Convert.ToByte(spnProductVAT.Value),
            VATPrice = spnProductVATPrice.Value,
            Quantity = Convert.ToInt16(spnProductQuantity.Value),
            ProductSituation = tgsProductSituation.IsOn == true ? "İkinci El" : "Sifir",
            ProductDescription = txtDescription.Text
        };

        return p;
    }

    private void Closing()
    {
        if (Application.OpenForms["CarListForm"] != null)
        {
            CarListForm listForm = (CarListForm)Application.OpenForms["CarListForm"];
            listForm.FillGrid();
        }

        Close();
    }
}
