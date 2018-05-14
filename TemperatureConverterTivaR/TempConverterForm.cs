using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Created by: Tiva Rait
 * Created on: 14-05-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #27 - Pass by Value
 * This program converts a temperature in celsius to the equivalent in fahrenheit
*/

namespace TemperatureConverterTivaR
{
    public partial class frmTempConverter : Form
    {
        public frmTempConverter()
        {
            InitializeComponent();
        }

        // Function ConvertTemperature 
        // Input: 
        // Output: void
        // Description: This function converts celsius to fahrenheit
        public void ConvertTemperature (double celsius)
        {
            // Declare local variables
            double fahrenheit;

            fahrenheit = ((double)9/(double)5 * celsius + 32);

            // Display message box with answer
            MessageBox.Show(celsius + " degrees Celsius = " + fahrenheit + " degrees Fahrenheit", "Celsius to Fahrenheit Converter");
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            // Declare local variables
            double usercelsius;

            // Get the users temperature from the text box
            usercelsius = Convert.ToDouble(this.txtTemperature.Text);

            // Call the function
            this.ConvertTemperature(usercelsius);
        }
    }
}
