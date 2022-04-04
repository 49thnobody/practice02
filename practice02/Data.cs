using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace practice02
{
    internal static class DataController
    {
        public static int MinTemperature = -30;
        public static int MaxTemperature = 30;
        public static int MinPressure = 641;
        public static int MaxPressure = 815;
        public static int MinHumidity = 30;
        public static int MaxHumidity = 60;

        private static Random _random = new Random();

        private static List<double> GetData(int min, int max)
        {
            var result = new List<double>();

            int range = Math.Abs(min - max);
            double normalDeviation = (double)range / 100 * 10; // ожидаемое отклонение - не больше 10% 

            for (int i = 0; i < 30; i++)
            {
                double value = _random.Next(min, max - 1) + _random.NextDouble();

                if (i == 0)
                {
                    result.Add(Math.Round(value, 3));
                    continue;
                }

                while (Math.Abs(result[i - 1] - value) > normalDeviation)
                {
                    value = _random.Next(min, max - 1) + _random.NextDouble();
                }

                result.Add(Math.Round(value, 3));
            }

            return result;
        }

        public static List<double> GetTemperatureData() => GetData(MinTemperature, MaxTemperature);
        public static List<double> GetTemperatureData(int min, int max) => GetData(min, max);

        public static List<double> GetPressureData() => GetData(MinPressure, MaxPressure);
        public static List<double> GetPressureData(int min, int max) => GetData(min, max);

        public static List<double> GetHumidityData() => GetData(MinHumidity, MaxHumidity);
        public static List<double> GetHumidityData(int min, int max) => GetData(min, max);
    }

    public struct Data
    {
        public Data(List<double> values)
        {
            _values = values;

            _listBox = new ListBox();
            _chart = new Chart();
            _myIndex = 0;
            _dataType = DataType.Temperature;
        }

        public Data(ListBox listBox, Chart chart, int myIndex, DataType dataType)
        {
            _listBox = listBox;
            _chart = chart;
            _myIndex = myIndex;
            _dataType = dataType;

            _values = null;
            Generate();
        }

        private ListBox _listBox;
        private Chart _chart;
        private int _myIndex;

        private DataType _dataType;
        private List<double> _values;
        public int Count => _values.Count;

        public double Average => Math.Round(_values.Average(), 3);

        private double _deviation => Math.Abs(Average / 100 * 10);

        public double Prognosis
        {
            get
            {
                Random random = new Random();
                double result = Average + random.Next(-(int)_deviation, (int)_deviation) + random.NextDouble();

                while (result < _values.Min() || result > _values.Max())
                {
                    result = Average + random.Next(-(int)_deviation, (int)_deviation - 1) + random.NextDouble();
                }

                return Math.Round(result, 3);
            }
        }

        public void Generate()
        {
            Clear();

            switch (_dataType)
            {
                case DataType.Temperature:
                    _values = DataController.GetTemperatureData();
                    break;
                case DataType.Pressure:
                    _values = DataController.GetPressureData();
                    break;
                case DataType.Humidity:
                    _values = DataController.GetHumidityData();
                    break;
                default:
                    break;
            }

            UpdateChart();
        }

        public void Generate(int min, int max)
        {
            Clear();

            switch (_dataType)
            {
                case DataType.Temperature:
                    _values = DataController.GetTemperatureData(min, max);
                    break;
                case DataType.Pressure:
                    _values = DataController.GetPressureData(min, max);
                    break;
                case DataType.Humidity:
                    _values = DataController.GetHumidityData(min, max);
                    break;
                default:
                    break;
            }

            UpdateChart();
        }

        private void UpdateChart()
        {
            for (int i = 0; i < _values.Count; i++)
            {
                _listBox.Items.Add(_values[i]);
                _chart.Series[_myIndex].Points.AddXY(i + 1, _values[i]);
            }
        }

        public void Clear()
        {
            _values = new List<double>();
            _listBox.Items.Clear();
            _chart.Series[_myIndex].Points.Clear();
        }

        public void Add(double value)
        {
            _values.Add(value);
            _listBox.Items.Add(value);
            _chart.Series[_myIndex].Points.AddXY(_values.Count, value);
        }

        public void RemoveAt(int index)
        {
            if (_values.Count == 0) return;
            if (index < 0 || index >= _values.Count) return;

            _values.RemoveAt(index);
            _listBox.Items.RemoveAt(index);
            _chart.Series[_myIndex].Points.RemoveAt(index);
        }
    }

    public enum DataType
    {
        Temperature,
        Pressure,
        Humidity
    }
}
