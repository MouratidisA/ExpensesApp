﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace ExpensesApp.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            //LoadApplication(new ExpensesApp.App());
            string dbName = "local_db.sqlite";
            string folderPath = Windows.Storage.ApplicationData.Current.LocalFolder.Path;
            string fullPath = System.IO.Path.Combine(folderPath, dbName);
            LoadApplication(new ExpensesApp.App(fullPath));
        }
    }
}
