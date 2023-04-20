namespace WinFormsApp.Forms;

public partial class MainForm : Form
{
    private readonly ICounter _counter;
    public MainForm(ICounter counter)
    {
        _counter = counter;

        InitializeComponent();
    }

    private void btnCounter_Click(object sender, EventArgs e)
    {
        _counter.Count++;
        lblCounter.Text = _counter.Count.ToString();
    }
}

