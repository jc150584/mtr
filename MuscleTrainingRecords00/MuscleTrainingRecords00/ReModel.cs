using System;
using System.Collections.ObjectModel;
using SQLite;
namespace MuscleTrainingRecords00
{
    class ReModel
    {
        public ObservableCollection<Record> Records
        {
            get;
            private set;
        }

        public ReModel()
        {


            if (RecordsModel.SelectRecords() != null)
            {
                var query = RecordsModel.SelectRecords();
                Records = new ObservableCollection<Record>();

                foreach (var record in query)//拡張forループ
                {
                    Record r = new Record
                    {
                        M_no = record.M_no,
                        M_name = record.M_name,
                        M_weight = record.M_weight,
                        M_leg = record.M_leg,
                        M_set = record.M_set,
                        M_date = record.M_date
                    };
                    //一行ずつ追加
                    Records.Add(r);
                }
            }

            /*if(RecoedsModel.SelectRecords() == M_no)
            {

            }*/

            else
            {
                Records = new ObservableCollection<Record>
           {
               new Record
               {
                   M_name = "データなし"
               }
           };
            }
        }



        public class Record
        {
            public int M_no { get; set; } //筋トレNo 主キー

            public string M_name { get; set; } //筋トレ名前

            public int M_weight { get; set; } //重量

            public int M_leg { get; set; } //回数

            public int M_set { get; set; } //セット数

            public DateTime M_date { get; set; } //日付

        }
    }
}