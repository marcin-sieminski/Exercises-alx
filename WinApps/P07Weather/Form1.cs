using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P07Weather
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            lbPlaces.DataSource = File.ReadAllLines("names.txt");
        }

        private void lbPlaces_SelectedIndexChanged(object sender, EventArgs e)
        {
            labName.Text = lbPlaces.SelectedItem.ToString();
            var weathermanager = new WeatherManager();
            weathermanager.CityName = lbPlaces.SelectedItem.ToString();
            labWeatherInfo.Text = weathermanager.GetWeather()  + "°";
        }
    }
}
