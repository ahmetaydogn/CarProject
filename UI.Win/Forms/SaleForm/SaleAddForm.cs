using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DevExpress.XtraEditors;
using Entities.Concrete;
using FluentValidation;
using UI.Win.Enums;
using UI.Win.Forms.BaseForm;
using UI.Win.Forms.BillForms;
using UI.Win.Forms.CarForms;
using UI.Win.Forms.CarPartsForms;
using UI.Win.Forms.CustomerForm;
using UI.Win.Show;
using UI.Win.Utilities;

namespace UI.Win.Forms.SaleForm;

public partial class SaleAddForm : BaseEditForm
{
    public SaleAddForm()
    {
        InitializeComponent();
        ToggleProductAndSubProduct();
    }

    public SaleAddForm(int id, EventType _eventType, decimal sellPrice) : this()
    {
        var result = saleService.GetById(id);
        if (result.IsSuccess)
        {
            OldSale = result.Data;
            eventType = _eventType;
            productPrice = sellPrice;
            btnBill.Enabled = false;
            FillGaps();
        }
    }

    public SaleAddForm(int id, EventType _eventType, decimal sellPrice, bool _isGonnaAddProduct) : this()
    {
        var result = saleService.GetById(id);
        if (result.IsSuccess)
        {
            OldSale = result.Data;
            eventType = _eventType;
            productPrice = sellPrice;
            btnBill.Enabled = false;
            isGonnaAddProduct = _isGonnaAddProduct;
            FillGaps();
        }
    }

    public SaleAddForm(int id, EventType _eventType, decimal sellPrice, string _billNumber) : this()
    {
        var result = saleService.GetById(id);
        if (result.IsSuccess)
        {
            OldSale = result.Data;
            eventType = _eventType;
            productPrice = sellPrice;
            billNumber = _billNumber;
            btnBill.EditValue = billNumber;
            btnBill.Enabled = false;
            FillGaps();
        }
    }

    public SaleAddForm(string _billNumber) : this()
    {
        billNumber = _billNumber;
        btnBill.EditValue = billNumber;
        btnBill.Enabled = false;
    }

    public SaleAddForm(bool isAlreadyExistBillNumber, string _billNumber) : this()
    {
        this.isAlreadyExistBillNumber = isAlreadyExistBillNumber;
        billNumber = _billNumber;
        btnBill.EditValue = billNumber;
    }

    #region VARIABLES

    string billNumber;
    ISaleService saleService = new SaleManager(new EfSaleDal());
    Sale OldSale;
    decimal productPrice;
    EventType eventType = EventType.EntityInsert;
    bool isAlreadyExistBillNumber = false;
    private bool isGonnaAddProduct = false;

    #endregion


    // Public Functions
    public override void Save()
    {
        try
        {
            if (eventType == EventType.EntityUpdate && OldSale != null)
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
            var result = saleService.Delete(OldSale);
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
            if (isGonnaAddProduct)
            {
                btnProduct.EditValue = OldSale.ProductId;
            }
            else
            {
                tgsProductType.Toggle();
                ToggleProductAndSubProduct();
                btnSubProduct.EditValue = OldSale.SubProductId;
            }
            btnCustomer.EditValue = OldSale.CustomerId;
            calcPrice.Value = OldSale.Price;
            cmbPaymentMethod.Text = OldSale.PaymentMethod;
            spnQuantity.Value = OldSale.Quantity;
            btnBill.EditValue = OldSale.BillNumber;

            //btnProduct.DataContext = productService.GetAll().Data;
            //btnCustomer.DataContext = customerService.GetAll().Data;
        }
        else
            Messages.ItMustBeEntityUpdate();

        if (billNumber != null)
        {
            btnBill.EditValue = billNumber;
            btnBill.ReadOnly = true;
        }
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
        OldSale = null;
        eventType = EventType.EntityInsert;

        if (billNumber != null)
        {
            btnBill.EditValue = billNumber;
            btnBill.ReadOnly = true;
        }
    }

    public override void SendEntityToAdd()
    {
        var result = saleService.Add(CreateSale());

        if (result.IsSuccess)
        {
            Messages.SuccessMessage(result.Message);
            Closing();
        }
    }

    public override void SendEntityToUpdate()
    {
        Sale newSale = CreateSale();
        newSale.SaleId = OldSale.SaleId;

        var result = saleService.Update(newSale);
        if (result.IsSuccess)
        {
            Messages.SuccessMessage(result.Message);
            Closing();
        }
    }


    // Private Functions
    private Sale CreateSale()
    {
        Sale s = new Sale
        {
            CustomerId = Convert.ToInt32(btnCustomer.EditValue),
            ProductId = Convert.ToInt32(btnProduct.EditValue) == 0 ? null : Convert.ToInt32(btnProduct.EditValue),
            SubProductId = Convert.ToInt32(btnSubProduct.EditValue) == 0 ? null : Convert.ToInt32(btnSubProduct.EditValue),
            SaleDate = eventType == EventType.EntityInsert ? DateTime.Now : OldSale.SaleDate,
            PaymentMethod = cmbPaymentMethod.Text,
            Price = calcPrice.Value,
            Quantity = Convert.ToInt16(spnQuantity.Value),
            BillNumber = btnBill.Text,
        };

        return s;
    }

    private void Closing()
    {
        if (Application.OpenForms["SaleListForm"] != null)
        {
            SaleListForm listForm = (SaleListForm)Application.OpenForms["SaleListForm"];
            listForm.FillGrid();
        }

        Close();
    }

    private void ToggleProductAndSubProduct()
    {
        isGonnaAddProduct = !isGonnaAddProduct;

        if (isGonnaAddProduct)
        {
            btnProduct.Enabled = true;
            btnSubProduct.Enabled = false;
            btnSubProduct.EditValue = null;
        }
        else
        {
            btnSubProduct.Enabled = true;
            btnProduct.Enabled = false;
            btnProduct.EditValue = null;
        }

        spnQuantity.Value = 0;
        calcPrice.Value = 0;
    }

    // Event Functions
    private void toggleSwitch1_Toggled(object sender, EventArgs e)
    {
        ToggleProductAndSubProduct();
    }

    private void btnProduct_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
    {
        var frm = (CarDialogListForm)ShowListForms<CarDialogListForm>.ShowDialogListForm();
        if (frm.DialogResult == DialogResult.OK)
        {
            btnProduct.EditValue = frm.returnProductId;
            productPrice = frm.returnProductPrice;
            calcPrice.Value = spnQuantity.Value * productPrice;
        }
    }

    private void btnSubProduct_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
    {
        var frm = (CarPartDialogListForm)ShowListForms<CarPartDialogListForm>.ShowDialogListForm();
        if (frm.DialogResult == DialogResult.OK)
        {
            btnSubProduct.EditValue = frm.returnSubProductId;
            productPrice = frm.returnSubProductPrice;
            calcPrice.Value = spnQuantity.Value * productPrice;
        }
    }

    private void btnCustomer_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
    {
        var frm = (CustomerDialogListForm)ShowListForms<CustomerDialogListForm>.ShowDialogListForm();
        if (frm.DialogResult == DialogResult.OK)
            btnCustomer.EditValue = frm.returnCustomerId;
    }

    private void btnBill_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
    {
        if (!isAlreadyExistBillNumber)
        {
            if (btnBill.Enabled)
            {
                var frm = (BillDialogListForm)ShowListForms<BillDialogListForm>.ShowDialogListForm();
                if (frm.DialogResult == DialogResult.OK)
                    btnBill.EditValue = frm.returnBillId;
            }
        }
        else
        {
            btnBill.EditValue = billNumber;
        }
    }

    private void spnQuantity_ValueChanged(object sender, EventArgs e)
    {
        calcPrice.Value = spnQuantity.Value * productPrice;
    }

}
