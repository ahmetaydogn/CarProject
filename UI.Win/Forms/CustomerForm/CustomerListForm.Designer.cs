﻿namespace UI.Win.Forms.CustomerForm
{
    partial class CustomerListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridCustomer = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            gridCustomerSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            gridCustomerPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            gridCustomerAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            gridTaxNo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridCustomer).BeginInit();
            SuspendLayout();
            // 
            // gridControl1
            // 
            gridControl1.Dock = DockStyle.Fill;
            gridControl1.Location = new Point(0, 0);
            gridControl1.MainView = gridCustomer;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(1082, 603);
            gridControl1.TabIndex = 0;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridCustomer });
            gridControl1.DoubleClick += gridControl1_DoubleClick;
            gridControl1.KeyPress += gridControl1_KeyPress;
            // 
            // gridCustomer
            // 
            gridCustomer.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridCustomerName, gridCustomerSurname, gridCustomerPhone, gridCustomerAddress, gridTaxNo });
            gridCustomer.GridControl = gridControl1;
            gridCustomer.Name = "gridCustomer";
            gridCustomer.OptionsBehavior.Editable = false;
            // 
            // gridCustomerName
            // 
            gridCustomerName.Caption = "Cari İsmi";
            gridCustomerName.FieldName = "CustomerName";
            gridCustomerName.MinWidth = 25;
            gridCustomerName.Name = "gridCustomerName";
            gridCustomerName.Visible = true;
            gridCustomerName.VisibleIndex = 0;
            gridCustomerName.Width = 94;
            // 
            // gridCustomerSurname
            // 
            gridCustomerSurname.Caption = "Cari Soyismi";
            gridCustomerSurname.FieldName = "CustomerSurname";
            gridCustomerSurname.MinWidth = 25;
            gridCustomerSurname.Name = "gridCustomerSurname";
            gridCustomerSurname.Visible = true;
            gridCustomerSurname.VisibleIndex = 1;
            gridCustomerSurname.Width = 94;
            // 
            // gridCustomerPhone
            // 
            gridCustomerPhone.Caption = "Telefon No";
            gridCustomerPhone.DisplayFormat.FormatString = "{0:###-###-####}";
            gridCustomerPhone.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            gridCustomerPhone.FieldName = "CustomerPhone";
            gridCustomerPhone.MinWidth = 25;
            gridCustomerPhone.Name = "gridCustomerPhone";
            gridCustomerPhone.Visible = true;
            gridCustomerPhone.VisibleIndex = 2;
            gridCustomerPhone.Width = 94;
            // 
            // gridCustomerAddress
            // 
            gridCustomerAddress.Caption = "Adres";
            gridCustomerAddress.FieldName = "CustomerAddress";
            gridCustomerAddress.MinWidth = 25;
            gridCustomerAddress.Name = "gridCustomerAddress";
            gridCustomerAddress.Visible = true;
            gridCustomerAddress.VisibleIndex = 4;
            gridCustomerAddress.Width = 94;
            // 
            // gridTaxNo
            // 
            gridTaxNo.Caption = "Vergi Numarası";
            gridTaxNo.FieldName = "CustomerTaxNo";
            gridTaxNo.MinWidth = 25;
            gridTaxNo.Name = "gridTaxNo";
            gridTaxNo.Visible = true;
            gridTaxNo.VisibleIndex = 3;
            gridTaxNo.Width = 94;
            // 
            // CustomerListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 603);
            Controls.Add(gridControl1);
            Name = "CustomerListForm";
            Text = "CustomerListForm";
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridCustomer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn gridCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn gridCustomerSurname;
        private DevExpress.XtraGrid.Columns.GridColumn gridCustomerPhone;
        private DevExpress.XtraGrid.Columns.GridColumn gridCustomerAddress;
        private DevExpress.XtraGrid.Columns.GridColumn gridTaxNo;
    }
}