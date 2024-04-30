namespace UI.Win.Forms.BillForms
{
    partial class BillDialogListForm
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
            gridBill = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridBillId = new DevExpress.XtraGrid.Columns.GridColumn();
            gridDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            gridPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridBill).BeginInit();
            SuspendLayout();
            // 
            // ribbonControl1
            // 
            ribbonControl1.ExpandCollapseItem.Id = 0;
            ribbonControl1.Size = new Size(1232, 126);
            ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // gridControl1
            // 
            gridControl1.Dock = DockStyle.Fill;
            gridControl1.Location = new Point(0, 126);
            gridControl1.MainView = gridBill;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(1232, 577);
            gridControl1.TabIndex = 1;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridBill });
            gridControl1.KeyPress += gridControl1_KeyPress;
            // 
            // gridBill
            // 
            gridBill.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridBillId, gridDescription, gridPrice });
            gridBill.GridControl = gridControl1;
            gridBill.Name = "gridBill";
            gridBill.OptionsBehavior.Editable = false;
            gridBill.DoubleClick += gridBill_DoubleClick;
            // 
            // gridBillId
            // 
            gridBillId.Caption = "Fatura Numarası";
            gridBillId.FieldName = "BillId";
            gridBillId.MinWidth = 25;
            gridBillId.Name = "gridBillId";
            gridBillId.Visible = true;
            gridBillId.VisibleIndex = 0;
            gridBillId.Width = 94;
            // 
            // gridDescription
            // 
            gridDescription.Caption = "Fatura Açıklaması";
            gridDescription.FieldName = "Description";
            gridDescription.MinWidth = 25;
            gridDescription.Name = "gridDescription";
            gridDescription.Visible = true;
            gridDescription.VisibleIndex = 1;
            gridDescription.Width = 94;
            // 
            // gridPrice
            // 
            gridPrice.Caption = "Fatura Tutarı";
            gridPrice.FieldName = "Price";
            gridPrice.MinWidth = 25;
            gridPrice.Name = "gridPrice";
            gridPrice.Visible = true;
            gridPrice.VisibleIndex = 2;
            gridPrice.Width = 94;
            // 
            // BillDialogListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 703);
            Controls.Add(gridControl1);
            Name = "BillDialogListForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fatura Diyalog Formu";
            Controls.SetChildIndex(ribbonControl1, 0);
            Controls.SetChildIndex(gridControl1, 0);
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridBill).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridBill;
        private DevExpress.XtraGrid.Columns.GridColumn gridBillId;
        private DevExpress.XtraGrid.Columns.GridColumn gridDescription;
        private DevExpress.XtraGrid.Columns.GridColumn gridPrice;
    }
}