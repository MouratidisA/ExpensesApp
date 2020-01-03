using ExpensesApp.Annotations;
using ExpensesApp.models;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ExpensesApp.ViewModels
{
    public class ExpenseDetailsViewModel :INotifyPropertyChanged
    {
        private Expense _expense;
        public Expense Expense
        {
            get { return _expense; }
            set
            {
                _expense = value;
                OnPropertyChanged("Expense");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
