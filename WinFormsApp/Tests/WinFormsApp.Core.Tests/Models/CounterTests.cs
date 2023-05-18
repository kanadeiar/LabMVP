using WinFormsApp.Core.Tests.Abstracts;

namespace WinFormsApp.Core.Tests.Models;

public class CounterTests : TestsBase
{
    [Fact]
    public void CountProperty_GetValue_ShouldOk()
    {
        var counter = makeCounter(10);

        var actual = counter.Count;

        Assert.Equal(10, actual);
    }

    [Fact]
    public void AddCount_AddingValueToGived_ShouldOk()
    {
        var counter = makeCounter(10);

        counter.AddCount(10);

        assertCounter(20);
    }
}