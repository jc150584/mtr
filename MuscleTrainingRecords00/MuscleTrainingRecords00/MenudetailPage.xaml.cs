using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MuscleTrainingRecords00
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenudetaliPage : ContentPage
    {
        string t;
        public MenudetaliPage(String m, String d, String i)//String m
        {
            InitializeComponent();


            Transition.Text = m.Trim();

            Description.Text = d;

            image.Source = i;

            t = m;
        }

        private void addItemButton_Clicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new RecordListPage(t));

        }

        /*public MenudetaliPage(String l)
        {
        this.l = l;
        }*/
    }
}