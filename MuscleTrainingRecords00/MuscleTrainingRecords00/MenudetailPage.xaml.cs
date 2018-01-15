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
        public MenudetaliPage(String l, String m)//String m
        {
            InitializeComponent();


            Transition.Text = l.Trim();

            Description.Text = m;

            t = l;
        }

        private void addItemButton_Clicked(object sender, EventArgs e)
        {
            String i = t;
            Navigation.PushAsync(new RecordListPage(i));

        }

        /*public MenudetaliPage(String l)
        {
        this.l = l;
        }*/
    }
}