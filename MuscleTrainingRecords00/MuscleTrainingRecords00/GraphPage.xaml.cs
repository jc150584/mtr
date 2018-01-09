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
    public partial class GraphPage : ContentPage
    {


        public GraphPage()
        {
            InitializeComponent();
        }


        /********************ここから追加******************************************/

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            var db = TodoItemDatabase.getDatabase();
            //String sName = eName.Text;
            //String sNotes = eNotes.Text;
            //Boolean bDone = eDone.IsToggled;
            int B_Weight = int.Parse(bWeight.Text);
            int B_Fat = int.Parse(bFat.Text);
            DateTime dCreated = eCreated.Date;

            TodoItem item = new TodoItem() { Bweight = B_Weight, Created = dCreated, Bfat = B_Fat };
            db.SaveItemAsync(item);
            DisplayAlert("TodoItem", "追加されたよ", "OK");
            Application.Current.MainPage = new MainPage();
        }
    }
}