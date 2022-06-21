namespace CountTextsStartingWithA
{
    internal class ConsoleTextFetcher : ITextFetcher
    {
        public string GetText()
        {
            Console.Write("Skriv tekst: ");
            var text = Console.ReadLine();
            if (text == "") return null;
            return text;
        }
    }
}
