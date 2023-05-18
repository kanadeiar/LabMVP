using Microsoft.Extensions.DependencyInjection;
using WinFormsApp.Core.Abstracts;
using WinFormsApp.Core.Models;
using WinFormsApp.Infra.Abstracts;

namespace WinFormsApp.Forms
{
    public partial class MainForm : Form, IMainFormView
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
