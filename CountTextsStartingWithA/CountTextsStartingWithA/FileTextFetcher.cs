namespace CountTextsStartingWithA
{
    internal class FileTextFetcher : ITextFetcher
    {
        private readonly StreamReader _streamReader;

        public FileTextFetcher(string fileName)
        {
            var fileStream = File.OpenRead(fileName);
            _streamReader = new StreamReader(fileStream);
        }

        public string GetText()
        {
            var text = _streamReader.ReadLine();
            if (text == null)
            {
                _streamReader.Close();
            }
            return text;
        }
    }
}
