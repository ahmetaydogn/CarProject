using DevExpress.XtraEditors;

namespace UI.Win.Utilities;

public static class Messages
{
    public static void SuccessMessage(string message)
    {
        XtraMessageBox.Show(message,
            "Başarılı",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
    }
    public static void ErrorMessage(string message)
    {
        XtraMessageBox.Show(message,
            "Hata",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error);
    }

    public static void ItMustBeEntityInsert()
    {
        XtraMessageBox.Show("Varlık durumu güncelleme olarak belirlendiği için bu işlem gerçekleştirilemiyor.",
            "Uyarı",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning);
    }

    public static void ItMustBeEntityUpdate()
    {
        XtraMessageBox.Show("Varlık durumu ekleme olarak belirlendiği için bu işlem gerçekleştirilemiyor.",
            "Uyarı",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning);
    }
}
