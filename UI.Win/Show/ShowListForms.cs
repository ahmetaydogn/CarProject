using System.Windows.Forms;

namespace UI.Win.Show;

public class ShowListForms<TForm> where TForm : Form, new()
{
    public static void ShowListForm()
    {
        var frm = Activator.CreateInstance<TForm>();
        frm.MdiParent = Form.ActiveForm;
        frm.Show();
    }

    public static Form ShowDialogListForm()
    {
        var frm = Activator.CreateInstance<TForm>();
        frm.ShowDialog();
        return frm;
    }
}
