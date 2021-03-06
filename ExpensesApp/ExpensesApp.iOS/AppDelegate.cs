﻿using ExpensesApp.iOS.Dependencies;
using Foundation;
using System;
using UIKit;
using Xamarin.Forms;

namespace ExpensesApp.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App());

            //SQLite 
            string dbName = "local_db.sqlite";
            string folderPath = System.IO.Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.Personal), "..", "Library");
            string fullPath = System.IO.Path.Combine(folderPath, dbName);

            //Share dependency registration
            DependencyService.Register<Share>();

            LoadApplication(new App(fullPath));
            return base.FinishedLaunching(app, options);
        }
    }
}
