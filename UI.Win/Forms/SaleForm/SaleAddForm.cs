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
using UI.Win.Forms.CustomerForm;
using UI.Win.Show;
using UI.Win.Utilities;

namespace UI.Win.Forms.SaleForm;

public partial class SaleAddForm : BaseEditForm
{
    public SaleAddForm()
    {
        InitializeComponent();
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

    string billNumber;
    ISaleService saleService = new SaleManager(new EfSaleDal());
    Sale OldSale;
    decimal productPrice;
    EventType eventType = EventType.EntityInsert;


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

    private void btnCustomer_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
    {
        var frm = (CustomerDialogListForm)ShowListForms<CustomerDialogListForm>.ShowDialogListForm();
        if (frm.DialogResult == DialogResult.OK)
            btnCustomer.EditValue = frm.returnCustomerId;
    }

    private void btnBill_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
    {
        if (btnBill.Enabled)
        {
            var frm = (BillDialogListForm)ShowListForms<BillDialogListForm>.ShowDialogListForm();
            if (frm.DialogResult == DialogResult.OK)
                btnBill.EditValue = frm.returnBillId;
        }
    }

    private void spnQuantity_ValueChanged(object sender, EventArgs e)
    {
        calcPrice.Value = spnQuantity.Value * productPrice;
    }


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

            btnProduct.EditValue = OldSale.ProductId;
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
                    sedit.Value = 0;
                    break;
                case ButtonEdit bedit:
                    bedit.EditValue = null;
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

    private Sale CreateSale()
    {
        Sale s = new Sale
        {
            CustomerId = Convert.ToInt32(btnCustomer.EditValue),
            ProductId = Convert.ToInt32(btnProduct.EditValue),
            SaleDate = DateTime.Now,
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
}
