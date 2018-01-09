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
            DataPoint[] itemList = getItemList();

            this.Model = new PlotModel { Title = "" };

            var X_line = new LineSeries() { Title = "体重" };
            X_line.Color = OxyColors.Red;

            var Y_line = new LineSeries() { Title = "体脂肪" };
            Y_line.Color = OxyColors.Blue;

            foreach (DataPoint dp in itemList)
            {
                X_line.Points.Add(dp);

            }
            foreach (DataPoint dp in itemList)
            {
                Y_line.Points.Add(dp);

            }

            X_line.Points.Add(new DataPoint(3, 3));
            Model.Series.Add(Y_line);
            Model.Series.Add(X_line);

            var axisY = new LinearAxis() //横
            {

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
    }
}