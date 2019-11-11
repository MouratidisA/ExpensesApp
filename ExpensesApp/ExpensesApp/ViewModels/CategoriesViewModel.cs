using ExpensesApp.models;
using System.Collections.ObjectModel;
using System.Linq;

namespace ExpensesApp.ViewModels
{

    class CategoriesViewModel
    {
        public ObservableCollection<string> Categories { get; set; }
        public ObservableCollection<CategoryExpenses> CategoryExpensesCollection { get; set; }

        public CategoriesViewModel()
        {
            Categories = new ObservableCollection<string>();
            CategoryExpensesCollection = new ObservableCollection<CategoryExpenses>();
            GetCategories();
            GetExpensesPerCategory();
        }

        public void GetExpensesPerCategory()
        {
            CategoryExpensesCollection.Clear();
            float totalExpensesAmount = Expense.GetTotalExpensesAmount();
            foreach (var category in Categories)
            {
                var expenses = Expense.GetExpenses(category);
                float expensesAmountInCategory = expenses.Sum(e=>e.Amount);

                CategoryExpenses categoryExpenses = new CategoryExpenses()
                {
                    Category = category,
                    ExpensesPercentage = expensesAmountInCategory/totalExpensesAmount
                };

                CategoryExpensesCollection.Add(categoryExpenses);
            }
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

        public class CategoryExpenses
        {
            public string Category { get; set; }
            public float ExpensesPercentage { get; set; }
        }
    }
}
