using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using UI.Win.Enums;
using UI.Win.Forms.BaseForm;
using UI.Win.Forms.CarForms;
using UI.Win.Show;

namespace UI.Win.Forms.CustomerForm;

public partial class CustomerDialogListForm : BaseDialogListForm
{
    public CustomerDialogListForm()
    {
        InitializeComponent();
        FillGrid();
    }

    public int returnCustomerId;
    ICustomerService customerService = new CustomerManager(new EfCustomerDal());


    // RibbonControl's Code
    public override void AddEntity()
    {
        ShowEditForms<CarAddForm>.ShowDialogEditForm();
    }

    public override void RefreshGridControl()
    {
        FillGrid();
    }

    public override void SelectEntity()
    {
        SelectFocusedEntity();
    }


    // GridControl's Code
    public void FillGrid()
    {
        var result = customerService.GetAll();
        if (result.IsSuccess)
            gridControl1.DataSource = result.Data;
    }

    private void gridCustomer_DoubleClick(object sender, EventArgs e)
    {
        int customerId = Convert.ToInt32(gridCustomer.GetFocusedRowCellValue("CustomerId"));
        ShowEditForms<CustomerAddForm>.ShowDialogEditForm(customerId, EventType.EntityUpdate, true);
    }

    private void gridControl1_KeyPress_1(object sender, KeyPressEventArgs e)
    {
        returnCustomerId = Convert.ToInt32(gridCustomer.GetFocusedRowCellValue("CustomerId"));
        this.DialogResult = DialogResult.OK;
    }


    // Other Functions
    private void SelectFocusedEntity()
    {
        returnCustomerId = Convert.ToInt32(gridCustomer.GetFocusedRowCellValue("CustomerId"));
        this.DialogResult = DialogResult.OK;
    }
}
