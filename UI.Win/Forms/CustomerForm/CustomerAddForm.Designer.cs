namespace UI.Win.Forms.CustomerForm
{
    partial class CustomerAddForm
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
            txtAddress = new DevExpress.XtraEditors.MemoEdit();
            txtTaxNo = new DevExpress.XtraEditors.TextEdit();
            txtCustomerPhone = new DevExpress.XtraEditors.TextEdit();
            txtCustomerSurname = new DevExpress.XtraEditors.TextEdit();
            txtCustomerName = new DevExpress.XtraEditors.TextEdit();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)myDataLayoutControl1).BeginInit();
            myDataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtAddress.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtTaxNo.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtCustomerPhone.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtCustomerSurname.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtCustomerName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
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
            myDataLayoutControl1.Controls.Add(txtAddress);
            myDataLayoutControl1.Controls.Add(txtTaxNo);
            myDataLayoutControl1.Controls.Add(txtCustomerPhone);
            myDataLayoutControl1.Controls.Add(txtCustomerSurname);
            myDataLayoutControl1.Controls.Add(txtCustomerName);
            myDataLayoutControl1.Dock = DockStyle.Fill;
            myDataLayoutControl1.Location = new Point(0, 126);
            myDataLayoutControl1.Name = "myDataLayoutControl1";
            myDataLayoutControl1.OptionsFocus.EnableAutoTabOrder = false;
            myDataLayoutControl1.Root = Root;
            myDataLayoutControl1.Size = new Size(800, 324);
            myDataLayoutControl1.TabIndex = 1;
            myDataLayoutControl1.Text = "myDataLayoutControl1";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(97, 132);
            txtAddress.MenuManager = ribbonControl1;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(691, 180);
            txtAddress.StyleController = myDataLayoutControl1;
            txtAddress.TabIndex = 8;
            // 
            // txtTaxNo
            // 
            txtTaxNo.Location = new Point(97, 84);
            txtTaxNo.MenuManager = ribbonControl1;
            txtTaxNo.Name = "txtTaxNo";
            txtTaxNo.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            txtTaxNo.Properties.MaskSettings.Set("mask", "0000000000");
            txtTaxNo.Properties.MaskSettings.Set("placeholder", '9');
            txtTaxNo.Properties.MaxLength = 10;
            txtTaxNo.Properties.UseMaskAsDisplayFormat = true;
            txtTaxNo.Size = new Size(151, 22);
            txtTaxNo.StyleController = myDataLayoutControl1;
            txtTaxNo.TabIndex = 7;
            // 
            // txtCustomerPhone
            // 
            txtCustomerPhone.Location = new Point(97, 60);
            txtCustomerPhone.MenuManager = ribbonControl1;
            txtCustomerPhone.Name = "txtCustomerPhone";
            txtCustomerPhone.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            txtCustomerPhone.Properties.MaskSettings.Set("mask", "(000) 000-0000");
            txtCustomerPhone.Properties.UseMaskAsDisplayFormat = true;
            txtCustomerPhone.Size = new Size(151, 22);
            txtCustomerPhone.StyleController = myDataLayoutControl1;
            txtCustomerPhone.TabIndex = 6;
            // 
            // txtCustomerSurname
            // 
            txtCustomerSurname.Location = new Point(97, 36);
            txtCustomerSurname.MenuManager = ribbonControl1;
            txtCustomerSurname.Name = "txtCustomerSurname";
            txtCustomerSurname.Size = new Size(151, 22);
            txtCustomerSurname.StyleController = myDataLayoutControl1;
            txtCustomerSurname.TabIndex = 5;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(97, 12);
            txtCustomerName.MenuManager = ribbonControl1;
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(151, 22);
            txtCustomerName.StyleController = myDataLayoutControl1;
            txtCustomerName.TabIndex = 4;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, layoutControlItem2, layoutControlItem3, layoutControlItem4, layoutControlItem5 });
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
            rowDefinition6.Height = 100D;
            rowDefinition6.SizeType = SizeType.Percent;
            Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] { rowDefinition1, rowDefinition2, rowDefinition3, rowDefinition4, rowDefinition5, rowDefinition6 });
            Root.Size = new Size(800, 324);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = txtCustomerName;
            layoutControlItem1.Location = new Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new Size(240, 24);
            layoutControlItem1.Text = "Cari İsmi";
            layoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            layoutControlItem1.TextSize = new Size(80, 20);
            layoutControlItem1.TextToControlDistance = 5;
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = txtCustomerSurname;
            layoutControlItem2.Location = new Point(0, 24);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.OptionsTableLayoutItem.RowIndex = 1;
            layoutControlItem2.Size = new Size(240, 24);
            layoutControlItem2.Text = "Cari Soyismi";
            layoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            layoutControlItem2.TextSize = new Size(80, 20);
            layoutControlItem2.TextToControlDistance = 5;
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = txtCustomerPhone;
            layoutControlItem3.Location = new Point(0, 48);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.OptionsTableLayoutItem.RowIndex = 2;
            layoutControlItem3.Size = new Size(240, 24);
            layoutControlItem3.Text = "Cari Telefon";
            layoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            layoutControlItem3.TextSize = new Size(80, 20);
            layoutControlItem3.TextToControlDistance = 5;
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.Control = txtTaxNo;
            layoutControlItem4.Location = new Point(0, 72);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.OptionsTableLayoutItem.RowIndex = 3;
            layoutControlItem4.Size = new Size(240, 24);
            layoutControlItem4.Text = "Vergi Numarası";
            layoutControlItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            layoutControlItem4.TextSize = new Size(80, 20);
            layoutControlItem4.TextToControlDistance = 5;
            // 
            // layoutControlItem5
            // 
            layoutControlItem5.Control = txtAddress;
            layoutControlItem5.Location = new Point(0, 120);
            layoutControlItem5.Name = "layoutControlItem5";
            layoutControlItem5.OptionsTableLayoutItem.ColumnSpan = 3;
            layoutControlItem5.OptionsTableLayoutItem.RowIndex = 5;
            layoutControlItem5.Size = new Size(780, 184);
            layoutControlItem5.Text = "Adres";
            layoutControlItem5.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            layoutControlItem5.TextSize = new Size(80, 20);
            layoutControlItem5.TextToControlDistance = 5;
            // 
            // CustomerAddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(myDataLayoutControl1);
            Name = "CustomerAddForm";
            Text = "Cari Ekleme Formu";
            Controls.SetChildIndex(ribbonControl1, 0);
            Controls.SetChildIndex(myDataLayoutControl1, 0);
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)myDataLayoutControl1).EndInit();
            myDataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtAddress.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtTaxNo.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtCustomerPhone.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtCustomerSurname.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtCustomerName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private UserControls.MyDataLayoutControl myDataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.MemoEdit txtAddress;
        private DevExpress.XtraEditors.TextEdit txtTaxNo;
        private DevExpress.XtraEditors.TextEdit txtCustomerPhone;
        private DevExpress.XtraEditors.TextEdit txtCustomerSurname;
        private DevExpress.XtraEditors.TextEdit txtCustomerName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}