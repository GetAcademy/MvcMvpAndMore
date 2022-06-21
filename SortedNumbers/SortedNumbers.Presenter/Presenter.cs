using SortedNumbersView;
using SortedNumbersModel;

namespace SortedNumbersPresenter
{
    internal class Presenter
    {
        private View _view;
        private SortedNumbers _model;

        public void Run()
        {
            _view = new View();
            _model = new SortedNumbers();
        }
    }
}
