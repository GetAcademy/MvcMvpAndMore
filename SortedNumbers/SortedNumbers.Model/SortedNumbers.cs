namespace SortedNumbersModel
{
    public class SortedNumbers
    {
        private readonly List<int> _numbers;
        public int[] Numbers => _numbers.ToArray();
        public int Sum => _numbers.Sum();
        public bool IsEmpty => _numbers.Count == 0;

        public SortedNumbers()
        {
            _numbers = new List<int>();
        }

        public void Add(int number)
        {
            var i = 0;
            while (i < _numbers.Count && _numbers[i] < number)
            {
                i++;
            }
            _numbers.Insert(i, number);
        }

        public void Remove(int number)
        {
            _numbers.Remove(number);
        }
    }
}
