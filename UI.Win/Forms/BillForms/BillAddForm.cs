using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DevExpress.XtraEditors;
using Entities.Concrete;
using FluentValidation;
using UI.Win.Enums;
using UI.Win.Forms.BaseForm;
using UI.Win.Forms.CustomerForm;
using UI.Win.Forms.SaleForm;
using UI.Win.Show;
using UI.Win.Utilities;

namespace UI.Win.Forms.BillForms;

public partial class BillAddForm : BaseEditForm
{
    public BillAddForm()
    {
        InitializeComponent();
        FillGaps();
    }

    public BillAddForm(string billNumber, EventType _eventType) : this()
    {
        InitializeComponent();
        var result = billService.GetByBillNumber(billNumber);
        if (result.IsSuccess)
        {
            BillNumber = billNumber;
            OldBill = result.Data;
            eventType = _eventType;
            btnSale.Enabled = false;
        }
        FillGaps();
    }

    ISaleService saleService = new SaleManager(new EfSaleDal());
    IBillService billService = new BillManager(new EfBillDal());
    Bill OldBill;
    EventType eventType = EventType.EntityInsert;
    public string BillNumber;


    private void btnSale_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
    {
        if (btnSale.Enabled)
        {
            var frm = (SaleDialogListForm)ShowListForms<SaleDialogListForm>.ShowDialogListForm();
            if (frm.DialogResult == DialogResult.OK)
            {
                var sale = saleService.GetById(frm.returnSaleId);
                btnSale.EditValue = frm.returnSaleId;
                calcPrice.Value = sale.Data.Price;
            }
        }
    }

    public override void Save()
    {
        try
        {
            if (eventType == EventType.EntityUpdate && OldBill != null)
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
            var result = billService.Delete(OldBill);
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
            txtBillNumber.Text = OldBill.BillId;
            btnSale.EditValue = OldBill.SaleId;
            calcPrice.EditValue = OldBill.Price;
            txtDescription.Text = OldBill.Description;
            BillNumber = OldBill.BillId;
        }
        else if (eventType == EventType.EntityInsert)
        {
            txtBillNumber.Text = GeneralFunctions.GetRandomBillNumber(billService);
            BillNumber = txtBillNumber.Text;
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
        OldBill = null;
        eventType = EventType.EntityInsert;

        txtBillNumber.Text = GeneralFunctions.GetRandomBillNumber(billService);
        BillNumber = txtBillNumber.Text;
    }

    public override void SendEntityToAdd()
    {
        var result = billService.Add(CreateBill());

        if (result.IsSuccess)
        {
            Messages.SuccessMessage(result.Message);
            Closing();
        }
    }

    public override void SendEntityToUpdate()
    {
        Bill newBill = CreateBill();
        newBill.BillId = OldBill.BillId;

        var result = billService.Update(newBill);
        if (result.IsSuccess)
        {
            Messages.SuccessMessage(result.Message);
            Closing();
        }
    }

    private Bill CreateBill()
    {
        Bill b = new Bill
        {
            BillId = txtBillNumber.Text,
            SaleId = Convert.ToInt32(btnSale.EditValue),
            Price = Convert.ToDecimal(calcPrice.Value),
            Description = txtDescription.Text,
            SaleDate = DateTime.Now,
        };

        return b;
    }

    private void Closing()
    {
        if (Application.OpenForms["BillListForm"] != null)
        {
            BillListForm listForm = (BillListForm)Application.OpenForms["BillListForm"];
            listForm.FillGrid();
        }

        Close();
    }
}
