using WinFormsApp.Core.Models;

namespace WinFormsApp.Core.Tests.Abstracts;

public class TestsBase
{
    private Counter _counter;
    protected Counter makeCounter(int value)
    {
        _counter = new Counter();
        _counter.Count = value;
        return _counter;
    }

    protected void assertCounter(int value)
    {
        Assert.Equal(value, _counter.Count);
    }
}