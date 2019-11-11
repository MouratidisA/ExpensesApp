using ExpensesApp.models;
using System.Collections.ObjectModel;

namespace ExpensesApp.ViewModels
{

    class ExpensesViewModel
    {
        private ObservableCollection<Expense> Expenses { get; set; }

        public ExpensesViewModel()
        {
            Expenses = new ObservableCollection<Expense>();
            GetExpenses();
        }

        private void GetExpenses()
        {
            Expenses.Clear();

            foreach (var expense in Expense.GetExpenses())
            {
                Expenses.Add(expense);
            }
        }
    }
}
