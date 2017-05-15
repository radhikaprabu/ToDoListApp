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
            var nav = new NavigationPage(new ToDoListPage());
            
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
