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
    public partial class RecordPage : ContentPage
    {
        DateTime yyyymmdd;

        public RecordPage()
        {
            InitializeComponent();
        }

   

        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            yyyymmdd = new DateTime(DatePicker.Date.Year, DatePicker.Date.Month, DatePicker.Date.Day);


        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            RecordsModel.InsertRecords(Weight.Text, Leg.Text, Set.Text, yyyymmdd);//試し

            DisplayAlert("", "保存されました", "OK");

            Navigation.PushAsync(new RecordListPage());
        }
    }
}
