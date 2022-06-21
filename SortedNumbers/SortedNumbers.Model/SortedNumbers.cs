namespace SortedNumbersModel
{
    public class SortedNumbers
    {
        private List<int> _numbers;
        public int[] Numbers => _numbers.ToArray();
        public int Sum => _numbers.Sum();

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
