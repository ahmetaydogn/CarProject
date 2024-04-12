using DevExpress.XtraBars;
using UI.Win.Forms.CarForms;
using UI.Win.Show;

namespace UI.Win.Forms.BaseForm;

public partial class BaseEditForm : Form
{
    public BaseEditForm()
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
        if (e.Item == btnExit)
            Close();
        else if (e.Item == btnUndo)
            FillGaps();
        else if (e.Item == btnAdd)
            ClearData();
        else if (e.Item == btnDelete)
            DeleteEntity();
        else if (e.Item == btnSaveAs)
            SaveAs();
        else if (e.Item == btnSave)
            Save();
    }

    public virtual void FillGaps() { }

    public virtual void ClearData() { }

    public virtual void DeleteEntity() { }

    public virtual void SaveAs() { }
    
    public virtual void Save() { }

    public virtual void SendEntityToAdd() { }
    
    public virtual void SendEntityToUpdate() { }
}
