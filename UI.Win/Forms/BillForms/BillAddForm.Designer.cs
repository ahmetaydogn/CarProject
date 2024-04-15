namespace UI.Win.Forms.BillForms
{
    partial class BillAddForm
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
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition3 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition3 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition4 = new DevExpress.XtraLayout.RowDefinition();
            myDataLayoutControl1 = new UserControls.MyDataLayoutControl();
            txtDescription = new DevExpress.XtraEditors.MemoEdit();
            btnSale = new DevExpress.XtraEditors.ButtonEdit();
            txtBillNumber = new DevExpress.XtraEditors.TextEdit();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)myDataLayoutControl1).BeginInit();
            myDataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtDescription.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnSale.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtBillNumber.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
            SuspendLayout();
            // 
            // ribbonControl1
            // 
            ribbonControl1.ExpandCollapseItem.Id = 0;
            ribbonControl1.Size = new Size(579, 126);
            ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // myDataLayoutControl1
            // 
            myDataLayoutControl1.Controls.Add(txtDescription);
            myDataLayoutControl1.Controls.Add(btnSale);
            myDataLayoutControl1.Controls.Add(txtBillNumber);
            myDataLayoutControl1.Dock = DockStyle.Fill;
            myDataLayoutControl1.Location = new Point(0, 126);
            myDataLayoutControl1.Name = "myDataLayoutControl1";
            myDataLayoutControl1.OptionsFocus.EnableAutoTabOrder = false;
            myDataLayoutControl1.Root = Root;
            myDataLayoutControl1.Size = new Size(579, 234);
            myDataLayoutControl1.TabIndex = 1;
            myDataLayoutControl1.Text = "myDataLayoutControl1";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(117, 84);
            txtDescription.MenuManager = ribbonControl1;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(450, 138);
            txtDescription.StyleController = myDataLayoutControl1;
            txtDescription.TabIndex = 7;
            // 
            // btnSale
            // 
            btnSale.Location = new Point(117, 36);
            btnSale.MenuManager = ribbonControl1;
            btnSale.Name = "btnSale";
            btnSale.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton() });
            btnSale.Properties.ReadOnly = true;
            btnSale.Size = new Size(131, 22);
            btnSale.StyleController = myDataLayoutControl1;
            btnSale.TabIndex = 5;
            btnSale.ButtonClick += btnSale_ButtonClick;
            // 
            // txtBillNumber
            // 
            txtBillNumber.Location = new Point(117, 12);
            txtBillNumber.MenuManager = ribbonControl1;
            txtBillNumber.Name = "txtBillNumber";
            txtBillNumber.Properties.ReadOnly = true;
            txtBillNumber.Size = new Size(131, 22);
            txtBillNumber.StyleController = myDataLayoutControl1;
            txtBillNumber.TabIndex = 4;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, layoutControlItem2, layoutControlItem4 });
            Root.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            Root.Name = "Root";
            columnDefinition1.SizeType = SizeType.Absolute;
            columnDefinition1.Width = 240D;
            columnDefinition2.SizeType = SizeType.Percent;
            columnDefinition2.Width = 100D;
            columnDefinition3.SizeType = SizeType.Absolute;
            columnDefinition3.Width = 120D;
            Root.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] { columnDefinition1, columnDefinition2, columnDefinition3 });
            rowDefinition1.Height = 24D;
            rowDefinition1.SizeType = SizeType.Absolute;
            rowDefinition2.Height = 24D;
            rowDefinition2.SizeType = SizeType.Absolute;
            rowDefinition3.Height = 24D;
            rowDefinition3.SizeType = SizeType.Absolute;
            rowDefinition4.Height = 100D;
            rowDefinition4.SizeType = SizeType.Percent;
            Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] { rowDefinition1, rowDefinition2, rowDefinition3, rowDefinition4 });
            Root.Size = new Size(579, 234);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = txtBillNumber;
            layoutControlItem1.Location = new Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new Size(240, 24);
            layoutControlItem1.Text = "Fatura Numarası";
            layoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            layoutControlItem1.TextSize = new Size(100, 16);
            layoutControlItem1.TextToControlDistance = 5;
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = btnSale;
            layoutControlItem2.Location = new Point(0, 24);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.OptionsTableLayoutItem.RowIndex = 1;
            layoutControlItem2.Size = new Size(240, 24);
            layoutControlItem2.Text = "Yapılan Satış";
            layoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            layoutControlItem2.TextSize = new Size(100, 16);
            layoutControlItem2.TextToControlDistance = 5;
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.Control = txtDescription;
            layoutControlItem4.Location = new Point(0, 72);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.OptionsTableLayoutItem.ColumnSpan = 3;
            layoutControlItem4.OptionsTableLayoutItem.RowIndex = 3;
            layoutControlItem4.Size = new Size(559, 142);
            layoutControlItem4.Text = "Açıklama";
            layoutControlItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            layoutControlItem4.TextSize = new Size(100, 16);
            layoutControlItem4.TextToControlDistance = 5;
            // 
            // BillAddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 360);
            Controls.Add(myDataLayoutControl1);
            Name = "BillAddForm";
            Text = "BillAddForm";
            Controls.SetChildIndex(ribbonControl1, 0);
            Controls.SetChildIndex(myDataLayoutControl1, 0);
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)myDataLayoutControl1).EndInit();
            myDataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtDescription.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnSale.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtBillNumber.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private UserControls.MyDataLayoutControl myDataLayoutControl1;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
        private DevExpress.XtraEditors.ButtonEdit btnSale;
        private DevExpress.XtraEditors.TextEdit txtBillNumber;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}