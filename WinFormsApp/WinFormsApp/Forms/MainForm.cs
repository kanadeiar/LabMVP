using Microsoft.Extensions.DependencyInjection;
using WinFormsApp.Core.Models;

namespace WinFormsApp.Forms
{
    public partial class MainForm : Form
    {
        private readonly IServiceProvider _services;
        private readonly Counter _counter;
        public MainForm(IServiceProvider services)
        {
            _services = services;
            _counter = _services.GetRequiredService<Counter>();
            InitializeComponent();
        }
    }
}
