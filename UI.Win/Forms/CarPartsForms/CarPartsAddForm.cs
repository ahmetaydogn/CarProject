using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DevExpress.XtraEditors;
using Entities.Concrete;
using FluentValidation;
using UI.Win.Enums;
using UI.Win.Forms.BaseForm;
using UI.Win.Forms.CarForms;
using UI.Win.Utilities;

namespace UI.Win.Forms.CarPartsForms;

public partial class CarPartsAddForm : BaseEditForm
{
    public CarPartsAddForm()
    {
        InitializeComponent();
    }

    public CarPartsAddForm(int id, EventType _eventType) : this()
    {
        var result = subProductService.GetById(id);
        if (result.IsSuccess)
        {
            OldSubProduct = result.Data;
            eventType = _eventType;
            FillGaps();
        }
    }

    ISubProductService subProductService = new SubProductManager(new EfSubProductDal());
    SubProduct OldSubProduct;
    EventType eventType = EventType.EntityInsert;


    public override void Save()
    {
        try
        {
            if (eventType == EventType.EntityUpdate && OldSubProduct != null)
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
            var result = subProductService.Delete(OldSubProduct);
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
            txtSubProductName.Text = OldSubProduct.SubProductName;
            spnMarketPrice.Value = OldSubProduct.MarketPrice;
            spnSellPrice.Value = OldSubProduct.SellPrice;
            cmbVAT.Text = OldSubProduct.VAT;
            spnQuantity.Value = OldSubProduct.Quantity;
            txtDescription.Text = OldSubProduct.SubProductDescription;
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
        OldSubProduct = null;
        eventType = EventType.EntityInsert;
    }

    public override void SendEntityToAdd()
    {
        var result = subProductService.Add(CreateProduct());

        if (result.IsSuccess)
        {
            Messages.SuccessMessage(result.Message);
            Closing();
        }
    }

    public override void SendEntityToUpdate()
    {
        SubProduct newSubProduct = CreateProduct();
        newSubProduct.SubProductId = OldSubProduct.SubProductId;

        var result = subProductService.Update(newSubProduct);
        if (result.IsSuccess)
        {
            Messages.SuccessMessage(result.Message);
            Closing();
        }
    }

    private SubProduct CreateProduct()
    {
        SubProduct p = new SubProduct
        {
            SubProductName = txtSubProductName.Text,
            MarketPrice = spnMarketPrice.Value,
            SellPrice = spnSellPrice.Value,
            Quantity = Convert.ToInt16(spnQuantity.Value),
            VAT = cmbVAT.Text,
            VATPrice = calcVATPrice.Value,
            SubProductDescription = txtDescription.Text,
            Profit = CalculateProfit(),
        };

        return p;
    }

    private void Closing()
    {
        if (Application.OpenForms["CarPartListForm"] != null)
        {
            CarPartListForm listForm = (CarPartListForm)Application.OpenForms["CarPartListForm"];
            listForm.FillGrid();
        }

        Close();
    }

    private decimal CalculateProfit()
    {
        var marketPrice = spnMarketPrice.Value;
        var sellPrice = spnSellPrice.Value;
        var vatPercent = Convert.ToInt32(cmbVAT.EditValue);

        // Kazanç = Satış Fiyatı - (Alış Fiyatı + Kdv + Ötv) - Sanırım böyle :D
        var profit = sellPrice - ((marketPrice + (marketPrice * vatPercent / 100)));
        return profit;
    }

    private void ChangeTaxesComponents()
    {
        var marketPrice = spnMarketPrice.Value;
        var vatPercent = Convert.ToInt32(cmbVAT.EditValue);
        calcVATPrice.Value = marketPrice * vatPercent / 100;

        txtProfit.Text = Convert.ToInt32(CalculateProfit()).ToString();
    }

    private void spnSellPrice_EditValueChanged(object sender, EventArgs e)
    {
        ChangeTaxesComponents();
    }

    private void spnMarketPrice_EditValueChanged(object sender, EventArgs e)
    {
        ChangeTaxesComponents();
    }

    private void spnQuantity_EditValueChanged(object sender, EventArgs e)
    {
        ChangeTaxesComponents();
    }

    private void cmbVAT_EditValueChanged(object sender, EventArgs e)
    {
        ChangeTaxesComponents();
    }
}
