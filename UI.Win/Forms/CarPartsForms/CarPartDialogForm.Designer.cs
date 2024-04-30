namespace UI.Win.Forms.CarPartsForms
{
    partial class CarPartDialogListForm
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
            gridCarPart = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridSubProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            gridMarketPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            gridSellPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            gridVAT = new DevExpress.XtraGrid.Columns.GridColumn();
            gridVATPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            gridProfit = new DevExpress.XtraGrid.Columns.GridColumn();
            gridSubProductDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridCarPart).BeginInit();
            SuspendLayout();
            // 
            // ribbonControl1
            // 
            ribbonControl1.ExpandCollapseItem.Id = 0;
            ribbonControl1.Size = new Size(800, 126);
            ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // gridControl1
            // 
            gridControl1.Dock = DockStyle.Fill;
            gridControl1.Location = new Point(0, 126);
            gridControl1.MainView = gridCarPart;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(800, 324);
            gridControl1.TabIndex = 1;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridCarPart });
            gridControl1.KeyPress += gridControl1_KeyPress;
            // 
            // gridCarPart
            // 
            gridCarPart.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridSubProductName, gridMarketPrice, gridSellPrice, gridVAT, gridVATPrice, gridProfit, gridSubProductDescription });
            gridCarPart.GridControl = gridControl1;
            gridCarPart.Name = "gridCarPart";
            gridCarPart.OptionsBehavior.Editable = false;
            gridCarPart.DoubleClick += gridCarPart_DoubleClick;
            // 
            // gridSubProductName
            // 
            gridSubProductName.Caption = "Parça  Adı";
            gridSubProductName.FieldName = "SubProductName";
            gridSubProductName.MinWidth = 25;
            gridSubProductName.Name = "gridSubProductName";
            gridSubProductName.Visible = true;
            gridSubProductName.VisibleIndex = 0;
            gridSubProductName.Width = 94;
            // 
            // gridMarketPrice
            // 
            gridMarketPrice.Caption = "Alış Fiyatı";
            gridMarketPrice.FieldName = "MarketPrice";
            gridMarketPrice.MinWidth = 25;
            gridMarketPrice.Name = "gridMarketPrice";
            gridMarketPrice.Visible = true;
            gridMarketPrice.VisibleIndex = 1;
            gridMarketPrice.Width = 94;
            // 
            // gridSellPrice
            // 
            gridSellPrice.Caption = "Satış Fiyatı";
            gridSellPrice.FieldName = "SellPrice";
            gridSellPrice.MinWidth = 25;
            gridSellPrice.Name = "gridSellPrice";
            gridSellPrice.Visible = true;
            gridSellPrice.VisibleIndex = 2;
            gridSellPrice.Width = 94;
            // 
            // gridVAT
            // 
            gridVAT.Caption = "KDV Oranı";
            gridVAT.FieldName = "VAT";
            gridVAT.MinWidth = 25;
            gridVAT.Name = "gridVAT";
            gridVAT.Visible = true;
            gridVAT.VisibleIndex = 3;
            gridVAT.Width = 94;
            // 
            // gridVATPrice
            // 
            gridVATPrice.Caption = "KDV Fiyatı";
            gridVATPrice.FieldName = "VATPrice";
            gridVATPrice.MinWidth = 25;
            gridVATPrice.Name = "gridVATPrice";
            gridVATPrice.Visible = true;
            gridVATPrice.VisibleIndex = 4;
            gridVATPrice.Width = 94;
            // 
            // gridProfit
            // 
            gridProfit.Caption = "Kâr (Birim Başı)";
            gridProfit.FieldName = "Profit";
            gridProfit.MinWidth = 25;
            gridProfit.Name = "gridProfit";
            gridProfit.Visible = true;
            gridProfit.VisibleIndex = 6;
            gridProfit.Width = 94;
            // 
            // gridSubProductDescription
            // 
            gridSubProductDescription.Caption = "Açıklama";
            gridSubProductDescription.FieldName = "SubProductDescription";
            gridSubProductDescription.MinWidth = 25;
            gridSubProductDescription.Name = "gridSubProductDescription";
            gridSubProductDescription.Visible = true;
            gridSubProductDescription.VisibleIndex = 5;
            gridSubProductDescription.Width = 94;
            // 
            // CarPartDialogListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gridControl1);
            Name = "CarPartDialogListForm";
            Text = "Araç Parçası Diyalog Formu";
            Controls.SetChildIndex(ribbonControl1, 0);
            Controls.SetChildIndex(gridControl1, 0);
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridCarPart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridCarPart;
        private DevExpress.XtraGrid.Columns.GridColumn gridSubProductName;
        private DevExpress.XtraGrid.Columns.GridColumn gridMarketPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gridSellPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gridVAT;
        private DevExpress.XtraGrid.Columns.GridColumn gridVATPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gridSubProductDescription;
        private DevExpress.XtraGrid.Columns.GridColumn gridProfit;
    }
}