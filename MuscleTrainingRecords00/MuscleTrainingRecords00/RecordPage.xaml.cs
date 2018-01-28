using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MuscleTrainingRecords00;

namespace MuscleTrainingRecords00
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecordPage : ContentPage
    {
        DateTime yyyymmdd;

        string t;
        public RecordPage()//string l
        {
            InitializeComponent();

            //t = l;
            
        }


        public void Insert_Clicked(object sender, EventArgs e)
        {

            int WeightText = int.Parse(Weight.Text);
            int LegText = int.Parse(Leg.Text);
            int SetText = int.Parse(Set.Text);


            DateTime now = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);


            //RecordsModel.InsertRecords(Weight.Text, Leg.Text, Set.Text, yyyymmdd);//試し
            //RecordsModel.InsertRe(1, t ,WeightText, LegText, SetText, now);

            //DisplayAlert("", t +""+ WeightText + ""+LegText+""+SetText, "OK");

            //Navigation.PushAsync(new RecordListPage());
        }
        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
           ;


        }

        private void addItemButton_Clicked(object sender, EventArgs e)
        {

            if(KG.Text == null || Reps.Text == null || Set.Text == null)
            {
                DisplayAlert("", "入力が不足しています", "OK");
            }
        }
    }
}