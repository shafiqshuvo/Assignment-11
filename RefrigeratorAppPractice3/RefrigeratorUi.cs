using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefrigeratorAppPractice3
{
    public partial class RefrigeratorUi : Form
    {
        Refrigerator refrigerator = new Refrigerator();
        public RefrigeratorUi()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(maxWeightTakeTextBox.Text))
            {
                refrigerator.MaxWeight = Convert.ToDouble(maxWeightTakeTextBox.Text);
                maxWeightTakeTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Max Weight Must be Added.");
            }
            
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(itemTextBox.Text) && !String.IsNullOrEmpty(weightTextBox.Text))
            {
                refrigerator.NumberOfItem = Convert.ToInt32(itemTextBox.Text);
                refrigerator.WeightPerItem = Convert.ToInt32(weightTextBox.Text);

                refrigerator.SetNumberOfItem();
                refrigerator.SetWeightPerItem();


                double currentWeight = refrigerator.GetCurrentWeight();

                bool isChecked = refrigerator.isPossible(currentWeight);

                if (isChecked)
                {
                    double remainingWeight = refrigerator.GetRemainingtWeight(currentWeight);
                    currentWeightTextBox.Text = currentWeight.ToString();
                    remainingWeightTextBox.Text = remainingWeight.ToString();
                }

                else
                {
                    MessageBox.Show(" Weights are Maximum, item can't be added ");
                }

                itemTextBox.Clear();
                weightTextBox.Clear();
            }

            else
            {
                MessageBox.Show("Feild Can't  be Empty ");
            }
                       
        }
    }
}
