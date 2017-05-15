using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Xamarin.Forms;
using ToDoListApp.Droid;



[assembly: Dependency(typeof(FileHelper_Android))]
namespace ToDoListApp.Droid
{
    public class FileHelper_Android : FileHelper
    {
        public string GetLocalFilePath(string filename)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return Path.Combine(path, filename);
        }

    }
}