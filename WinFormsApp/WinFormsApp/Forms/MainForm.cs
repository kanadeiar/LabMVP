using Microsoft.Extensions.DependencyInjection;

namespace WinFormsApp.Forms
{
    public partial class MainForm : Form
    {
        private readonly IServiceCollection _services;
        public MainForm(IServiceCollection services)
        {
            _services = services;
            InitializeComponent();
        }
    }
}
