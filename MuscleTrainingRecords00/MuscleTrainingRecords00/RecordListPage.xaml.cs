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
        public RecordListPage()
        {
            InitializeComponent();
            /*var layout = new StackLayout { HorizontalOptions = LayoutOptions.Center, Margin = new Thickness { Top = 100 } };
            //Userテーブルに適当なデータを追加
            MuscleMenuModelCS.insertUser("鈴木");
            MuscleMenuModelCS.insertUser("田中");
            MuscleMenuModelCS.insertUser("斎藤");
            //Userテーブルの行データを取得
            var query = MuscleMenuModelCS.selectUser();
            foreach (var Memo in query)
            {
                //Userテーブルの名前列をLabelに書き出します
                layout.Children.Add(new Label { Text = Memo.Name });
            }
            Content = layout;
        }*/
            
                /*var layout = new StackLayout {VerticalOptions = LayoutOptions.Center, Margin = new Thickness { Top = 100 } };
                var record = RecordsModel.SelectRecords();
            if(record != null) { 

                foreach (var Memo in record)
                {
                    layout.Children.Add(new Label { Text = Memo.M_date.ToString("yyyy/MM/dd") , HorizontalOptions = LayoutOptions.Start});
                    layout.Children.Add(new Label { Text = Memo.M_weight.ToString(), HorizontalOptions = LayoutOptions.Start });
                    layout.Children.Add(new Label { Text = Memo.M_set.ToString(),  HorizontalOptions = LayoutOptions.Start });
                    layout.Children.Add(new Label { Text = Memo.M_leg.ToString(),  HorizontalOptions = LayoutOptions.Start });
                    
                    

                }
                
                
            }
            
            var insertButton = new Button
            {
                HorizontalOptions=LayoutOptions.EndAndExpand,
                VerticalOptions = LayoutOptions.EndAndExpand,
                Text = "メニュー追加",
                BackgroundColor = Color.LightSkyBlue,
                TextColor = Color.Snow,
                FontSize = 30,
                
                
            };
            var RefreshingButton = new Button
            {
                HorizontalOptions = LayoutOptions.EndAndExpand,
                VerticalOptions = LayoutOptions.EndAndExpand,
                Text = "更新",
                BackgroundColor = Color.LightSkyBlue,
                TextColor = Color.Snow,
                FontSize = 30,
            };
            insertButton.Clicked += insertButtonClicked;
            layout.Children.Add(insertButton);
            RefreshingButton.Clicked += RefreshingButtonClicked;
            layout.Children.Add(RefreshingButton);

            Content = layout;*/

        }


        
        private void RecordListButton(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MenuPage());
        }

       /* private void insertButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RecordPage());

        }
        */

        private async void RefreshingButtonClicked(object sender , EventArgs e)
        {
            await Task.Delay(1000);
            list.IsRefreshing = false;

            InitializeComponent();

            
            
        }





    }
}