using UI.Win.Forms.BaseForm;

namespace UI.Win.Show;

public class ShowEditForms<TForm> where TForm : BaseEditForm
{
    public static void ShowDialogEditForm() 
    {
        var frm = (TForm)Activator.CreateInstance(type: typeof(TForm));
        frm.ShowDialog();
    }

    public static void ShowDialogEditForm(params object[] obj)
    {
        var frm = (TForm)Activator.CreateInstance(type: typeof(TForm), args: obj);
        frm.ShowDialog();
    }
}
