namespace UI.Win.Forms.SaleForm
{
    partial class SaleListForm
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
            gridSale = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridCustomerFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            gridCustomerPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            gridProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            gridSaleDate = new DevExpress.XtraGrid.Columns.GridColumn();
            gridQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            gridPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            gridProfit = new DevExpress.XtraGrid.Columns.GridColumn();
            gridPaymentMethod = new DevExpress.XtraGrid.Columns.GridColumn();
            gridBillNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridSale).BeginInit();
            SuspendLayout();
            // 
            // gridControl1
            // 
            gridControl1.Dock = DockStyle.Fill;
            gridControl1.Location = new Point(0, 0);
            gridControl1.MainView = gridSale;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(905, 450);
            gridControl1.TabIndex = 0;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridSale });
            gridControl1.DoubleClick += gridControl1_DoubleClick;
            // 
            // gridSale
            // 
            gridSale.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridCustomerFullName, gridCustomerPhone, gridProductName, gridSaleDate, gridQuantity, gridPrice, gridProfit, gridPaymentMethod, gridBillNumber });
            gridSale.GridControl = gridControl1;
            gridSale.Name = "gridSale";
            gridSale.OptionsBehavior.Editable = false;
            // 
            // gridCustomerFullName
            // 
            gridCustomerFullName.Caption = "Cari Adı Soyadı";
            gridCustomerFullName.FieldName = "CustomerFullName";
            gridCustomerFullName.MinWidth = 25;
            gridCustomerFullName.Name = "gridCustomerFullName";
            gridCustomerFullName.Visible = true;
            gridCustomerFullName.VisibleIndex = 0;
            gridCustomerFullName.Width = 94;
            // 
            // gridCustomerPhone
            // 
            gridCustomerPhone.Caption = "Cari Telefon";
            gridCustomerPhone.FieldName = "CustomerPhone";
            gridCustomerPhone.MinWidth = 25;
            gridCustomerPhone.Name = "gridCustomerPhone";
            gridCustomerPhone.Visible = true;
            gridCustomerPhone.VisibleIndex = 1;
            gridCustomerPhone.Width = 94;
            // 
            // gridProductName
            // 
            gridProductName.Caption = "Ürün Bilgileri";
            gridProductName.FieldName = "ProductName";
            gridProductName.MinWidth = 25;
            gridProductName.Name = "gridProductName";
            gridProductName.Visible = true;
            gridProductName.VisibleIndex = 2;
            gridProductName.Width = 94;
            // 
            // gridSaleDate
            // 
            gridSaleDate.Caption = "Satış Tarihi";
            gridSaleDate.FieldName = "SaleDate";
            gridSaleDate.MinWidth = 25;
            gridSaleDate.Name = "gridSaleDate";
            gridSaleDate.Visible = true;
            gridSaleDate.VisibleIndex = 3;
            gridSaleDate.Width = 94;
            // 
            // gridQuantity
            // 
            gridQuantity.Caption = "Satış Miktarı";
            gridQuantity.FieldName = "Quantity";
            gridQuantity.MinWidth = 25;
            gridQuantity.Name = "gridQuantity";
            gridQuantity.Visible = true;
            gridQuantity.VisibleIndex = 4;
            gridQuantity.Width = 94;
            // 
            // gridPrice
            // 
            gridPrice.Caption = "Toplam Tutar";
            gridPrice.FieldName = "Price";
            gridPrice.MinWidth = 25;
            gridPrice.Name = "gridPrice";
            gridPrice.Visible = true;
            gridPrice.VisibleIndex = 5;
            gridPrice.Width = 94;
            // 
            // gridProfit
            // 
            gridProfit.Caption = "Kazanç";
            gridProfit.FieldName = "Profit";
            gridProfit.MinWidth = 25;
            gridProfit.Name = "gridProfit";
            gridProfit.Visible = true;
            gridProfit.VisibleIndex = 6;
            gridProfit.Width = 94;
            // 
            // gridPaymentMethod
            // 
            gridPaymentMethod.Caption = "Ödeme Yöntemi";
            gridPaymentMethod.FieldName = "PaymentMethod";
            gridPaymentMethod.MinWidth = 25;
            gridPaymentMethod.Name = "gridPaymentMethod";
            gridPaymentMethod.Visible = true;
            gridPaymentMethod.VisibleIndex = 7;
            gridPaymentMethod.Width = 94;
            // 
            // gridBillNumber
            // 
            gridBillNumber.Caption = "Fatura Numarası";
            gridBillNumber.FieldName = "BillNumber";
            gridBillNumber.MinWidth = 25;
            gridBillNumber.Name = "gridBillNumber";
            gridBillNumber.Visible = true;
            gridBillNumber.VisibleIndex = 8;
            gridBillNumber.Width = 94;
            // 
            // SaleListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 450);
            Controls.Add(gridControl1);
            Name = "SaleListForm";
            Text = "SaleListForm";
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridSale).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridSale;
        private DevExpress.XtraGrid.Columns.GridColumn gridCustomerFullName;
        private DevExpress.XtraGrid.Columns.GridColumn gridProductName;
        private DevExpress.XtraGrid.Columns.GridColumn gridSaleDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn gridPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gridPaymentMethod;
        private DevExpress.XtraGrid.Columns.GridColumn gridProfit;
        private DevExpress.XtraGrid.Columns.GridColumn gridCustomerPhone;
        private DevExpress.XtraGrid.Columns.GridColumn gridBillNumber;
    }
}