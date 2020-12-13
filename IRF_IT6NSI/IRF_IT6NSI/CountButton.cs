using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_IT6NSI
{
    public class CountButton : Button
    {
        private int privvalue;
        public int Value
        {
            get { return privvalue; }
            set
            { 
                privvalue = value;
                if ((privvalue >= 5) || (privvalue<1))
                {
                    Text = privvalue.ToString() + " !";
                    BackColor = Color.Red;
                }
                else
                {
                    Text = privvalue.ToString();
                    BackColor = Color.Green;
                }
            }
        }
        public CountButton()
        {
            Height = 50;
            Width = Height;
            BackColor = Color.White;
            Value = 0;
            Enabled = false;
        }
    }
}
