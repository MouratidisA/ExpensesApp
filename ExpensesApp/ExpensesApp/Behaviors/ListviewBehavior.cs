using ExpensesApp.models;
using ExpensesApp.Views;
using Xamarin.Forms;

namespace ExpensesApp.Behaviors
{
    class ListviewBehavior:Behavior<ListView>
    {
        private ListView _listView;
        protected override void OnAttachedTo(ListView bindable)
        {
            base.OnAttachedTo(bindable);
            _listView = bindable;
            _listView.ItemSelected += ListView_ItemSelected;
        }

        protected override void OnDetachingFrom(ListView bindable)
        {
            base.OnDetachingFrom(bindable);
            _listView.ItemSelected -= ListView_ItemSelected;
        }

        void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Expense selectedExpense = _listView.SelectedItem as Expense;
            App.Current.MainPage.Navigation.PushAsync(new ExpenseDetailsPage(selectedExpense));
        }
    }
}
