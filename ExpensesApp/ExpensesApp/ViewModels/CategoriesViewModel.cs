using System.Collections.ObjectModel;

namespace ExpensesApp.ViewModels
{

    class CategoriesViewModel
    {
        ObservableCollection<string> Categories { get; set; }

        public CategoriesViewModel()
        {
            Categories = new ObservableCollection<string>();
            GetCategories();
        }

        private void GetCategories()
        {
            Categories.Clear();
            Categories.Add("Housing");
            Categories.Add("Debt");
            Categories.Add("Health");
            Categories.Add("Food");
            Categories.Add("Personal");
            Categories.Add("Travel");
            Categories.Add("Other");
        }
    }
}
