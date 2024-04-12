﻿namespace UI.Win
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            btnHome = new DevExpress.XtraBars.BarButtonItem();
            btnCarList = new DevExpress.XtraBars.BarButtonItem();
            btnCarAdd = new DevExpress.XtraBars.BarButtonItem();
            btnCarIstatistics = new DevExpress.XtraBars.BarButtonItem();
            btnCarReport = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            btnCustomerAdd = new DevExpress.XtraBars.BarButtonItem();
            btnCustomerIstatistics = new DevExpress.XtraBars.BarButtonItem();
            btnPersonList = new DevExpress.XtraBars.BarButtonItem();
            btnPersonAdd = new DevExpress.XtraBars.BarButtonItem();
            btnPersonIstatistics = new DevExpress.XtraBars.BarButtonItem();
            btnBrandList = new DevExpress.XtraBars.BarButtonItem();
            btnBrandAdd = new DevExpress.XtraBars.BarButtonItem();
            btnBrandIstatistics = new DevExpress.XtraBars.BarButtonItem();
            btnCalculator = new DevExpress.XtraBars.BarButtonItem();
            btnNews = new DevExpress.XtraBars.BarButtonItem();
            btnCurrency = new DevExpress.XtraBars.BarButtonItem();
            btnPasswordManage = new DevExpress.XtraBars.BarButtonItem();
            btnAuthentication = new DevExpress.XtraBars.BarButtonItem();
            btnReportMagic = new DevExpress.XtraBars.BarButtonItem();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup10 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPage5 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup11 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPage6 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup12 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPage7 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            btnMainPage = new DevExpress.XtraBars.BarButtonItem();
            xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(components);
            ((System.ComponentModel.ISupportInitialize)ribbonControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xtraTabbedMdiManager1).BeginInit();
            SuspendLayout();
            // 
            // ribbonControl
            // 
            ribbonControl.EmptyAreaImageOptions.ImagePadding = new Padding(26, 24, 26, 24);
            ribbonControl.ExpandCollapseItem.Id = 0;
            ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbonControl.ExpandCollapseItem, btnHome, btnCarList, btnCarAdd, btnCarIstatistics, btnCarReport, barButtonItem1, btnCustomerAdd, btnCustomerIstatistics, btnPersonList, btnPersonAdd, btnPersonIstatistics, btnBrandList, btnBrandAdd, btnBrandIstatistics, btnCalculator, btnNews, btnCurrency, btnPasswordManage, btnAuthentication, btnReportMagic });
            ribbonControl.Location = new Point(0, 0);
            ribbonControl.Margin = new Padding(3, 2, 3, 2);
            ribbonControl.MaxItemId = 23;
            ribbonControl.Name = "ribbonControl";
            ribbonControl.OptionsMenuMinWidth = 289;
            ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1, ribbonPage2, ribbonPage3, ribbonPage4, ribbonPage5, ribbonPage6, ribbonPage7 });
            ribbonControl.Size = new Size(972, 193);
            // 
            // btnHome
            // 
            btnHome.Caption = "Ana Sayfa";
            btnHome.Id = 3;
            btnHome.ImageOptions.LargeImage = (Image)resources.GetObject("btnHome.ImageOptions.LargeImage");
            btnHome.Name = "btnHome";
            // 
            // btnCarList
            // 
            btnCarList.Caption = "Araç Listesi";
            btnCarList.Id = 4;
            btnCarList.ImageOptions.LargeImage = (Image)resources.GetObject("btnCarList.ImageOptions.LargeImage");
            btnCarList.Name = "btnCarList";
            // 
            // btnCarAdd
            // 
            btnCarAdd.Caption = "Araç Ekle";
            btnCarAdd.Id = 5;
            btnCarAdd.ImageOptions.LargeImage = (Image)resources.GetObject("btnCarAdd.ImageOptions.LargeImage");
            btnCarAdd.Name = "btnCarAdd";
            // 
            // btnCarIstatistics
            // 
            btnCarIstatistics.Caption = "Araç İstatistikleri";
            btnCarIstatistics.Id = 6;
            btnCarIstatistics.ImageOptions.LargeImage = (Image)resources.GetObject("btnCarIstatistics.ImageOptions.LargeImage");
            btnCarIstatistics.Name = "btnCarIstatistics";
            // 
            // btnCarReport
            // 
            btnCarReport.Caption = "Araç Raporları";
            btnCarReport.Id = 7;
            btnCarReport.ImageOptions.LargeImage = (Image)resources.GetObject("btnCarReport.ImageOptions.LargeImage");
            btnCarReport.Name = "btnCarReport";
            // 
            // barButtonItem1
            // 
            barButtonItem1.Caption = "Cari Listesi";
            barButtonItem1.Id = 8;
            barButtonItem1.ImageOptions.LargeImage = (Image)resources.GetObject("barButtonItem1.ImageOptions.LargeImage");
            barButtonItem1.Name = "barButtonItem1";
            // 
            // btnCustomerAdd
            // 
            btnCustomerAdd.Caption = "Cari Ekle";
            btnCustomerAdd.Id = 9;
            btnCustomerAdd.ImageOptions.LargeImage = (Image)resources.GetObject("btnCustomerAdd.ImageOptions.LargeImage");
            btnCustomerAdd.Name = "btnCustomerAdd";
            // 
            // btnCustomerIstatistics
            // 
            btnCustomerIstatistics.Caption = "Cari İstatistikleri";
            btnCustomerIstatistics.Id = 10;
            btnCustomerIstatistics.ImageOptions.LargeImage = (Image)resources.GetObject("btnCustomerIstatistics.ImageOptions.LargeImage");
            btnCustomerIstatistics.Name = "btnCustomerIstatistics";
            // 
            // btnPersonList
            // 
            btnPersonList.Caption = "Personel Listesi";
            btnPersonList.Id = 11;
            btnPersonList.ImageOptions.LargeImage = (Image)resources.GetObject("btnPersonList.ImageOptions.LargeImage");
            btnPersonList.Name = "btnPersonList";
            // 
            // btnPersonAdd
            // 
            btnPersonAdd.Caption = "Personel Ekle";
            btnPersonAdd.Id = 12;
            btnPersonAdd.ImageOptions.LargeImage = (Image)resources.GetObject("btnPersonAdd.ImageOptions.LargeImage");
            btnPersonAdd.Name = "btnPersonAdd";
            // 
            // btnPersonIstatistics
            // 
            btnPersonIstatistics.Caption = "Personel İstatistikleri";
            btnPersonIstatistics.Id = 13;
            btnPersonIstatistics.ImageOptions.LargeImage = (Image)resources.GetObject("btnPersonIstatistics.ImageOptions.LargeImage");
            btnPersonIstatistics.Name = "btnPersonIstatistics";
            // 
            // btnBrandList
            // 
            btnBrandList.Caption = "Marka Listesi";
            btnBrandList.Id = 14;
            btnBrandList.ImageOptions.LargeImage = (Image)resources.GetObject("btnBrandList.ImageOptions.LargeImage");
            btnBrandList.Name = "btnBrandList";
            // 
            // btnBrandAdd
            // 
            btnBrandAdd.Caption = "Marka Ekle";
            btnBrandAdd.Id = 15;
            btnBrandAdd.ImageOptions.LargeImage = (Image)resources.GetObject("btnBrandAdd.ImageOptions.LargeImage");
            btnBrandAdd.Name = "btnBrandAdd";
            // 
            // btnBrandIstatistics
            // 
            btnBrandIstatistics.Caption = "Marka İstatistikleri";
            btnBrandIstatistics.Id = 16;
            btnBrandIstatistics.ImageOptions.LargeImage = (Image)resources.GetObject("btnBrandIstatistics.ImageOptions.LargeImage");
            btnBrandIstatistics.Name = "btnBrandIstatistics";
            // 
            // btnCalculator
            // 
            btnCalculator.Caption = "Hesap Makinesi";
            btnCalculator.Id = 17;
            btnCalculator.ImageOptions.LargeImage = (Image)resources.GetObject("btnCalculator.ImageOptions.LargeImage");
            btnCalculator.Name = "btnCalculator";
            // 
            // btnNews
            // 
            btnNews.Caption = "Haberler";
            btnNews.Id = 18;
            btnNews.ImageOptions.LargeImage = (Image)resources.GetObject("btnNews.ImageOptions.LargeImage");
            btnNews.Name = "btnNews";
            // 
            // btnCurrency
            // 
            btnCurrency.Caption = "Kurlar";
            btnCurrency.Id = 19;
            btnCurrency.ImageOptions.LargeImage = (Image)resources.GetObject("btnCurrency.ImageOptions.LargeImage");
            btnCurrency.Name = "btnCurrency";
            // 
            // btnPasswordManage
            // 
            btnPasswordManage.Caption = "Şifre İşlemleri";
            btnPasswordManage.Id = 20;
            btnPasswordManage.ImageOptions.LargeImage = (Image)resources.GetObject("btnPasswordManage.ImageOptions.LargeImage");
            btnPasswordManage.Name = "btnPasswordManage";
            // 
            // btnAuthentication
            // 
            btnAuthentication.Caption = "Yetkilendirme";
            btnAuthentication.Id = 21;
            btnAuthentication.ImageOptions.LargeImage = (Image)resources.GetObject("btnAuthentication.ImageOptions.LargeImage");
            btnAuthentication.Name = "btnAuthentication";
            // 
            // btnReportMagic
            // 
            btnReportMagic.Caption = "Rapor Sihirbazı";
            btnReportMagic.Id = 22;
            btnReportMagic.ImageOptions.LargeImage = (Image)resources.GetObject("btnReportMagic.ImageOptions.LargeImage");
            btnReportMagic.Name = "btnReportMagic";
            // 
            // ribbonPage1
            // 
            ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1 });
            ribbonPage1.Name = "ribbonPage1";
            ribbonPage1.Text = "Ana Sayfa";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.ItemLinks.Add(btnHome);
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPage2
            // 
            ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup2, ribbonPageGroup8 });
            ribbonPage2.Name = "ribbonPage2";
            ribbonPage2.Text = "Araçlar";
            // 
            // ribbonPageGroup2
            // 
            ribbonPageGroup2.ItemLinks.Add(btnCarList);
            ribbonPageGroup2.ItemLinks.Add(btnCarAdd);
            ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup8
            // 
            ribbonPageGroup8.ItemLinks.Add(btnCarIstatistics);
            ribbonPageGroup8.ItemLinks.Add(btnCarReport);
            ribbonPageGroup8.Name = "ribbonPageGroup8";
            // 
            // ribbonPage3
            // 
            ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup3, ribbonPageGroup9 });
            ribbonPage3.Name = "ribbonPage3";
            ribbonPage3.Text = "Cariler";
            // 
            // ribbonPageGroup3
            // 
            ribbonPageGroup3.ItemLinks.Add(barButtonItem1);
            ribbonPageGroup3.ItemLinks.Add(btnCustomerAdd);
            ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup9
            // 
            ribbonPageGroup9.ItemLinks.Add(btnCustomerIstatistics);
            ribbonPageGroup9.Name = "ribbonPageGroup9";
            // 
            // ribbonPage4
            // 
            ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup4, ribbonPageGroup10 });
            ribbonPage4.Name = "ribbonPage4";
            ribbonPage4.Text = "Personeller";
            // 
            // ribbonPageGroup4
            // 
            ribbonPageGroup4.ItemLinks.Add(btnPersonList);
            ribbonPageGroup4.ItemLinks.Add(btnPersonAdd);
            ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPageGroup10
            // 
            ribbonPageGroup10.ItemLinks.Add(btnPersonIstatistics);
            ribbonPageGroup10.Name = "ribbonPageGroup10";
            // 
            // ribbonPage5
            // 
            ribbonPage5.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup5, ribbonPageGroup11 });
            ribbonPage5.Name = "ribbonPage5";
            ribbonPage5.Text = "Markalar";
            // 
            // ribbonPageGroup5
            // 
            ribbonPageGroup5.ItemLinks.Add(btnBrandList);
            ribbonPageGroup5.ItemLinks.Add(btnBrandAdd);
            ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonPageGroup11
            // 
            ribbonPageGroup11.ItemLinks.Add(btnBrandIstatistics);
            ribbonPageGroup11.Name = "ribbonPageGroup11";
            // 
            // ribbonPage6
            // 
            ribbonPage6.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup6, ribbonPageGroup12 });
            ribbonPage6.Name = "ribbonPage6";
            ribbonPage6.Text = "Araçlar";
            // 
            // ribbonPageGroup6
            // 
            ribbonPageGroup6.ItemLinks.Add(btnCalculator);
            ribbonPageGroup6.ItemLinks.Add(btnNews);
            ribbonPageGroup6.ItemLinks.Add(btnCurrency);
            ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // ribbonPageGroup12
            // 
            ribbonPageGroup12.ItemLinks.Add(btnPasswordManage);
            ribbonPageGroup12.ItemLinks.Add(btnAuthentication);
            ribbonPageGroup12.Name = "ribbonPageGroup12";
            // 
            // ribbonPage7
            // 
            ribbonPage7.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup7 });
            ribbonPage7.Name = "ribbonPage7";
            ribbonPage7.Text = "Raporlar";
            // 
            // ribbonPageGroup7
            // 
            ribbonPageGroup7.ItemLinks.Add(btnReportMagic);
            ribbonPageGroup7.Name = "ribbonPageGroup7";
            // 
            // btnMainPage
            // 
            btnMainPage.Caption = "Ana Sayfa";
            btnMainPage.Id = 1;
            btnMainPage.ImageOptions.LargeImage = (Image)resources.GetObject("btnMainPage.ImageOptions.LargeImage");
            btnMainPage.Name = "btnMainPage";
            // 
            // xtraTabbedMdiManager1
            // 
            xtraTabbedMdiManager1.MdiParent = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(972, 621);
            Controls.Add(ribbonControl);
            IsMdiContainer = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Ribbon = ribbonControl;
            Text = "Ahmet Aydoğan - Car Project";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)ribbonControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)xtraTabbedMdiManager1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage7;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.BarButtonItem btnMainPage;
        private DevExpress.XtraBars.BarButtonItem btnHome;
        private DevExpress.XtraBars.BarButtonItem btnCarList;
        private DevExpress.XtraBars.BarButtonItem btnCarAdd;
        private DevExpress.XtraBars.BarButtonItem btnCarIstatistics;
        private DevExpress.XtraBars.BarButtonItem btnCarReport;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnCustomerAdd;
        private DevExpress.XtraBars.BarButtonItem btnCustomerIstatistics;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.BarButtonItem btnPersonList;
        private DevExpress.XtraBars.BarButtonItem btnPersonAdd;
        private DevExpress.XtraBars.BarButtonItem btnPersonIstatistics;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup10;
        private DevExpress.XtraBars.BarButtonItem btnBrandList;
        private DevExpress.XtraBars.BarButtonItem btnBrandAdd;
        private DevExpress.XtraBars.BarButtonItem btnBrandIstatistics;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup11;
        private DevExpress.XtraBars.BarButtonItem btnCalculator;
        private DevExpress.XtraBars.BarButtonItem btnNews;
        private DevExpress.XtraBars.BarButtonItem btnCurrency;
        private DevExpress.XtraBars.BarButtonItem btnPasswordManage;
        private DevExpress.XtraBars.BarButtonItem btnAuthentication;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup12;
        private DevExpress.XtraBars.BarButtonItem btnReportMagic;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}
