using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using UI.Win.Enums;
using UI.Win.Forms.BaseForm;
using UI.Win.Show;

namespace UI.Win.Forms.BillForms;

public partial class BillDialogListForm : BaseDialogListForm
{
    public BillDialogListForm()
    {
        InitializeComponent();
        FillGrid();
        base.HideAddButton();
    }

    #region VARIABLES

    IBillService billService = new BillManager(new EfBillDal());
    public int returnBillId;

    #endregion

    // RibbonControl's Code - Public Functions
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
        var result = billService.GetAll();
        if (result.IsSuccess)
            gridControl1.DataSource = result.Data;
    }


    // Private Functions
    private void SelectFocusedEntity()
    {
        returnBillId = Convert.ToInt32(gridBill.GetFocusedRowCellValue("BillId"));
        this.DialogResult = DialogResult.OK;
    }


    // Event Functions
    private void gridBill_DoubleClick(object sender, EventArgs e)
    {
        string billId = gridBill.GetFocusedRowCellValue("BillId").ToString();
        ShowEditForms<BillAddForm>.ShowDialogEditForm(billId, EventType.EntityUpdate);
    }

    private void gridControl1_KeyPress(object sender, KeyPressEventArgs e)
    {
        SelectFocusedEntity();
    }
}
