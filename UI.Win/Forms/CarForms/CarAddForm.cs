using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.Design;
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

    public CarAddForm(int id, EventType _eventType, bool _isOpenedFromDialog) : this()
    {
        var result = productService.GetById(id);
        if (result.IsSuccess)
        {
            OldProduct = result.Data;
            eventType = _eventType;
            FillGaps();
            isOpenedFromDialog = _isOpenedFromDialog;
            base.HideDeleteButton();
        }
    }

    ISaleService saleService = new SaleManager(new EfSaleDal());
    IProductService productService = new ProductManager(new EfProductDal());
    Product OldProduct;
    EventType eventType = EventType.EntityInsert;
    private readonly bool isOpenedFromDialog;


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
            var saleResult = saleService.GetAllByCustomer(OldProduct.ProductId);
            if (saleResult.IsSuccess)
                foreach (var sale in saleResult.Data)
                    saleService.Delete(sale);
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
            cmbVAT.Text = OldProduct.VAT;
            calcVATPrice.Value = OldProduct.VATPrice;
            cmbExciseDuty.Text = OldProduct.ExciseDuty;
            calcExciseDutyPrice.Value = OldProduct.ExciseDutyPrice;
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
                    sedit.Value = 1;
                    break;
                case CalcEdit cedit:
                    cedit.Value = 1;
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
        newProduct.ProductAddDate = OldProduct.ProductAddDate;

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
            VAT = cmbVAT.Text,
            VATPrice = calcVATPrice.Value,
            ExciseDuty = cmbExciseDuty.Text,
            ExciseDutyPrice = calcExciseDutyPrice.Value,
            ProductSituation = tgsProductSituation.IsOn == true ? "İkinci El" : "Sifir",
            ProductDescription = txtDescription.Text,
            ProductAddDate = DateTime.Now,
            Profit = CalculateProfit(),
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

    private decimal CalculateProfit()
    {
        var marketPrice = spnProductMarketPrice.Value;
        var sellPrice = spnProductSellPrice.Value;
        var vatPercent = Convert.ToInt32(cmbVAT.EditValue);
        var excisePercent = Convert.ToInt32(cmbExciseDuty.EditValue);

        // Kazanç = Satış Fiyatı - (Alış Fiyatı + Kdv + Ötv) - Sanırım böyle :D
        var profit = sellPrice - ((marketPrice + (marketPrice * vatPercent / 100)) + (marketPrice * excisePercent / 100));
        return profit;
    }

    private void ChangeTaxesComponents()
    {
        var marketPrice = spnProductMarketPrice.Value;
        var vatPercent = Convert.ToInt32(cmbVAT.EditValue);
        var excisePercent = Convert.ToInt32(cmbExciseDuty.EditValue);

        calcVATPrice.Value = marketPrice * vatPercent / 100;
        calcExciseDutyPrice.Value = marketPrice * excisePercent / 100;

        txtProfit.Text = Convert.ToInt32(CalculateProfit()).ToString();
    }

    private void spnProductMarketPrice_EditValueChanged(object sender, EventArgs e)
    {
        ChangeTaxesComponents();
    }

    private void spnProductSellPrice_EditValueChanged(object sender, EventArgs e)
    {
        ChangeTaxesComponents();
    }

    private void cmbVAT_EditValueChanged(object sender, EventArgs e)
    {
        ChangeTaxesComponents();
    }

    private void cmbExciseDuty_EditValueChanged(object sender, EventArgs e)
    {
        ChangeTaxesComponents();
    }

    private void spnProductQuantity_EditValueChanged(object sender, EventArgs e)
    {
        ChangeTaxesComponents();
    }
}
