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
        public MenudetaliPage(String l, String m)//String m
        {
            InitializeComponent();


            Transition.Text = l.Trim();

            Description.Text = m;
        }

        private void addItemButton_Clicked(object sender, EventArgs e)
        {
            /*string i = Transition.Text;
            Navigation.PushAsync(new RecordListPage(i));*/

        }

        /*public MenudetaliPage(String l)
        {
        this.l = l;
        }*/
    }
}