using Android.App;
using Android.Content.PM;
using Android.OS;
using Environment = System.Environment;

namespace ExpensesApp.Droid
{
    [Activity(Label = "ExpensesApp", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);

            //SQLite 
            string dbName = "local_db.sqlite";
            string folderPath = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string fullPath = System.IO.Path.Combine(folderPath, dbName);

            LoadApplication(new App(fullPath));
        }
    }
}