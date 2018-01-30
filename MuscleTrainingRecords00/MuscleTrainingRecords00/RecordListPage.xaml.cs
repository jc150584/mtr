using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MuscleTrainingRecords00;
using System.Windows.Input;

namespace MuscleTrainingRecords00
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecordListPage : ContentPage
    {

        public RecordListPage()
        {
            InitializeComponent();

           
        }


        //引っ張ったとき（更新）
        private async void OnRefreshing(object sender, EventArgs e)
        {
            // 1秒処理を待つ
            await Task.Delay(1000);

            //リフレッシュを止める
            list.IsRefreshing = false;

            InitializeComponent();

        }

        
        

        private void RecordListButton(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MenuPage());
            
        }

        private void list_ItemTapped(object sender, ItemTappedEventArgs e)
        {
           RecordsModel record = (RecordsModel)list.SelectedItem;

            string l = record.m_name;

            Navigation.PushAsync(new RecordPage(l));

            //Navigation.PushAsync(new RecordPage());
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