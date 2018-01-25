using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

public class ReModel
{
    public ObservableCollection<Record> Records
    {
        get;
        private set;
    }

    public ReModel()
    {
        //今日の日付
        DateTime now = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

        if (RecordsModel.SelectRecords()!= null)
        {
            var query = RecordsModel.SelectRecords();
            Records = new ObservableCollection<Record>();

            foreach(var record in query)//拡張forループ
            {
                Record r = new Record
                {
                    M_no = m_no,
                    M_name = m_name,
                    M_weight = m_weight,
                    M_leg = m_leg,
                    M_set = m_set,
                    M_date = m_date
                };
                //一行ずつ追加
                Records.Add(r);
            }
        }

        else
        {
            Records = new ObservableCollection<Record>
           {
               new Record
               {
                   M_name = "データなし",
                   M_weight = 0,
                   M_leg = 0,
                   M_set = 0,
                   M_date = now
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

