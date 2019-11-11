using ExpensesApp.Annotations;
using ExpensesApp.models;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace ExpensesApp.ViewModels
{
    class NewExpensesViewModel : INotifyPropertyChanged
    {
        private string _expenseName;
        public string ExpenseName
        {
            get { return _expenseName; }
            set { _expenseName = value; OnPropertyChanged("ExpenseName"); }
        }

        private string _expenseDescription;
        public string ExpenseDescription
        {
            get { return _expenseDescription; }
            set { _expenseDescription = value; OnPropertyChanged("ExpenseDescription"); }
        }

        private float _expenseAmount;
        public float ExpenseAmount
        {
            get { return _expenseAmount; }
            set { _expenseAmount = value; OnPropertyChanged("ExpenseAmount"); }
        }

        private DateTime _expenseDate;
        public DateTime ExpenseDate
        {
            get { return _expenseDate; }
            set { _expenseDate = value; OnPropertyChanged("ExpenseDate"); }
        }

        private string _expenseCategory;
        public string ExpenseCategory
        {
            get { return _expenseCategory; }
            set { _expenseCategory = value; OnPropertyChanged("ExpenseCategory"); }
        }

        public Command SaveExpenseCommand { get; set; }

        public NewExpensesViewModel()
        {
            SaveExpenseCommand = new Command(InsertExpense);
        }

        public void InsertExpense()
        {
            Expense expense=new Expense()
            {
                Name = ExpenseName,
                Description = ExpenseDescription,
                Amount = ExpenseAmount,
                Date = ExpenseDate,
                Category = ExpenseCategory
            };

            int response = Expense.InsertExpense(expense);

            if (response > 0)
            {
                Application.Current.MainPage.Navigation.PopAsync();
            }
            else
            {
                Application.Current.MainPage.DisplayAlert("Error", "No items were inserted", "Ok");
            }

        }

        // INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
