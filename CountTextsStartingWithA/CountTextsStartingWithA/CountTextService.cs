namespace CountTextsStartingWithA
{
    internal class CountTextService
    {
        private readonly ITextFetcher _textFetcher;

        public CountTextService(ITextFetcher textFetcher) // <-- constructor injection
        {
            _textFetcher = textFetcher;
        }
        public int Count(string startText)
        {
            var count = 0;
            var text = _textFetcher.GetText();
            while (text != null)
            {
                if (text.StartsWith('A')) count++;
                text = _textFetcher.GetText();
            }
            return count;
        }
    }
}
