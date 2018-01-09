using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MuscleTrainingRecords00
{
    public class RMPageCS : ContentPage
    {
        public RMPageCS()
        {
            Title = "RM計算";
            Content = new StackLayout
            {
                Children = {
                    new Label {
                        Text = "Welcome to RMPage!",
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                    }
                }
            };
        }
    }
}