using WinFormsApp.Core.Abstracts;

namespace WinFormsApp.Core.Models;

public class Counter : ICounter
{
    public int Count { get; set; }

    public void AddCount(int count)
    {
        Count += count;
    }
}