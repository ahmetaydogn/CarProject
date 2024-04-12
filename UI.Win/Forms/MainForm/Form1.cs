using DevExpress.XtraBars;
using DevExpress.XtraEditors.Repository;
using UI.Win.Forms.CarForms;
using UI.Win.Show;

namespace UI.Win
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
            EventsLoad();
        }

        private void EventsLoad()
        {
            foreach(var item in ribbonControl.Items)
            {
                switch(item)
                {
                    case BarButtonItem btn:
                        btn.ItemClick += ButtonsClick;
                        break;
                }
            }
        }

        private void ButtonsClick(object sender, ItemClickEventArgs e)
        {
            if (e.Item == btnCarList)
                ShowListForms<CarListForm>.ShowListForm();
            else if (e.Item == btnCarAdd)
                ShowEditForms<CarAddForm>.ShowDialogEditForm();
        }
    }
}
