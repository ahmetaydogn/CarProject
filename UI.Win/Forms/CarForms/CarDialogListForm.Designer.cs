﻿namespace UI.Win.Forms.CarForms
{
    partial class CarDialogListForm
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
            gridProduct = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            gridProductModel = new DevExpress.XtraGrid.Columns.GridColumn();
            gridProductKM = new DevExpress.XtraGrid.Columns.GridColumn();
            gridProductColor = new DevExpress.XtraGrid.Columns.GridColumn();
            gridProductSituation = new DevExpress.XtraGrid.Columns.GridColumn();
            gridMarketPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            gridSellPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridProduct).BeginInit();
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
            gridControl1.MainView = gridProduct;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(1232, 577);
            gridControl1.TabIndex = 1;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridProduct });
            gridControl1.KeyPress += gridControl1_KeyPress_1;
            // 
            // gridProduct
            // 
            gridProduct.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridProductName, gridProductModel, gridProductKM, gridProductColor, gridProductSituation, gridMarketPrice, gridSellPrice });
            gridProduct.GridControl = gridControl1;
            gridProduct.Name = "gridProduct";
            gridProduct.OptionsBehavior.Editable = false;
            gridProduct.DoubleClick += gridProduct_DoubleClick;
            // 
            // gridProductName
            // 
            gridProductName.Caption = "Araç Adı";
            gridProductName.FieldName = "ProductName";
            gridProductName.MinWidth = 25;
            gridProductName.Name = "gridProductName";
            gridProductName.Visible = true;
            gridProductName.VisibleIndex = 0;
            gridProductName.Width = 220;
            // 
            // gridProductModel
            // 
            gridProductModel.Caption = "Model";
            gridProductModel.FieldName = "ProductModel";
            gridProductModel.MinWidth = 25;
            gridProductModel.Name = "gridProductModel";
            gridProductModel.Visible = true;
            gridProductModel.VisibleIndex = 1;
            gridProductModel.Width = 120;
            // 
            // gridProductKM
            // 
            gridProductKM.Caption = "KM";
            gridProductKM.FieldName = "ProductKM";
            gridProductKM.MinWidth = 25;
            gridProductKM.Name = "gridProductKM";
            gridProductKM.Visible = true;
            gridProductKM.VisibleIndex = 2;
            gridProductKM.Width = 100;
            // 
            // gridProductColor
            // 
            gridProductColor.Caption = "Renk";
            gridProductColor.FieldName = "ProductColor";
            gridProductColor.MinWidth = 25;
            gridProductColor.Name = "gridProductColor";
            gridProductColor.Visible = true;
            gridProductColor.VisibleIndex = 3;
            gridProductColor.Width = 100;
            // 
            // gridProductSituation
            // 
            gridProductSituation.Caption = "Durum";
            gridProductSituation.FieldName = "ProductSituation";
            gridProductSituation.MinWidth = 25;
            gridProductSituation.Name = "gridProductSituation";
            gridProductSituation.Visible = true;
            gridProductSituation.VisibleIndex = 4;
            gridProductSituation.Width = 150;
            // 
            // gridMarketPrice
            // 
            gridMarketPrice.Caption = "Fiyat (KDV Hariç)";
            gridMarketPrice.DisplayFormat.FormatString = "#.00 TL";
            gridMarketPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridMarketPrice.FieldName = "MarketPrice";
            gridMarketPrice.MinWidth = 25;
            gridMarketPrice.Name = "gridMarketPrice";
            gridMarketPrice.Visible = true;
            gridMarketPrice.VisibleIndex = 5;
            gridMarketPrice.Width = 150;
            // 
            // gridSellPrice
            // 
            gridSellPrice.Caption = "Fiyat (KDV Dahil)";
            gridSellPrice.FieldName = "SellPrice";
            gridSellPrice.MinWidth = 25;
            gridSellPrice.Name = "gridSellPrice";
            gridSellPrice.Visible = true;
            gridSellPrice.VisibleIndex = 6;
            gridSellPrice.Width = 150;
            // 
            // CarDialogListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 703);
            Controls.Add(gridControl1);
            Name = "CarDialogListForm";
            Text = "CarDialogListForm";
            Controls.SetChildIndex(ribbonControl1, 0);
            Controls.SetChildIndex(gridControl1, 0);
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridProduct;
        private DevExpress.XtraGrid.Columns.GridColumn gridProductName;
        private DevExpress.XtraGrid.Columns.GridColumn gridProductModel;
        private DevExpress.XtraGrid.Columns.GridColumn gridProductKM;
        private DevExpress.XtraGrid.Columns.GridColumn gridProductColor;
        private DevExpress.XtraGrid.Columns.GridColumn gridProductSituation;
        private DevExpress.XtraGrid.Columns.GridColumn gridMarketPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gridSellPrice;
    }
}