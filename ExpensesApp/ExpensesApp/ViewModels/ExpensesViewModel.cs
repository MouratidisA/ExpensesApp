using ExpensesApp.models;
using ExpensesApp.Views;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace ExpensesApp.ViewModels
{

    class ExpensesViewModel
    {
        public ObservableCollection<Expense> Expenses { get; set; }

        public Command AddExpenseCommand { get; set; }

        public ExpensesViewModel()
        {
            Expenses = new ObservableCollection<Expense>();
            AddExpenseCommand = new Command(AddExpense);            
            GetExpenses();
        }

        public void GetExpenses()
        {
            Expenses.Clear();

            foreach (var expense in Expense.GetExpenses())
            {
                Expenses.Add(expense);
            }
        }

        public void AddExpense()
        {
            Application.Current.MainPage.Navigation.PushAsync(new NewExpensePage());
        }
      
    }
}
