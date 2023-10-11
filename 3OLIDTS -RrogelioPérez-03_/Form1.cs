using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3OLIDTS__RrogelioPérez_03_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCelsius_Click(object sender, EventArgs e)
        {
            float.TryParse(txtFahrenheit.Text, out float fahrenheit);
            
            float celsius = (fahrenheit - 32) * 5.0f / 9.0f;
            txtCelsius.Clear();
            txtCelsius.Text = celsius.ToString("0.00");
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            txtFahrenheit.Text = "0.00";
            txtCelsius.Text = "0.00";
        }

        private void btnFarenheit_Click(object sender, EventArgs e)
        {
            float.TryParse(txtCelsius.Text, out float celsius);

            float fahrenheit = (celsius * 5.0f / 9.0f) + 32 ;
            txtFahrenheit.Clear();
            txtFahrenheit.Text = fahrenheit.ToString("0.00");
        }
    }
}
