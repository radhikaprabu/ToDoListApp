using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Windows.Storage;
using Xamarin.Forms;
using ToDoListApp.WinPhone;


[assembly: Dependency(typeof(FileHelper_WinPhone))]

namespace ToDoListApp.WinPhone
{
    public class FileHelper_WinPhone : FileHelper
    {
        public string GetLocalFilePath(string filename)
        {
            return Path.Combine(ApplicationData.Current.LocalFolder.Path, filename);
        }
    }
}
