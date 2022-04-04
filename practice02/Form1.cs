using System;
using System.Windows.Forms;

namespace practice02
{
    public partial class Form1 : Form
    {
        private static Data _temperatureData;
        private static Data _pressureData;
        private static Data _humidityData;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _temperatureData = new Data(listBoxTemperature, chartTemperature, 0, DataType.Temperature);
            _pressureData = new Data(listBoxPressure, chartPressure, 0, DataType.Pressure);
            _humidityData = new Data(listBoxHumidity, chartHumidity, 0, DataType.Humidity);
            SetNumerics();

            SetTemperature();
            SetPressure();
            SetHumidity();
        }

        private void SetHumidity()
        {
            textBoxAvarageHumidity.Text = _humidityData.Count == 0 ? "Нет данных" : _humidityData.Average.ToString();
            textBoxPrognosisHumidity.Text = _humidityData.Count == 0 ? "Нет данных" : _humidityData.Prognosis.ToString();
        }

        private void SetPressure()
        {
            textBoxAvaragePressure.Text = _pressureData.Count == 0 ? "Нет данных" : _pressureData.Average.ToString();
            textBoxPrognosisPressure.Text = _pressureData.Count == 0 ? "Нет данных" : _pressureData.Prognosis.ToString();
        }

        private void SetTemperature()
        {
            textBoxAvarageaTemperature.Text = _temperatureData.Count == 0 ? "Нет данных" : _temperatureData.Average.ToString();
            textBoxPrognosisTemperature.Text = _temperatureData.Count == 0 ? "Нет данных" : _temperatureData.Prognosis.ToString();
        }

        private void SetNumerics()
        {
            numericUpDownMinTemperature.Minimum = DataController.MinTemperature;
            numericUpDownMinTemperature.Maximum = DataController.MaxTemperature - 1;
            numericUpDownMaxTemperature.Minimum = DataController.MinTemperature + 1;
            numericUpDownMaxTemperature.Maximum = DataController.MaxTemperature;
            numericUpDownMinTemperature.Value = numericUpDownMinTemperature.Minimum;
            numericUpDownMaxTemperature.Value = numericUpDownMaxTemperature.Maximum;

            numericUpDownMinPressure.Minimum = DataController.MinPressure;
            numericUpDownMinPressure.Maximum = DataController.MaxPressure - 1;
            numericUpDownMaxPressure.Minimum = DataController.MinPressure + 1;
            numericUpDownMaxPressure.Maximum = DataController.MaxPressure;
            numericUpDownMinPressure.Value = numericUpDownMinPressure.Minimum;
            numericUpDownMaxPressure.Value = numericUpDownMaxPressure.Maximum;

            numericUpDownMinHumidity.Minimum = DataController.MinHumidity;
            numericUpDownMinHumidity.Maximum = DataController.MaxHumidity - 1;
            numericUpDownMaxHumidity.Minimum = DataController.MinHumidity + 1;
            numericUpDownMaxHumidity.Maximum = DataController.MaxHumidity;
            numericUpDownMinHumidity.Value = numericUpDownMinHumidity.Minimum;
            numericUpDownMaxHumidity.Value = numericUpDownMaxHumidity.Maximum;
        }

        private void buttonGenerateTemperature_Click(object sender, EventArgs e)
        {
            _temperatureData.Generate((int)numericUpDownMinTemperature.Value,
                                      (int)numericUpDownMaxTemperature.Value);
            SetTemperature();
        }

        private void buttonGeneratePressure_Click(object sender, EventArgs e)
        {
            _pressureData.Generate((int)numericUpDownMinPressure.Value,
                                   (int)numericUpDownMaxPressure.Value);
            SetPressure();
        }

        private void buttonGenerateHumidity_Click(object sender, EventArgs e)
        {
            _humidityData.Generate((int)numericUpDownMinHumidity.Value,
                                   (int)numericUpDownMaxHumidity.Value);
            SetHumidity();
        }

        private void buttonAddTemperature_Click(object sender, EventArgs e)
        {
            try
            {
                double value = Convert.ToDouble(textBoxAddTemperature.Text);

                _temperatureData.Add(Math.Round(value, 3));
                SetTemperature();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAddPressure_Click(object sender, EventArgs e)
        {
            try
            {
                double value = Convert.ToDouble(textBoxAddPressure.Text);

                _pressureData.Add(Math.Round(value, 3));
                SetPressure();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAddHumidity_Click(object sender, EventArgs e)
        {
            try
            {
                double value = Convert.ToDouble(textBoxAddHumidity.Text);

                _humidityData.Add(Math.Round(value, 3));
                SetHumidity();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDeleteTemperature_Click(object sender, EventArgs e)
        {
            if (listBoxTemperature.SelectedIndex == -1)
            {
                MessageBox.Show("Значение н выбрано.");
            }
            else
            {
                _temperatureData.RemoveAt(listBoxTemperature.SelectedIndex);

                SetTemperature();
            }
        }

        private void buttonDeletePressure_Click(object sender, EventArgs e)
        {
            if (listBoxPressure.SelectedIndex == -1)
            {
                MessageBox.Show("Значение н выбрано.");
            }
            else
            {
                _pressureData.RemoveAt(listBoxTemperature.SelectedIndex);
                SetPressure();
            }
        }

        private void buttonDeleteHumidity_Click(object sender, EventArgs e)
        {
            if (listBoxHumidity.SelectedIndex == -1)
            {
                MessageBox.Show("Значение н выбрано.");
            }
            else
            {
                _humidityData.RemoveAt(listBoxTemperature.SelectedIndex);
                SetHumidity();
            }
        }

        private void buttonResetTemperature_Click(object sender, EventArgs e)
        {
            _temperatureData.Clear();

            SetTemperature();
        }

        private void buttonResetPressure_Click(object sender, EventArgs e)
        {
            _pressureData.Clear();
            SetPressure();
        }

        private void buttonResetHumidity_Click(object sender, EventArgs e)
        {
            _humidityData.Clear();
            SetHumidity();
        }
    }
}
