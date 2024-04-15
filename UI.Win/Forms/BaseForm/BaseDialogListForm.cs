using DevExpress.XtraBars;

namespace UI.Win.Forms.BaseForm;

public partial class BaseDialogListForm : Form
{
    public BaseDialogListForm()
    {
        InitializeComponent();
        EventsLoad();
    }

    private void EventsLoad()
    {
        foreach (var item in ribbonControl1.Items)
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
        if (e.Item == btnSelect)
            SelectEntity();
        else if (e.Item == btnAdd)
            AddEntity();
        else if (e.Item == btnRefreshSource)
            RefreshGridControl();
        else if (e.Item == btnExit)
            Close();
    }

    public virtual void SelectEntity() { }

    public virtual void RefreshGridControl() { }

    public virtual void AddEntity() { }

    public void HideSelectButton ()
    {
        btnSelect.Visibility = BarItemVisibility.Never;
    }
}
