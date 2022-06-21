using SortedNumbersView;
using SortedNumbersModel;

namespace SortedNumbersPresenter
{
    internal class Presenter
    {
        private readonly View _view;
        private readonly SortedNumbers _model;

        public Presenter()
        {
            _view = new View();
            _model = new SortedNumbers();
        }

        public void Run()
        {
            while (true)
            {
                _view.Clear();
                if (!_model.IsEmpty)
                {
                    _view.Show(" - " + string.Join("\n - ", _model.Numbers));
                }

                _view.Show($"Summen er {_model.Sum}");
                _view.Show("Kommandoer: \n - 1 => legge til tall\n - 2 => fjerne tall");
                var cmd = _view.Ask("Hva vil du gjøre? ");
                HandleCommand(cmd);
            }
        }

        private void HandleCommand(string cmd)
        {
            if (!(cmd is "1" or "2")) return;
            var isAddNumber = cmd == "1";
            var word = isAddNumber ? "legge til" : "fjerne";
            var numberStr = _view.Ask($"Hvilket tall vil du {word}? ");
            var number = Convert.ToInt32(numberStr);
            if (isAddNumber) _model.Add(number);
            else _model.Remove(number);
        }
    }
}
