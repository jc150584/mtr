using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MuscleTrainingRecords00
{
    public class RecordListPageCS : ContentPage //contentviewで作った view→contentPage
    {
        public RecordListPageCS()
        {

            Title = "記録";
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Welcome to RecordListPage!" ,
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.CenterAndExpand
                    },
                }
            };
        }
    }
}
