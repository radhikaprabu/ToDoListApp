using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ToDoListApp
{
    public class App : Application
    {
        static ToDoItemDatabase database;

        public App()
        {
            //Resources = new ResourceDictionary();
            //Resources.Add("primaryGreen", Color.FromHex("91CA47"));
            //Resources.Add("primaryDarkGreen", Color.FromHex("6FA22E"));

            var nav = new NavigationPage(new ToDoListPage());
            //nav.BarBackgroundColor = (Color)App.Current.Resources["primaryGreen"];
            //nav.BarTextColor = Color.White;

            MainPage = nav;
        }

        public static ToDoItemDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new ToDoItemDatabase(DependencyService.Get<FileHelper>().GetLocalFilePath("TodoSQLite.db3"));
                }
                return database;
            }
        }

        public int ResumeAtTodoId { get; set; }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
