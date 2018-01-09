using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MuscleTrainingRecords00
{
    public class TrainingLogPageCS : ContentPage //contentviewで作った view→contentPage
    {
        public TrainingLogPageCS()
        {
            Title = "トレーニング履歴";
            Content = new StackLayout
            {
                Children = {
                    new Label {
                        Text = "Welcome to LogPage!",
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                    },
                }
            };
        }
    }
}
