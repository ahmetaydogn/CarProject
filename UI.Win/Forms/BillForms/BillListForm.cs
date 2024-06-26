﻿using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using UI.Win.Enums;
using UI.Win.Show;

namespace UI.Win.Forms.BillForms;

public partial class BillListForm : Form
{
    public BillListForm()
    {
        InitializeComponent();
        FillGrid();
    }

    #region VARIABLES

    IBillService billService = new BillManager(new EfBillDal());
    
    #endregion

    // Fill the GridControl
    public void FillGrid()
    {
        var result = billService.GetAll();
        if (result.IsSuccess)
            gridControl1.DataSource = result.Data;
    }

    // Event Functions
    private void gridBill_DoubleClick(object sender, EventArgs e)
    {
        string billId = gridBill.GetFocusedRowCellValue("BillId").ToString();
        ShowListForms<BillSaleListForm>.ShowDialogListForm(billId);
    }

    private void gridControl1_KeyPress(object sender, KeyPressEventArgs e)
    {
        string billId = gridBill.GetFocusedRowCellValue("BillId").ToString();
        ShowEditForms<BillAddForm>.ShowDialogEditForm(billId, EventType.EntityUpdate);
    }
}
