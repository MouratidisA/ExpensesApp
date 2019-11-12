using ExpensesApp.Interfaces;
using System.Threading.Tasks;

namespace ExpensesApp.iOS.Dependencies
{
    class Share : IShare
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