namespace WinFormsApp.Infra.Tools;

public static class ExceptionsExtensions
{
    public static void Try(this Form form, Action action)
    {
        try
        {
            action.Invoke();
        }
        catch (Exception e)
        {
            MessageBox.Show("Исключение: " + e.GetType() + Environment.NewLine
                            + "сообдение: " + e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
#if DEBUG
            throw;
#endif
        }
    }
}