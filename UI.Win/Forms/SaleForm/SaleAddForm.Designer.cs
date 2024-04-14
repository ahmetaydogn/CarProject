namespace UI.Win.Forms.SaleForm
{
    partial class SaleAddForm
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
            DevExpress.XtraLayout.RowDefinition rowDefinition5 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition6 = new DevExpress.XtraLayout.RowDefinition();
            myDataLayoutControl1 = new UserControls.MyDataLayoutControl();
            btnBill = new DevExpress.XtraEditors.ButtonEdit();
            cmbPaymentMethod = new DevExpress.XtraEditors.ComboBoxEdit();
            calcPrice = new DevExpress.XtraEditors.CalcEdit();
            spnQuantity = new DevExpress.XtraEditors.SpinEdit();
            btnCustomer = new DevExpress.XtraEditors.ButtonEdit();
            btnProduct = new DevExpress.XtraEditors.ButtonEdit();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)myDataLayoutControl1).BeginInit();
            myDataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnBill.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbPaymentMethod.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)calcPrice.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spnQuantity.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCustomer.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnProduct.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).BeginInit();
            SuspendLayout();
            // 
            // ribbonControl1
            // 
            ribbonControl1.ExpandCollapseItem.Id = 0;
            ribbonControl1.Size = new Size(486, 126);
            ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // myDataLayoutControl1
            // 
            myDataLayoutControl1.Controls.Add(btnBill);
            myDataLayoutControl1.Controls.Add(cmbPaymentMethod);
            myDataLayoutControl1.Controls.Add(calcPrice);
            myDataLayoutControl1.Controls.Add(spnQuantity);
            myDataLayoutControl1.Controls.Add(btnCustomer);
            myDataLayoutControl1.Controls.Add(btnProduct);
            myDataLayoutControl1.Dock = DockStyle.Fill;
            myDataLayoutControl1.Location = new Point(0, 126);
            myDataLayoutControl1.Name = "myDataLayoutControl1";
            myDataLayoutControl1.OptionsFocus.EnableAutoTabOrder = false;
            myDataLayoutControl1.Root = Root;
            myDataLayoutControl1.Size = new Size(486, 172);
            myDataLayoutControl1.TabIndex = 1;
            myDataLayoutControl1.Text = "myDataLayoutControl1";
            // 
            // btnBill
            // 
            btnBill.Location = new Point(97, 132);
            btnBill.MenuManager = ribbonControl1;
            btnBill.Name = "btnBill";
            btnBill.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton() });
            btnBill.Properties.ReadOnly = true;
            btnBill.Size = new Size(151, 22);
            btnBill.StyleController = myDataLayoutControl1;
            btnBill.TabIndex = 10;
            btnBill.ButtonClick += btnBill_ButtonClick;
            // 
            // cmbPaymentMethod
            // 
            cmbPaymentMethod.Location = new Point(97, 108);
            cmbPaymentMethod.MenuManager = ribbonControl1;
            cmbPaymentMethod.Name = "cmbPaymentMethod";
            cmbPaymentMethod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cmbPaymentMethod.Properties.DropDownRows = 4;
            cmbPaymentMethod.Properties.Items.AddRange(new object[] { "Havale", "Nakit", "Kredi Kartı", "Senet", "Çek" });
            cmbPaymentMethod.Size = new Size(151, 22);
            cmbPaymentMethod.StyleController = myDataLayoutControl1;
            cmbPaymentMethod.TabIndex = 8;
            // 
            // calcPrice
            // 
            calcPrice.Location = new Point(97, 84);
            calcPrice.MenuManager = ribbonControl1;
            calcPrice.Name = "calcPrice";
            calcPrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            calcPrice.Size = new Size(151, 22);
            calcPrice.StyleController = myDataLayoutControl1;
            calcPrice.TabIndex = 7;
            // 
            // spnQuantity
            // 
            spnQuantity.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            spnQuantity.Location = new Point(97, 60);
            spnQuantity.MenuManager = ribbonControl1;
            spnQuantity.Name = "spnQuantity";
            spnQuantity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            spnQuantity.Properties.MaskSettings.Set("mask", "d");
            spnQuantity.Size = new Size(151, 24);
            spnQuantity.StyleController = myDataLayoutControl1;
            spnQuantity.TabIndex = 6;
            spnQuantity.ValueChanged += spnQuantity_ValueChanged;
            // 
            // btnCustomer
            // 
            btnCustomer.Location = new Point(97, 36);
            btnCustomer.MenuManager = ribbonControl1;
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton() });
            btnCustomer.Properties.ReadOnly = true;
            btnCustomer.Size = new Size(151, 22);
            btnCustomer.StyleController = myDataLayoutControl1;
            btnCustomer.TabIndex = 5;
            btnCustomer.ButtonClick += btnCustomer_ButtonClick;
            // 
            // btnProduct
            // 
            btnProduct.Location = new Point(97, 12);
            btnProduct.MenuManager = ribbonControl1;
            btnProduct.Name = "btnProduct";
            btnProduct.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton() });
            btnProduct.Properties.ReadOnly = true;
            btnProduct.Size = new Size(151, 22);
            btnProduct.StyleController = myDataLayoutControl1;
            btnProduct.TabIndex = 4;
            btnProduct.ButtonClick += btnProduct_ButtonClick;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, layoutControlItem2, layoutControlItem3, layoutControlItem4, layoutControlItem5, layoutControlItem6 });
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
            rowDefinition4.Height = 24D;
            rowDefinition4.SizeType = SizeType.Absolute;
            rowDefinition5.Height = 24D;
            rowDefinition5.SizeType = SizeType.Absolute;
            rowDefinition6.Height = 24D;
            rowDefinition6.SizeType = SizeType.Absolute;
            Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] { rowDefinition1, rowDefinition2, rowDefinition3, rowDefinition4, rowDefinition5, rowDefinition6 });
            Root.Size = new Size(486, 172);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = btnProduct;
            layoutControlItem1.Location = new Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new Size(240, 24);
            layoutControlItem1.Text = "Ürün";
            layoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            layoutControlItem1.TextSize = new Size(80, 20);
            layoutControlItem1.TextToControlDistance = 5;
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = btnCustomer;
            layoutControlItem2.Location = new Point(0, 24);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.OptionsTableLayoutItem.RowIndex = 1;
            layoutControlItem2.Size = new Size(240, 24);
            layoutControlItem2.Text = "Cari";
            layoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            layoutControlItem2.TextSize = new Size(80, 20);
            layoutControlItem2.TextToControlDistance = 5;
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = spnQuantity;
            layoutControlItem3.Location = new Point(0, 48);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.OptionsTableLayoutItem.RowIndex = 2;
            layoutControlItem3.Size = new Size(240, 24);
            layoutControlItem3.Text = "Miktar";
            layoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            layoutControlItem3.TextSize = new Size(80, 20);
            layoutControlItem3.TextToControlDistance = 5;
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.Control = calcPrice;
            layoutControlItem4.Location = new Point(0, 72);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.OptionsTableLayoutItem.RowIndex = 3;
            layoutControlItem4.Size = new Size(240, 24);
            layoutControlItem4.Text = "Tutar";
            layoutControlItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            layoutControlItem4.TextSize = new Size(80, 20);
            layoutControlItem4.TextToControlDistance = 5;
            // 
            // layoutControlItem5
            // 
            layoutControlItem5.Control = cmbPaymentMethod;
            layoutControlItem5.Location = new Point(0, 96);
            layoutControlItem5.Name = "layoutControlItem5";
            layoutControlItem5.OptionsTableLayoutItem.RowIndex = 4;
            layoutControlItem5.Size = new Size(240, 24);
            layoutControlItem5.Text = "Ödeme Şekli";
            layoutControlItem5.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            layoutControlItem5.TextSize = new Size(80, 20);
            layoutControlItem5.TextToControlDistance = 5;
            // 
            // layoutControlItem6
            // 
            layoutControlItem6.Control = btnBill;
            layoutControlItem6.Location = new Point(0, 120);
            layoutControlItem6.Name = "layoutControlItem6";
            layoutControlItem6.OptionsTableLayoutItem.RowIndex = 5;
            layoutControlItem6.Size = new Size(240, 32);
            layoutControlItem6.Text = "Fatura No";
            layoutControlItem6.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            layoutControlItem6.TextSize = new Size(80, 20);
            layoutControlItem6.TextToControlDistance = 5;
            // 
            // SaleAddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 298);
            Controls.Add(myDataLayoutControl1);
            Name = "SaleAddForm";
            Text = "SaleAddForm";
            Controls.SetChildIndex(ribbonControl1, 0);
            Controls.SetChildIndex(myDataLayoutControl1, 0);
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)myDataLayoutControl1).EndInit();
            myDataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnBill.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbPaymentMethod.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)calcPrice.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)spnQuantity.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCustomer.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnProduct.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private UserControls.MyDataLayoutControl myDataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.ButtonEdit btnCustomer;
        private DevExpress.XtraEditors.ButtonEdit btnProduct;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SpinEdit spnQuantity;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.CalcEdit calcPrice;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.ComboBoxEdit cmbPaymentMethod;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.ButtonEdit btnBill;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}