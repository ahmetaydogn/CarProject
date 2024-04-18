using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using UI.Win.Enums;
using UI.Win.Show;

namespace UI.Win.Forms.CustomerForm;

public partial class CustomerListForm : Form
{
    public CustomerListForm()
    {
        InitializeComponent();
        FillGrid();
    }

    #region VARIABLES

    ICustomerService customerService = new CustomerManager(new EfCustomerDal());

    #endregion

    // Public Funcitons
    public void FillGrid()
    {
        var result = customerService.GetAll();
        if (result.IsSuccess)
            gridControl1.DataSource = result.Data;
    }


    // Event Functions
    private void gridControl1_DoubleClick(object sender, EventArgs e)
    {
        int customerId = Convert.ToInt32(gridCustomer.GetFocusedRowCellValue("CustomerId"));
        ShowEditForms<CustomerAddForm>.ShowDialogEditForm(customerId, EventType.EntityUpdate);
    }
}
