namespace WinFormsApp.Core.Abstracts;

public interface ICounter
{
    int Count { get; set; }
    void AddCount(int count);
}