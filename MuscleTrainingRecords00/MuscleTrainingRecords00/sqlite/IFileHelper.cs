using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuscleTrainingRecords00
{
    // https://developer.xamarin.com/guides/xamarin-forms/application-fundamentals/databases/
    public interface IFileHelper
    {
        string GetLocalFilePath(string filename);
    }
}