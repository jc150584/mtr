 using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using Xamarin.Forms;
using MuscleTrainingRecords;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Collections;
using System;

namespace MuscleTrainingRecords00
{
    class LineChart
    {
        public PlotModel Model { get; private set; }

        public LineChart()
        {
            
            DataPoint[] BWeightList = getItemList();

            this.Model = new PlotModel { Title = "" };




            var BweightLine = new LineSeries
            {
                Title = "体重",
                StrokeThickness = 1,

                MarkerType = MarkerType.Circle,

                MarkerStroke = OxyColors.Blue,

                MarkerFill = OxyColors.SkyBlue,

                DataFieldX = "Date",

                DataFieldY = "Value",

                LineStyle = LineStyle.Automatic,
                

               

            };
            BweightLine.Color = OxyColors.Red;

            foreach (DataPoint dp in BWeightList)
            {
                BweightLine.Points.Add(dp);
                BweightLine.MarkerType = MarkerType.Circle;
            }
       
            Model.Series.Add(BweightLine);

            DataPoint[] BFattList = getBFatList();


            var BfatLine = new LineSeries
            {
                Title = "体脂肪率",
                StrokeThickness = 1,

                MarkerType = MarkerType.Circle, 

                MarkerStroke = OxyColors.GreenYellow,

                MarkerFill = OxyColors.SkyBlue,

                DataFieldX = "Date",

                DataFieldY = "Value",

                LineStyle = LineStyle.Automatic,

            };

            BfatLine.Color = OxyColors.Blue;

            foreach (DataPoint dp in BFattList)
            {
                BfatLine.Points.Add(dp);
               

            }
           
            Model.Series.Add(BfatLine);


            var axisY = new LinearAxis() //縦
            {
                Title = "体重(kg)　体脂肪率(%)",
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

            

            var startDate = DateTime.Now.AddDays(-10);
            var endDate = DateTime.Now;

            var minValue = DateTimeAxis.ToDouble(startDate);
            var maxValue = DateTimeAxis.ToDouble(endDate);

            Model.Axes.Add(new DateTimeAxis { Position = AxisPosition.Bottom, Minimum = minValue, Maximum = maxValue, StringFormat = "M/d" });






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
            foreach ( TodoItem item in itemList)
            {
                points[i++] = new DataPoint(item.ID, item.Bfat);
            }
            return points;
        }
    }
}