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
        private List<Drink> drinks = new List<Drink>();
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            switch (DrinkOption.Text)
            {
                case "Beer":
                    int percent=-1;
                    try
                    {
                        percent = int.Parse(txtOther.Text);
                        
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Please enter only a number into the Alcohol Percent field.");
                    }
                    finally
                    {
                        drinks.Add(new Beer(txtName.Text, chkCarbonated.Checked, percent));
                    }                    
                    break;
                case "Juice":
                    drinks.Add(new Juice(txtName.Text, chkCarbonated.Checked, txtOther.Text));
                    break;
                case "Soda":
                    drinks.Add(new Soda(txtName.Text, chkCarbonated.Checked));
                    break;
                default:
                    drinks.Add(new Drink(txtName.Text, chkCarbonated.Checked));
                    break;
            }
            listDrinks.Items.Clear();
            foreach(Drink d in drinks)
            {
                listDrinks.Items.Add(d.Description);
            }
        }
    }
}
