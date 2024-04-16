using Business.Abstract;
using DevExpress.XtraBars;
using DevExpress.XtraEditors.Repository;
using UI.Win.Forms.BillForms;
using UI.Win.Forms.CarForms;
using UI.Win.Forms.CarPartsForms;
using UI.Win.Forms.CustomerForm;
using UI.Win.Forms.MainForm;
using UI.Win.Forms.SaleForm;
using UI.Win.Show;

namespace UI.Win
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
            EventsLoad();
        }

        public MainForm(IProductService productService, ISubProductService subProductService, IBillService billService, ICustomerService customerServicce, ISaleService saleService)
        {
            InitializeComponent();
            EventsLoad();
            this.productService = productService;
            this.subProductService = subProductService;
            this.billService = billService;
            this.customerService = customerServicce;
            this.saleService = saleService;
        }

        IProductService productService;
        ISubProductService subProductService;
        IBillService billService;
        ICustomerService customerService;
        ISaleService saleService;

        private void EventsLoad()
        {
            foreach (var item in ribbonControl.Items)
            {
                switch (item)
                {
                    case BarButtonItem btn:
                        btn.ItemClick += ButtonsClick;
                        break;
                }
            }
        }

        private void ButtonsClick(object sender, ItemClickEventArgs e)
        {
            if (e.Item == btnHome)
                ShowListForms<HomePageForm>.ShowListForm();
            else if (e.Item == btnCarList)
                ShowListForms<CarListForm>.ShowListForm();
            else if (e.Item == btnCarAdd)
                ShowEditForms<CarAddForm>.ShowDialogEditForm();
            else if (e.Item == btnCustomerList)
                ShowListForms<CustomerListForm>.ShowListForm();
            else if (e.Item == btnCustomerAdd)
                ShowEditForms<CustomerAddForm>.ShowDialogEditForm();
            else if (e.Item == btnBillList)
                ShowListForms<BillListForm>.ShowListForm();
            else if (e.Item == btnBillAdd)
                ShowEditForms<BillAddForm>.ShowDialogEditForm();
            else if (e.Item == btnSaleList)
                ShowListForms<SaleListForm>.ShowListForm();
            else if (e.Item == btnSaleAdd)
                ShowEditForms<SaleAddForm>.ShowDialogEditForm();
            else if (e.Item == btnSubProductList)
                ShowListForms<CarPartListForm>.ShowListForm();
            else if (e.Item == btnSubProductAdd)
                ShowEditForms<CarPartsAddForm>.ShowDialogEditForm();
        }
    }
}
