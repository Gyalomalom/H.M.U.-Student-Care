using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMU_Project_App
{
    public partial class Dashboard : UserControl
    {
        public string test;
        public Dashboard()
        {
            InitializeComponent();
            
        }

        public List<string> ListRules = new List<string>();

        public void ViewRules()
        {
            lbViewRules.Items.Clear();
            int index = 0;
            foreach (string value in ListRules)
            {
                lbViewRules.Items.Add(ListRules[index]);
                index++;
            }
        }

        private void BtnViewRules_Click(object sender, EventArgs e)
        {
            ViewRules();
        }


        public void LbViewRules_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnHideRules_Click(object sender, EventArgs e)
        {
            lbViewRules.Items.Clear();
        }

        private void LblTemperature_Click(object sender, EventArgs e)
        {

        }

        

        private void PnlGarbage_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
