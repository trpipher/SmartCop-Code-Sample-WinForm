using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCop_Code_Sample_WinForm
{
    public partial class Form1 : Form
    {
        private RadioButton DrinkOption;
        public Form1()
        {
            InitializeComponent();
     
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton opt = sender as RadioButton;
            if (opt.Checked)
            {
                DrinkOption = opt;
                if (opt.Text == "Beer")
                {
                    lblExtra.Visible = true;
                    txtOther.Visible = true;
                    lblExtra.Text = "Alcohol Percentage";
                }
                else if (opt.Text == "Juice")
                {
                    lblExtra.Visible = true;
                    txtOther.Visible = true;
                    lblExtra.Text = "Fruit";
                }
                else
                {
                    lblExtra.Visible = false;
                    txtOther.Visible = false;

                }
                
            }
        }
    }
}
