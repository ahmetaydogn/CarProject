namespace UI.Win.Forms.CarPartsForms
{
    partial class CarPartsAddForm
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
            DevExpress.XtraLayout.RowDefinition rowDefinition7 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition8 = new DevExpress.XtraLayout.RowDefinition();
            myDataLayoutControl1 = new UserControls.MyDataLayoutControl();
            calcVATPrice = new DevExpress.XtraEditors.CalcEdit();
            txtProfit = new DevExpress.XtraEditors.TextEdit();
            txtDescription = new DevExpress.XtraEditors.MemoEdit();
            cmbVAT = new DevExpress.XtraEditors.ComboBoxEdit();
            spnSellPrice = new DevExpress.XtraEditors.SpinEdit();
            spnMarketPrice = new DevExpress.XtraEditors.SpinEdit();
            txtSubProductName = new DevExpress.XtraEditors.TextEdit();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)myDataLayoutControl1).BeginInit();
            myDataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)calcVATPrice.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtProfit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtDescription.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbVAT.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spnSellPrice.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spnMarketPrice.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSubProductName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
            SuspendLayout();
            // 
            // ribbonControl1
            // 
            ribbonControl1.ExpandCollapseItem.Id = 0;
            ribbonControl1.Size = new Size(800, 126);
            ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // myDataLayoutControl1
            // 
            myDataLayoutControl1.Controls.Add(calcVATPrice);
            myDataLayoutControl1.Controls.Add(txtProfit);
            myDataLayoutControl1.Controls.Add(txtDescription);
            myDataLayoutControl1.Controls.Add(cmbVAT);
            myDataLayoutControl1.Controls.Add(spnSellPrice);
            myDataLayoutControl1.Controls.Add(spnMarketPrice);
            myDataLayoutControl1.Controls.Add(txtSubProductName);
            myDataLayoutControl1.Dock = DockStyle.Fill;
            myDataLayoutControl1.Location = new Point(0, 126);
            myDataLayoutControl1.Name = "myDataLayoutControl1";
            myDataLayoutControl1.OptionsFocus.EnableAutoTabOrder = false;
            myDataLayoutControl1.Root = Root;
            myDataLayoutControl1.Size = new Size(800, 324);
            myDataLayoutControl1.TabIndex = 2;
            myDataLayoutControl1.Text = "myDataLayoutControl1";
            // 
            // calcVATPrice
            // 
            calcVATPrice.Location = new Point(97, 108);
            calcVATPrice.MenuManager = ribbonControl1;
            calcVATPrice.Name = "calcVATPrice";
            calcVATPrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            calcVATPrice.Properties.ReadOnly = true;
            calcVATPrice.Size = new Size(151, 22);
            calcVATPrice.StyleController = myDataLayoutControl1;
            calcVATPrice.TabIndex = 12;
            // 
            // txtProfit
            // 
            txtProfit.Location = new Point(97, 156);
            txtProfit.MenuManager = ribbonControl1;
            txtProfit.Name = "txtProfit";
            txtProfit.Properties.ReadOnly = true;
            txtProfit.Size = new Size(151, 22);
            txtProfit.StyleController = myDataLayoutControl1;
            txtProfit.TabIndex = 11;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(97, 180);
            txtDescription.MenuManager = ribbonControl1;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(691, 132);
            txtDescription.StyleController = myDataLayoutControl1;
            txtDescription.TabIndex = 10;
            // 
            // cmbVAT
            // 
            cmbVAT.Location = new Point(97, 84);
            cmbVAT.MenuManager = ribbonControl1;
            cmbVAT.Name = "cmbVAT";
            cmbVAT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cmbVAT.Properties.Items.AddRange(new object[] { "10", "20" });
            cmbVAT.Size = new Size(151, 22);
            cmbVAT.StyleController = myDataLayoutControl1;
            cmbVAT.TabIndex = 8;
            cmbVAT.EditValueChanged += cmbVAT_EditValueChanged;
            // 
            // spnSellPrice
            // 
            spnSellPrice.EditValue = new decimal(new int[] { 1, 0, 0, 0 });
            spnSellPrice.Location = new Point(97, 60);
            spnSellPrice.MenuManager = ribbonControl1;
            spnSellPrice.Name = "spnSellPrice";
            spnSellPrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            spnSellPrice.Properties.MaxValue = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            spnSellPrice.Properties.MinValue = new decimal(new int[] { 1, 0, 0, 0 });
            spnSellPrice.Size = new Size(151, 24);
            spnSellPrice.StyleController = myDataLayoutControl1;
            spnSellPrice.TabIndex = 6;
            spnSellPrice.EditValueChanged += spnSellPrice_EditValueChanged;
            // 
            // spnMarketPrice
            // 
            spnMarketPrice.EditValue = new decimal(new int[] { 1, 0, 0, 0 });
            spnMarketPrice.Location = new Point(97, 36);
            spnMarketPrice.MenuManager = ribbonControl1;
            spnMarketPrice.Name = "spnMarketPrice";
            spnMarketPrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            spnMarketPrice.Properties.MaxValue = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            spnMarketPrice.Properties.MinValue = new decimal(new int[] { 1, 0, 0, 0 });
            spnMarketPrice.Size = new Size(151, 24);
            spnMarketPrice.StyleController = myDataLayoutControl1;
            spnMarketPrice.TabIndex = 5;
            spnMarketPrice.EditValueChanged += spnMarketPrice_EditValueChanged;
            // 
            // txtSubProductName
            // 
            txtSubProductName.Location = new Point(97, 12);
            txtSubProductName.MenuManager = ribbonControl1;
            txtSubProductName.Name = "txtSubProductName";
            txtSubProductName.Size = new Size(151, 22);
            txtSubProductName.StyleController = myDataLayoutControl1;
            txtSubProductName.TabIndex = 4;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, layoutControlItem2, layoutControlItem3, layoutControlItem5, layoutControlItem7, layoutControlItem8, layoutControlItem4 });
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
            rowDefinition7.Height = 24D;
            rowDefinition7.SizeType = SizeType.Absolute;
            rowDefinition8.Height = 100D;
            rowDefinition8.SizeType = SizeType.Percent;
            Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] { rowDefinition1, rowDefinition2, rowDefinition3, rowDefinition4, rowDefinition5, rowDefinition6, rowDefinition7, rowDefinition8 });
            Root.Size = new Size(800, 324);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = txtSubProductName;
            layoutControlItem1.Location = new Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new Size(240, 24);
            layoutControlItem1.Text = "Parça Adı";
            layoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            layoutControlItem1.TextSize = new Size(80, 20);
            layoutControlItem1.TextToControlDistance = 5;
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = spnMarketPrice;
            layoutControlItem2.Location = new Point(0, 24);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.OptionsTableLayoutItem.RowIndex = 1;
            layoutControlItem2.Size = new Size(240, 24);
            layoutControlItem2.Text = "Alış Fiyatı";
            layoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            layoutControlItem2.TextSize = new Size(80, 20);
            layoutControlItem2.TextToControlDistance = 5;
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = spnSellPrice;
            layoutControlItem3.Location = new Point(0, 48);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.OptionsTableLayoutItem.RowIndex = 2;
            layoutControlItem3.Size = new Size(240, 24);
            layoutControlItem3.Text = "Satış Fiyatı";
            layoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            layoutControlItem3.TextSize = new Size(80, 20);
            layoutControlItem3.TextToControlDistance = 5;
            // 
            // layoutControlItem5
            // 
            layoutControlItem5.Control = cmbVAT;
            layoutControlItem5.Location = new Point(0, 72);
            layoutControlItem5.Name = "layoutControlItem5";
            layoutControlItem5.OptionsTableLayoutItem.RowIndex = 3;
            layoutControlItem5.Size = new Size(240, 24);
            layoutControlItem5.Text = "KDV Oranı";
            layoutControlItem5.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            layoutControlItem5.TextSize = new Size(80, 20);
            layoutControlItem5.TextToControlDistance = 5;
            // 
            // layoutControlItem7
            // 
            layoutControlItem7.Control = txtDescription;
            layoutControlItem7.Location = new Point(0, 168);
            layoutControlItem7.Name = "layoutControlItem7";
            layoutControlItem7.OptionsTableLayoutItem.ColumnSpan = 3;
            layoutControlItem7.OptionsTableLayoutItem.RowIndex = 7;
            layoutControlItem7.Size = new Size(780, 136);
            layoutControlItem7.Text = "Açıklama";
            layoutControlItem7.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            layoutControlItem7.TextSize = new Size(80, 20);
            layoutControlItem7.TextToControlDistance = 5;
            // 
            // layoutControlItem8
            // 
            layoutControlItem8.AppearanceItemCaption.FontStyleDelta = FontStyle.Bold;
            layoutControlItem8.AppearanceItemCaption.ForeColor = Color.Maroon;
            layoutControlItem8.AppearanceItemCaption.Options.UseFont = true;
            layoutControlItem8.AppearanceItemCaption.Options.UseForeColor = true;
            layoutControlItem8.Control = txtProfit;
            layoutControlItem8.Location = new Point(0, 144);
            layoutControlItem8.Name = "layoutControlItem8";
            layoutControlItem8.OptionsTableLayoutItem.RowIndex = 6;
            layoutControlItem8.Size = new Size(240, 24);
            layoutControlItem8.Text = "Kar";
            layoutControlItem8.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            layoutControlItem8.TextSize = new Size(80, 20);
            layoutControlItem8.TextToControlDistance = 5;
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.Control = calcVATPrice;
            layoutControlItem4.Location = new Point(0, 96);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.OptionsTableLayoutItem.RowIndex = 4;
            layoutControlItem4.Size = new Size(240, 24);
            layoutControlItem4.Text = "KDV Tutarı";
            layoutControlItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            layoutControlItem4.TextSize = new Size(80, 20);
            layoutControlItem4.TextToControlDistance = 5;
            // 
            // CarPartsAddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(myDataLayoutControl1);
            Name = "CarPartsAddForm";
            Text = "Araç Parçası Ekleme Formu";
            Controls.SetChildIndex(ribbonControl1, 0);
            Controls.SetChildIndex(myDataLayoutControl1, 0);
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)myDataLayoutControl1).EndInit();
            myDataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)calcVATPrice.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtProfit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtDescription.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbVAT.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)spnSellPrice.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)spnMarketPrice.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSubProductName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem7).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem8).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private UserControls.MyDataLayoutControl myDataLayoutControl1;
        private DevExpress.XtraEditors.TextEdit txtProfit;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
        private DevExpress.XtraEditors.ComboBoxEdit cmbVAT;
        private DevExpress.XtraEditors.SpinEdit spnSellPrice;
        private DevExpress.XtraEditors.SpinEdit spnMarketPrice;
        private DevExpress.XtraEditors.TextEdit txtSubProductName;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraEditors.CalcEdit calcVATPrice;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}