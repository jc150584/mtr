 using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using Xamarin.Forms;
using MuscleTrainingRecords;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Collections;

namespace MuscleTrainingRecords00
{
    class LineChart
    {
        public PlotModel Model { get; private set; }

        public LineChart()
        {
            DataPoint[] BWeightList = getItemList();

            this.Model = new PlotModel { Title = "" };

            /* var BweightLine = new LineSeries() { Title = "体重",MarkerType = MarkerType.Circle };
             BweightLine.Color = OxyColors.Red;
             BweightLine.MarkerType = MarkerType.Circle;*/

            var BweightLine = new LineSeries
            {
                StrokeThickness = 1,

                MarkerType = MarkerType.Circle,

                MarkerStroke = OxyColors.Blue,

                MarkerFill = OxyColors.SkyBlue,

                DataFieldX = "Date",

                DataFieldY = "Value",

            };
            foreach (DataPoint dp in BWeightList)
            {
                BweightLine.Points.Add(dp);
                BweightLine.MarkerType = MarkerType.Circle;
            }
            /*foreach (DataPoint dp in itemList)
            {
                Y_line.Points.Add(dp);

            }*/

           // Model.Series.Add(Y_line);
            Model.Series.Add(BweightLine);

            DataPoint[] BFattList = getBFatList();

            /*var BFatLine = new LineSeries() { Title = "体脂肪" };
            BFatLine.Color = OxyColors.Blue;
            BFatLine.MarkerType = MarkerType.Circle;*/

            var BfatLine = new LineSeries
            {
                StrokeThickness = 1,

                MarkerType = MarkerType.Circle,

                MarkerStroke = OxyColors.Red,

                MarkerFill = OxyColors.SkyBlue,

                DataFieldX = "Date",

                DataFieldY = "Value",

            };

            foreach (DataPoint dp in BFattList)
            {
                BfatLine.Points.Add(dp);
               

            }
            /*foreach (DataPoint dp in itemList)
            {
                Y_line.Points.Add(dp);

            }*/

            // Model.Series.Add(Y_line);
            Model.Series.Add(BFatLine);


            var axisY = new LinearAxis() //横
            {
                Title = "体重(kg)",
                IsZoomEnabled = false,
                Position = AxisPosition.Left,
                Maximum = 150,
                Minimum = 50,
                MajorStep = 10,
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.Dot,
                ExtraGridlines = new double[] { 1, 2, 3, 8, 9, 10 },
                ExtraGridlineThickness = 3,
                ExtraGridlineColor = OxyColors.SkyBlue,
                
                



            };
            Model.Axes.Add(axisY);

            
           

          /* 日付　 var axisX = new DateTimeAxis()
            {
                Title = "日付",
                Position = AxisPosition.Bottom,
             
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.Dot,
            };
            Model.Axes.Add(axisX);*/

        }

        private static DataPoint[] getItemList()
        {
            TodoItemDatabase itemDataBase = TodoItemDatabase.getDatabase();
            Task<List<TodoItem>> taskItemList = itemDataBase.GetItemsAsync();
            List<TodoItem> itemList = taskItemList.Result;
            DataPoint[] points = new DataPoint[itemList.Count];
           
            int i = 0;
            foreach (TodoItem item in itemList)
            {
                points[i++] = new DataPoint(item.ID, item.Bweight);
            }
            return points;
        }
        private static DataPoint[] getBFatList()
        {
            TodoItemDatabase itemDataBase = TodoItemDatabase.getDatabase();
            Task<List<TodoItem>> taskItemList = itemDataBase.GetItemsAsync();
            List<TodoItem> itemList = taskItemList.Result;
            DataPoint[] points = new DataPoint[itemList.Count];
            
            int i = 0;
            foreach (TodoItem item in itemList)
            {
                points[i++] = new DataPoint(item.ID, item.Bfat);
            }
            return points;
        }
    }
}