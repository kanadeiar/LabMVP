using WinFormsApp.Core.Abstracts;
using WinFormsApp.Infra.Abstracts;

namespace WinFormsApp.Infra.Presenters;

public class MainFormPresenter
{
    private readonly ICounter _counter;
    private readonly IMainFormView _view;
    public MainFormPresenter(ICounter counter, IMainFormView view)
    {
        _counter = counter;
        _view = view;
    }

    public void Run()
    {
       _view.Show();
    }
}