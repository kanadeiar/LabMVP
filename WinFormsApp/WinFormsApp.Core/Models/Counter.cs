namespace WinFormsApp.Core.Models
{
    public class Counter
    {
        public int Count { get; set; }

        public void AddCount(int count)
        {
            Count += count;
        }
    }
}
