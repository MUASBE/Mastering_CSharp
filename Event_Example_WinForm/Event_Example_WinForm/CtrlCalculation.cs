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
    public partial class CtrlCalculation : UserControl
    {

        public event EventHandler<CalculationEventArgs> CalculationPerformed;

        public virtual void OnCalculationPerformed(int value1, int value2, int result)
        {
            OnCalculationPerformed(new CalculationEventArgs(value1, value2, result));
        }

        public virtual void OnCalculationPerformed(CalculationEventArgs e)
        {
            CalculationPerformed(this, e);
        }

        public CtrlCalculation()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int value1 = int.Parse(txtVal1.Text);
            int value2 = int.Parse(txtVal2.Text);

            int result = value1 + value2;

            lblResult.Text = result.ToString();


            if(CalculationPerformed != null)
                OnCalculationPerformed(value1, value2, result);


        }
    }

    public class CalculationEventArgs : EventArgs
    {
        public int Value1 { get;}
        public int Value2 { get;}
        public int Result { get;}

        public CalculationEventArgs(int value1, int value2, int result)
        {
            Value1 = value1;
            Value2 = value2;
            Result = result;
        }
    }

}
