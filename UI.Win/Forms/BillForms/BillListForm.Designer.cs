namespace UI.Win.Forms.BillForms
{
    partial class BillListForm
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
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridBill).BeginInit();
            SuspendLayout();
            // 
            // gridControl1
            // 
            gridControl1.Dock = DockStyle.Fill;
            gridControl1.Location = new Point(0, 0);
            gridControl1.MainView = gridBill;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(800, 450);
            gridControl1.TabIndex = 0;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridBill });
            // 
            // gridBill
            // 
            gridBill.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridBillId, gridDescription });
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
            // BillListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gridControl1);
            Name = "BillListForm";
            Text = "BillListForm";
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridBill).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridBill;
        private DevExpress.XtraGrid.Columns.GridColumn gridBillId;
        private DevExpress.XtraGrid.Columns.GridColumn gridDescription;
    }
}