using ExpensesApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExpensesApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CategoriesPage : ContentPage
    {
        private CategoriesViewModel _viewModel;  
		public CategoriesPage()
		{
			InitializeComponent ();
            _viewModel = Resources["vm"] as CategoriesViewModel;    
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.GetExpensesPerCategory();
        }
    }
}