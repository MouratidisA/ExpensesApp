using Android.Content;
using Android.Support.V4.Content;
using ExpensesApp.Droid.Dependencies;
using ExpensesApp.Interfaces;
using System.Threading.Tasks;
using Xamarin.Forms;


[assembly: Dependency(typeof(Share))]
namespace ExpensesApp.Droid.Dependencies
{
    class Share:IShare
    {
 
        public Task Show(string title, string message, string filePath)
        {
            var intent = new Intent(Intent.ActionSend);
            intent.SetType("text/plain");
            var documentUri = FileProvider.GetUriForFile(Forms.Context.ApplicationContext,
                "om.companyname.ExpensesApp.provider", new Java.IO.File(filePath));

            intent.PutExtra(Intent.ExtraStream, documentUri);
            intent.PutExtra(Intent.ExtraText, title);
            intent.PutExtra(Intent.ExtraSubject,message);

            var chooserIntent = Intent.CreateChooser(intent, title);
            chooserIntent.SetFlags(ActivityFlags.GrantReadUriPermission);

            Android.App.Application.Context.StartActivity(chooserIntent);

            return Task.FromResult(true);
        }
    }
}