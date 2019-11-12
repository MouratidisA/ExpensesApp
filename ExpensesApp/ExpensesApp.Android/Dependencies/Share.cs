using System.Threading.Tasks;
using ExpensesApp.Droid.Dependencies;
using ExpensesApp.Interfaces;
using Xamarin.Forms;


[assembly: Dependency(typeof(Share))]
namespace ExpensesApp.Droid.Dependencies
{
    class Share:IShare
    {

        public Share()
        {

        }


        public async Task Show(string title, string message, string filePath)
        {
            throw new System.NotImplementedException();
        }
    }
}