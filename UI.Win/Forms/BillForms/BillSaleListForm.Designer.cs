namespace UI.Win.Forms.BillForms
{
    partial class BillSaleListForm
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
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition3 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition4 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition5 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition6 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition7 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition8 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition9 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition10 = new DevExpress.XtraLayout.RowDefinition();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridBillSale = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridBillId = new DevExpress.XtraGrid.Columns.GridColumn();
            gridSaleCustomerFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            gridSaleCustomerPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            gridSaleProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            gridQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            gridSellPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            gridSumPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            gridProfit = new DevExpress.XtraGrid.Columns.GridColumn();
            gridPaymentMethod = new DevExpress.XtraGrid.Columns.GridColumn();
            gridSaleDate = new DevExpress.XtraGrid.Columns.GridColumn();
            myDataLayoutControl1 = new UserControls.MyDataLayoutControl();
            dateBillDate = new DevExpress.XtraEditors.DateEdit();
            txtAllProfit = new DevExpress.XtraEditors.TextEdit();
            txtDescription = new DevExpress.XtraEditors.MemoEdit();
            txtAllTAX = new DevExpress.XtraEditors.TextEdit();
            txtExciseTaxPrice = new DevExpress.XtraEditors.TextEdit();
            txtAllVATPrice = new DevExpress.XtraEditors.TextEdit();
            txtAllSellPrice = new DevExpress.XtraEditors.TextEdit();
            txtAllMarketPrice = new DevExpress.XtraEditors.TextEdit();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridBillSale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)myDataLayoutControl1).BeginInit();
            myDataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dateBillDate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateBillDate.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtAllProfit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtDescription.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtAllTAX.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtExciseTaxPrice.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtAllVATPrice.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtAllSellPrice.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtAllMarketPrice.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem8).BeginInit();
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
            gridControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridControl1.Location = new Point(0, 126);
            gridControl1.MainView = gridBillSale;
            gridControl1.MenuManager = ribbonControl1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(885, 577);
            gridControl1.TabIndex = 1;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridBillSale });
            // 
            // gridBillSale
            // 
            gridBillSale.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridBillId, gridSaleCustomerFullName, gridSaleCustomerPhone, gridSaleProductName, gridQuantity, gridSellPrice, gridSumPrice, gridProfit, gridPaymentMethod, gridSaleDate });
            gridBillSale.GridControl = gridControl1;
            gridBillSale.Name = "gridBillSale";
            gridBillSale.OptionsBehavior.Editable = false;
            gridBillSale.DoubleClick += gridBillSale_DoubleClick;
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
            // gridSaleCustomerFullName
            // 
            gridSaleCustomerFullName.Caption = "Cari Adı Soyadı";
            gridSaleCustomerFullName.FieldName = "SaleCustomerFullName";
            gridSaleCustomerFullName.MinWidth = 25;
            gridSaleCustomerFullName.Name = "gridSaleCustomerFullName";
            gridSaleCustomerFullName.Visible = true;
            gridSaleCustomerFullName.VisibleIndex = 1;
            gridSaleCustomerFullName.Width = 94;
            // 
            // gridSaleCustomerPhone
            // 
            gridSaleCustomerPhone.Caption = "Cari Telefon No";
            gridSaleCustomerPhone.FieldName = "SaleCustomerPhone";
            gridSaleCustomerPhone.MinWidth = 25;
            gridSaleCustomerPhone.Name = "gridSaleCustomerPhone";
            gridSaleCustomerPhone.Visible = true;
            gridSaleCustomerPhone.VisibleIndex = 2;
            gridSaleCustomerPhone.Width = 94;
            // 
            // gridSaleProductName
            // 
            gridSaleProductName.Caption = "Ürün Adı";
            gridSaleProductName.FieldName = "SaleProductName";
            gridSaleProductName.MinWidth = 25;
            gridSaleProductName.Name = "gridSaleProductName";
            gridSaleProductName.Visible = true;
            gridSaleProductName.VisibleIndex = 3;
            gridSaleProductName.Width = 94;
            // 
            // gridQuantity
            // 
            gridQuantity.Caption = "Miktar";
            gridQuantity.FieldName = "Quantity";
            gridQuantity.MinWidth = 25;
            gridQuantity.Name = "gridQuantity";
            gridQuantity.Visible = true;
            gridQuantity.VisibleIndex = 4;
            gridQuantity.Width = 94;
            // 
            // gridSellPrice
            // 
            gridSellPrice.Caption = "Ürün Fiyatı";
            gridSellPrice.FieldName = "SellPrice";
            gridSellPrice.MinWidth = 25;
            gridSellPrice.Name = "gridSellPrice";
            gridSellPrice.Visible = true;
            gridSellPrice.VisibleIndex = 5;
            gridSellPrice.Width = 94;
            // 
            // gridSumPrice
            // 
            gridSumPrice.Caption = "Toplam Tutar";
            gridSumPrice.FieldName = "SumPrice";
            gridSumPrice.MinWidth = 25;
            gridSumPrice.Name = "gridSumPrice";
            gridSumPrice.Visible = true;
            gridSumPrice.VisibleIndex = 6;
            gridSumPrice.Width = 94;
            // 
            // gridProfit
            // 
            gridProfit.Caption = "Kâr (Birim Başı)";
            gridProfit.FieldName = "Profit";
            gridProfit.MinWidth = 25;
            gridProfit.Name = "gridProfit";
            gridProfit.Visible = true;
            gridProfit.VisibleIndex = 9;
            gridProfit.Width = 94;
            // 
            // gridPaymentMethod
            // 
            gridPaymentMethod.Caption = "Ödeme Şekli";
            gridPaymentMethod.FieldName = "PaymentMethod";
            gridPaymentMethod.MinWidth = 25;
            gridPaymentMethod.Name = "gridPaymentMethod";
            gridPaymentMethod.Visible = true;
            gridPaymentMethod.VisibleIndex = 7;
            gridPaymentMethod.Width = 94;
            // 
            // gridSaleDate
            // 
            gridSaleDate.Caption = "Satış Tarihi";
            gridSaleDate.FieldName = "SaleDate";
            gridSaleDate.MinWidth = 25;
            gridSaleDate.Name = "gridSaleDate";
            gridSaleDate.Visible = true;
            gridSaleDate.VisibleIndex = 8;
            gridSaleDate.Width = 94;
            // 
            // myDataLayoutControl1
            // 
            myDataLayoutControl1.AutoSizeMode = AutoSizeMode.GrowOnly;
            myDataLayoutControl1.Controls.Add(dateBillDate);
            myDataLayoutControl1.Controls.Add(txtAllProfit);
            myDataLayoutControl1.Controls.Add(txtDescription);
            myDataLayoutControl1.Controls.Add(txtAllTAX);
            myDataLayoutControl1.Controls.Add(txtExciseTaxPrice);
            myDataLayoutControl1.Controls.Add(txtAllVATPrice);
            myDataLayoutControl1.Controls.Add(txtAllSellPrice);
            myDataLayoutControl1.Controls.Add(txtAllMarketPrice);
            myDataLayoutControl1.Dock = DockStyle.Right;
            myDataLayoutControl1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem8 });
            myDataLayoutControl1.Location = new Point(891, 126);
            myDataLayoutControl1.Name = "myDataLayoutControl1";
            myDataLayoutControl1.OptionsFocus.EnableAutoTabOrder = false;
            myDataLayoutControl1.Root = Root;
            myDataLayoutControl1.Size = new Size(341, 577);
            myDataLayoutControl1.TabIndex = 2;
            myDataLayoutControl1.Text = "myDataLayoutControl1";
            // 
            // dateBillDate
            // 
            dateBillDate.EditValue = null;
            dateBillDate.Location = new Point(142, 228);
            dateBillDate.MenuManager = ribbonControl1;
            dateBillDate.Name = "dateBillDate";
            dateBillDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateBillDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateBillDate.Properties.ReadOnly = true;
            dateBillDate.Size = new Size(187, 22);
            dateBillDate.StyleController = myDataLayoutControl1;
            dateBillDate.TabIndex = 11;
            // 
            // txtAllProfit
            // 
            txtAllProfit.Location = new Point(142, 180);
            txtAllProfit.MenuManager = ribbonControl1;
            txtAllProfit.Name = "txtAllProfit";
            txtAllProfit.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            txtAllProfit.Properties.MaskSettings.Set("mask", "c");
            txtAllProfit.Properties.ReadOnly = true;
            txtAllProfit.Properties.UseMaskAsDisplayFormat = true;
            txtAllProfit.Size = new Size(187, 22);
            txtAllProfit.StyleController = myDataLayoutControl1;
            txtAllProfit.TabIndex = 10;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(142, 228);
            txtDescription.MenuManager = ribbonControl1;
            txtDescription.Name = "txtDescription";
            txtDescription.Properties.ReadOnly = true;
            txtDescription.Size = new Size(187, 337);
            txtDescription.StyleController = myDataLayoutControl1;
            txtDescription.TabIndex = 9;
            // 
            // txtAllTAX
            // 
            txtAllTAX.Location = new Point(142, 132);
            txtAllTAX.MenuManager = ribbonControl1;
            txtAllTAX.Name = "txtAllTAX";
            txtAllTAX.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            txtAllTAX.Properties.MaskSettings.Set("mask", "c");
            txtAllTAX.Properties.ReadOnly = true;
            txtAllTAX.Properties.UseMaskAsDisplayFormat = true;
            txtAllTAX.Size = new Size(187, 22);
            txtAllTAX.StyleController = myDataLayoutControl1;
            txtAllTAX.TabIndex = 8;
            // 
            // txtExciseTaxPrice
            // 
            txtExciseTaxPrice.Location = new Point(142, 108);
            txtExciseTaxPrice.MenuManager = ribbonControl1;
            txtExciseTaxPrice.Name = "txtExciseTaxPrice";
            txtExciseTaxPrice.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            txtExciseTaxPrice.Properties.MaskSettings.Set("mask", "c");
            txtExciseTaxPrice.Properties.ReadOnly = true;
            txtExciseTaxPrice.Properties.UseMaskAsDisplayFormat = true;
            txtExciseTaxPrice.Size = new Size(187, 22);
            txtExciseTaxPrice.StyleController = myDataLayoutControl1;
            txtExciseTaxPrice.TabIndex = 7;
            // 
            // txtAllVATPrice
            // 
            txtAllVATPrice.Location = new Point(142, 84);
            txtAllVATPrice.MenuManager = ribbonControl1;
            txtAllVATPrice.Name = "txtAllVATPrice";
            txtAllVATPrice.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            txtAllVATPrice.Properties.MaskSettings.Set("mask", "c");
            txtAllVATPrice.Properties.ReadOnly = true;
            txtAllVATPrice.Properties.UseMaskAsDisplayFormat = true;
            txtAllVATPrice.Size = new Size(187, 22);
            txtAllVATPrice.StyleController = myDataLayoutControl1;
            txtAllVATPrice.TabIndex = 6;
            // 
            // txtAllSellPrice
            // 
            txtAllSellPrice.Location = new Point(142, 60);
            txtAllSellPrice.MenuManager = ribbonControl1;
            txtAllSellPrice.Name = "txtAllSellPrice";
            txtAllSellPrice.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            txtAllSellPrice.Properties.MaskSettings.Set("mask", "c");
            txtAllSellPrice.Properties.ReadOnly = true;
            txtAllSellPrice.Properties.UseMaskAsDisplayFormat = true;
            txtAllSellPrice.Size = new Size(187, 22);
            txtAllSellPrice.StyleController = myDataLayoutControl1;
            txtAllSellPrice.TabIndex = 5;
            // 
            // txtAllMarketPrice
            // 
            txtAllMarketPrice.Location = new Point(142, 36);
            txtAllMarketPrice.MenuManager = ribbonControl1;
            txtAllMarketPrice.Name = "txtAllMarketPrice";
            txtAllMarketPrice.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            txtAllMarketPrice.Properties.MaskSettings.Set("mask", "c");
            txtAllMarketPrice.Properties.ReadOnly = true;
            txtAllMarketPrice.Properties.UseMaskAsDisplayFormat = true;
            txtAllMarketPrice.Size = new Size(187, 22);
            txtAllMarketPrice.StyleController = myDataLayoutControl1;
            txtAllMarketPrice.TabIndex = 4;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, layoutControlItem2, layoutControlItem3, layoutControlItem4, layoutControlItem5, layoutControlItem6, layoutControlItem7 });
            Root.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            Root.Name = "Root";
            columnDefinition1.SizeType = SizeType.Percent;
            columnDefinition1.Width = 100D;
            Root.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] { columnDefinition1 });
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
            rowDefinition8.Height = 24D;
            rowDefinition8.SizeType = SizeType.Absolute;
            rowDefinition9.Height = 24D;
            rowDefinition9.SizeType = SizeType.Absolute;
            rowDefinition10.Height = 100D;
            rowDefinition10.SizeType = SizeType.Percent;
            Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] { rowDefinition1, rowDefinition2, rowDefinition3, rowDefinition4, rowDefinition5, rowDefinition6, rowDefinition7, rowDefinition8, rowDefinition9, rowDefinition10 });
            Root.Size = new Size(341, 577);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.AppearanceItemCaption.FontStyleDelta = FontStyle.Bold;
            layoutControlItem1.AppearanceItemCaption.ForeColor = Color.Maroon;
            layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            layoutControlItem1.Control = txtAllMarketPrice;
            layoutControlItem1.Location = new Point(0, 24);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.OptionsTableLayoutItem.RowIndex = 1;
            layoutControlItem1.Size = new Size(321, 24);
            layoutControlItem1.Text = "Toplam Maliyet";
            layoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            layoutControlItem1.TextSize = new Size(125, 20);
            layoutControlItem1.TextToControlDistance = 5;
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.AppearanceItemCaption.FontStyleDelta = FontStyle.Bold;
            layoutControlItem2.AppearanceItemCaption.ForeColor = Color.Maroon;
            layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            layoutControlItem2.Control = txtAllSellPrice;
            layoutControlItem2.Location = new Point(0, 48);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.OptionsTableLayoutItem.RowIndex = 2;
            layoutControlItem2.Size = new Size(321, 24);
            layoutControlItem2.Text = "Toplam Satış Fiyatı";
            layoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            layoutControlItem2.TextSize = new Size(125, 20);
            layoutControlItem2.TextToControlDistance = 5;
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.AppearanceItemCaption.FontStyleDelta = FontStyle.Bold;
            layoutControlItem3.AppearanceItemCaption.ForeColor = Color.Maroon;
            layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
            layoutControlItem3.AppearanceItemCaption.Options.UseForeColor = true;
            layoutControlItem3.Control = txtAllVATPrice;
            layoutControlItem3.Location = new Point(0, 72);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.OptionsTableLayoutItem.RowIndex = 3;
            layoutControlItem3.Size = new Size(321, 24);
            layoutControlItem3.Text = "Toplam KDV Vergisi";
            layoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            layoutControlItem3.TextSize = new Size(125, 20);
            layoutControlItem3.TextToControlDistance = 5;
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.AppearanceItemCaption.FontStyleDelta = FontStyle.Bold;
            layoutControlItem4.AppearanceItemCaption.ForeColor = Color.Maroon;
            layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
            layoutControlItem4.AppearanceItemCaption.Options.UseForeColor = true;
            layoutControlItem4.Control = txtExciseTaxPrice;
            layoutControlItem4.Location = new Point(0, 96);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.OptionsTableLayoutItem.RowIndex = 4;
            layoutControlItem4.Size = new Size(321, 24);
            layoutControlItem4.Text = "Toplam Diğer Vergiler";
            layoutControlItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            layoutControlItem4.TextSize = new Size(125, 20);
            layoutControlItem4.TextToControlDistance = 5;
            // 
            // layoutControlItem5
            // 
            layoutControlItem5.AppearanceItemCaption.FontStyleDelta = FontStyle.Bold;
            layoutControlItem5.AppearanceItemCaption.ForeColor = Color.Maroon;
            layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
            layoutControlItem5.AppearanceItemCaption.Options.UseForeColor = true;
            layoutControlItem5.Control = txtAllTAX;
            layoutControlItem5.Location = new Point(0, 120);
            layoutControlItem5.Name = "layoutControlItem5";
            layoutControlItem5.OptionsTableLayoutItem.RowIndex = 5;
            layoutControlItem5.Size = new Size(321, 24);
            layoutControlItem5.Text = "Toplam Vergi";
            layoutControlItem5.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            layoutControlItem5.TextSize = new Size(125, 20);
            layoutControlItem5.TextToControlDistance = 5;
            // 
            // layoutControlItem6
            // 
            layoutControlItem6.AppearanceItemCaption.FontStyleDelta = FontStyle.Bold;
            layoutControlItem6.AppearanceItemCaption.ForeColor = Color.Maroon;
            layoutControlItem6.AppearanceItemCaption.Options.UseFont = true;
            layoutControlItem6.AppearanceItemCaption.Options.UseForeColor = true;
            layoutControlItem6.Control = txtDescription;
            layoutControlItem6.Location = new Point(0, 216);
            layoutControlItem6.Name = "layoutControlItem6";
            layoutControlItem6.OptionsTableLayoutItem.RowIndex = 9;
            layoutControlItem6.Size = new Size(321, 341);
            layoutControlItem6.Text = "Açıklama";
            layoutControlItem6.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            layoutControlItem6.TextSize = new Size(125, 20);
            layoutControlItem6.TextToControlDistance = 5;
            // 
            // layoutControlItem7
            // 
            layoutControlItem7.AppearanceItemCaption.FontStyleDelta = FontStyle.Bold;
            layoutControlItem7.AppearanceItemCaption.ForeColor = Color.Maroon;
            layoutControlItem7.AppearanceItemCaption.Options.UseFont = true;
            layoutControlItem7.AppearanceItemCaption.Options.UseForeColor = true;
            layoutControlItem7.Control = txtAllProfit;
            layoutControlItem7.Location = new Point(0, 168);
            layoutControlItem7.Name = "layoutControlItem7";
            layoutControlItem7.OptionsTableLayoutItem.RowIndex = 7;
            layoutControlItem7.Size = new Size(321, 24);
            layoutControlItem7.Text = "Toplam Kazanç";
            layoutControlItem7.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            layoutControlItem7.TextSize = new Size(125, 20);
            layoutControlItem7.TextToControlDistance = 5;
            // 
            // layoutControlItem8
            // 
            layoutControlItem8.AppearanceItemCaption.FontStyleDelta = FontStyle.Bold;
            layoutControlItem8.AppearanceItemCaption.ForeColor = Color.Maroon;
            layoutControlItem8.AppearanceItemCaption.Options.UseFont = true;
            layoutControlItem8.AppearanceItemCaption.Options.UseForeColor = true;
            layoutControlItem8.Control = dateBillDate;
            layoutControlItem8.Location = new Point(0, 216);
            layoutControlItem8.Name = "layoutControlItem8";
            layoutControlItem8.OptionsTableLayoutItem.RowIndex = 9;
            layoutControlItem8.Size = new Size(321, 341);
            layoutControlItem8.Text = "Fatura Tarihi";
            layoutControlItem8.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            layoutControlItem8.TextSize = new Size(125, 20);
            layoutControlItem8.TextToControlDistance = 5;
            // 
            // BillSaleListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 703);
            Controls.Add(myDataLayoutControl1);
            Controls.Add(gridControl1);
            Name = "BillSaleListForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BillSaleListForm";
            Controls.SetChildIndex(ribbonControl1, 0);
            Controls.SetChildIndex(gridControl1, 0);
            Controls.SetChildIndex(myDataLayoutControl1, 0);
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridBillSale).EndInit();
            ((System.ComponentModel.ISupportInitialize)myDataLayoutControl1).EndInit();
            myDataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dateBillDate.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateBillDate.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtAllProfit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtDescription.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtAllTAX.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtExciseTaxPrice.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtAllVATPrice.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtAllSellPrice.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtAllMarketPrice.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem7).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem8).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridBillSale;
        private UserControls.MyDataLayoutControl myDataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.Columns.GridColumn gridBillId;
        private DevExpress.XtraGrid.Columns.GridColumn gridSaleCustomerFullName;
        private DevExpress.XtraGrid.Columns.GridColumn gridSaleCustomerPhone;
        private DevExpress.XtraGrid.Columns.GridColumn gridSaleProductName;
        private DevExpress.XtraGrid.Columns.GridColumn gridQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn gridSellPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gridSumPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gridPaymentMethod;
        private DevExpress.XtraGrid.Columns.GridColumn gridSaleDate;
        private DevExpress.XtraEditors.DateEdit dateBillDate;
        private DevExpress.XtraEditors.TextEdit txtAllProfit;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
        private DevExpress.XtraEditors.TextEdit txtAllTAX;
        private DevExpress.XtraEditors.TextEdit txtExciseTaxPrice;
        private DevExpress.XtraEditors.TextEdit txtAllVATPrice;
        private DevExpress.XtraEditors.TextEdit txtAllSellPrice;
        private DevExpress.XtraEditors.TextEdit txtAllMarketPrice;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraGrid.Columns.GridColumn gridProfit;
    }
}