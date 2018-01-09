using System;
using System.Collections.Generic;
using System.Text;
using MuscleTrainingRecords00.iOS;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(FileHelper))]

namespace MuscleTrainingRecords00.iOS
{
    // https://developer.xamarin.com/guides/xamarin-forms/application-fundamentals/databases/

    public class FileHelper : IFileHelper
    {
        public string GetLocalFilePath(string filename)
        {
            string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libFolder = Path.Combine(docFolder, "..", "Library", "Databases");

            if (!Directory.Exists(libFolder))
            {
                Directory.CreateDirectory(libFolder);
            }

            return Path.Combine(libFolder, filename);
        }
    }
}