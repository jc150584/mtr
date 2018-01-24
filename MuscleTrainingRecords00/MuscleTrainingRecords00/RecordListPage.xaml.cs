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
    public partial class RecordListPage : ContentPage
    {
        private string test;

        public RecordListPage()
        {
            InitializeComponent();

            list.ItemsSource = RecordsModel.SelectRe().ToString();

          
           
        }

        private void RecordListButton(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MenuPage());
            
        }

        /*private void Records1_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            string i = test;
           Navigation.PushAsync(new RecordPage(i));
        }*/

        /* private void insertButtonClicked(object sender, EventArgs e)
         {
             Navigation.PushAsync(new RecordPage());
         }
         */

        /* private async void OnRefreshing(object sender , EventArgs e)
         {
             await Task.Delay(1000);
             list.IsRefreshing = false;
             InitializeComponent();
         }
         */

    }
}