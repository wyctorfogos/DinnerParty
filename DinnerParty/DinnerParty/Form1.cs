using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Collections.IEnumerable;
namespace Dinner_Party
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerparty;
        public Form1()
        {
            InitializeComponent();
            dinnerparty = new DinnerParty();
            dinnerparty.CalculateCostOfDecorations(fancyBox.Checked);
            dinnerparty.SetHealthyOption(healthyBox.Checked);
            DisplayDinnerPartyCost();
        }

        private void fancyBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerparty.CalculateCostOfDecorations(fancyBox.Checked);
            DisplayDinnerPartyCost();
        }
        private void healthyBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerparty.SetHealthyOption(healthyBox.Checked);
            DisplayDinnerPartyCost();
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dinnerparty.SetNumberOfPeople((int) (numericUpDown1.Value));
            DisplayDinnerPartyCost();
        }
        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerparty.CalculateCost(healthyBox.Checked);
            costLabel.Text = Cost.ToString("c");
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
