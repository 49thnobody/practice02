using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }

        private void SetNumerics()
        {
            numericUpDownMinTemperature.Minimum = DataController.MinTemperature;
            numericUpDownMinTemperature.Maximum = DataController.MaxTemperature - 1;
            numericUpDownMaxTemperature.Minimum = DataController.MinTemperature + 1;
            numericUpDownMaxTemperature.Maximum = DataController.MaxTemperature;
            numericUpDownMinTemperature.Value=numericUpDownMinTemperature.Minimum;
            numericUpDownMaxTemperature.Value=numericUpDownMaxTemperature.Maximum;

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
        }

        private void buttonGeneratePressure_Click(object sender, EventArgs e)
        {
            _pressureData.Generate((int)numericUpDownMinPressure.Value,
                                   (int)numericUpDownMaxPressure.Value);
        }

        private void buttonGenerateHumidity_Click(object sender, EventArgs e)
        {
            _humidityData.Generate((int)numericUpDownMinHumidity.Value,
                                   (int)numericUpDownMaxHumidity.Value);
        }

        private void buttonAddTemperature_Click(object sender, EventArgs e)
        {
            try
            {
                double value = Convert.ToDouble(textBoxAddTemperature.Text);

                _temperatureData.Add(Math.Round(value, 3));
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
            }
        }

        private void buttonResetTemperature_Click(object sender, EventArgs e)
        {
            _temperatureData.Clear();
        }

        private void buttonResetPressure_Click(object sender, EventArgs e)
        {
            _pressureData.Clear();
        }

        private void buttonResetHumidity_Click(object sender, EventArgs e)
        {
            _humidityData.Clear();
        }
    }
}
