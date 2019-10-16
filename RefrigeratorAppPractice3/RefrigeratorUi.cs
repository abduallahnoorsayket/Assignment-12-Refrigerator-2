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

        Refrigarator refrigarator; 
          
        public RefrigeratorUi()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

            refrigarator = new Refrigarator( Convert.ToDouble ( maxWeightTakeTextBox.Text));
            maxWeightTakeTextBox.Clear();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            
            refrigarator.NoItem =Convert.ToInt32 (itemTextBox.Text);

            refrigarator.UnitWeight = Convert.ToDouble(weightTextBox.Text);
            

          if ( refrigarator.OverFlow(refrigarator.NoItem, refrigarator.UnitWeight)== false)
            {
              refrigarator.Add(refrigarator.NoItem, refrigarator.UnitWeight);
            }
            else
              {
              MessageBox.Show(" Your gievn amount can  not be entered because  Overflow !!");
              }

           

            currentWeightTextBox.Text = Convert.ToString( refrigarator.GetCurrentWeight());

            remainingWeightTextBox.Text = Convert.ToString(refrigarator.GetRemainingWeight());
            itemTextBox.Clear();
            weightTextBox.Clear();

            richTextBox.Text += "\n\nNo of Item :   Weight perunit   Total weight\n\n";

            for (int i = 0; i < refrigarator.NoItems.Count(); i++)
            {
              

              richTextBox.Text += "\t" + refrigarator.NoItems[i] + "\t" + refrigarator.UnitWeights[i] + "\t"
             + (refrigarator.NoItems[i] * refrigarator.UnitWeights[i]) + "\n";

                
            }


            richTextBox.Text += "-------------------------------------------------------------------------------------------\n";
         richTextBox.Text += "\t" + refrigarator.NoItems.Sum() + "\t" + refrigarator.UnitWeights.Sum() + "\t"
                + refrigarator.GetCurrentWeight() + "\n";
          


            
        }




    }
}
