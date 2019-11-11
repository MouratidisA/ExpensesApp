using ExpensesApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExpensesApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ExpensesPage : ContentPage
    {
        private ExpensesViewModel _viewModel;

        public ExpensesPage ()
		{
			InitializeComponent ();
            _viewModel = Resources["vm"] as ExpensesViewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.GetExpenses();
        }
    }
}