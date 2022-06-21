namespace SortedNumbersView
{
    public class View
    {
        public void Clear()
        {
            Console.Clear();
        }

        public void Show(string txt)
        {
            Console.WriteLine(txt);
        }

        public string Ask(string question)
        {
            Console.Write(question);
            return Console.ReadLine();
        }
    }
}
