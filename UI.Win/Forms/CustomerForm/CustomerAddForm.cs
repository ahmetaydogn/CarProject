using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DevExpress.XtraEditors;
using Entities.Concrete;
using FluentValidation;
using UI.Win.Enums;
using UI.Win.Forms.BaseForm;
using UI.Win.Utilities;

namespace UI.Win.Forms.CustomerForm;

public partial class CustomerAddForm : BaseEditForm
{
    public CustomerAddForm()
    {
        InitializeComponent();
    }

    public CustomerAddForm(int id, EventType _eventType) : this()
    {
        var result = customerService.Get(id);
        if (result.IsSuccess)
        {
            OldCustomer = result.Data;
            eventType = _eventType;
            FillGaps();
        }
    }

    public CustomerAddForm(int id, EventType _eventType, bool isOpenedFromDialog) : this()
    {
        var result = customerService.Get(id);
        if (result.IsSuccess)
        {
            OldCustomer = result.Data;
            eventType = _eventType;
            FillGaps();
            base.HideDeleteButton();
            _isOpenedFromDialog = isOpenedFromDialog;
        }
    }

    #region VARIABLES

    ISaleService saleService = new SaleManager(new EfSaleDal());
    ICustomerService customerService = new CustomerManager(new EfCustomerDal());
    Customer OldCustomer;
    private readonly bool _isOpenedFromDialog;
    EventType eventType = EventType.EntityInsert;

    #endregion


    // Public Functions
    public override void Save()
    {
        try
        {
            if (eventType == EventType.EntityUpdate && OldCustomer != null)
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
            var saleResult = saleService.GetAllByCustomer(OldCustomer.CustomerId);
            if (saleResult.IsSuccess)
                foreach (var sale in saleResult.Data)
                    saleService.Delete(sale);
            var result = customerService.Delete(OldCustomer);
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
            txtCustomerName.Text = OldCustomer.CustomerName;
            txtCustomerSurname.Text = OldCustomer.CustomerSurname;
            txtCustomerPhone.Text = OldCustomer.CustomerPhone;
            txtTaxNo.Text = OldCustomer.CustomerTaxNo;
            txtAddress.Text = OldCustomer.CustomerAddress;
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
        OldCustomer = null;
        eventType = EventType.EntityInsert;
    }

    public override void SendEntityToAdd()
    {
        var result = customerService.Add(CreateCustomer());

        if (result.IsSuccess)
        {
            Messages.SuccessMessage(result.Message);
            Closing();
        }
    }

    public override void SendEntityToUpdate()
    {
        Customer newCustomer = CreateCustomer();
        newCustomer.CustomerId = OldCustomer.CustomerId;

        var result = customerService.Update(newCustomer);
        if (result.IsSuccess)
        {
            Messages.SuccessMessage(result.Message);
            Closing();
        }
    }


    // Private Functions
    private Customer CreateCustomer()
    {
        Customer c = new Customer
        {
            CustomerName = txtCustomerName.Text,
            CustomerSurname = txtCustomerSurname.Text,
            CustomerPhone = txtCustomerPhone.Text,
            CustomerTaxNo = txtTaxNo.Text,
            CustomerAddress = txtAddress.Text,
        };

        return c;
    }

    private void Closing()
    {
        if (Application.OpenForms["CustomerListForm"] != null)
        {
            CustomerListForm listForm = (CustomerListForm)Application.OpenForms["CustomerListForm"];
            listForm.FillGrid();
        }

        Close();
    }
}
