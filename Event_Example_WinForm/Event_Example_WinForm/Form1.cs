using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_Example_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ctrlCalculation1_CalculationPerformed(object sender, CalculationEventArgs e)
        {
            MessageBox.Show($"Calculation performed: {e.Value1} + {e.Value2} = {e.Result}");
        }
    }
}
