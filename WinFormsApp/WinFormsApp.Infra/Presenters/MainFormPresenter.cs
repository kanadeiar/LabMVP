using WinFormsApp.Core.Models;
using WinFormsApp.Infra.Abstracts;

namespace WinFormsApp.Infra.Presenters;

public class MainFormPresenter
{
    private readonly Counter _counter;
    private readonly IMainFormView _view;
    public MainFormPresenter(Counter counter, IMainFormView view)
    {
        _counter = counter;
        _view = view;
    }

    public void Run()
    {
       _view.Show();
    }
}