using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MuscleTrainingRecords00
{
    /*[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPageCS : ContentPage
    {
        public MenuPageCS()
        {
            Title = "メニュー一覧";
            Content = new StackLayout
            {
                Children = {
                     new Label {
                         Text = "Welcome to MenuPage!",
                         HorizontalOptions = LayoutOptions.Center,
                         VerticalOptions = LayoutOptions.CenterAndExpand
                     },
                 }
            };
        }
    }*/


    public class MenuPageCS
    {
        public string Menu { get; set; }
        public string Load { get; set; }

        public override string ToString()
        {
            return Menu + Load;
        }
    }
}