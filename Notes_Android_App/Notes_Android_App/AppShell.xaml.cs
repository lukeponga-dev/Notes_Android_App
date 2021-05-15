using Notes_Android_App.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Notes_Android_App
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(NoteEntryPage), typeof(NoteEntryPage));
        }
    }

}

