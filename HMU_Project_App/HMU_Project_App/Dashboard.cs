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


        public void ViewRules()
        {
            lbViewRules.Items.Clear();
            int index = 0;
            foreach (string value in Form1.ListRules)
            {
                lbViewRules.Items.Add(Form1.ListRules[index]);
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
            //TempAndLightPort.Open();
            timerUpdate.Enabled = false;
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            
        }

        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            if (TempAndLightPort.BytesToRead > 0)
            {
                string message = TempAndLightPort.ReadLine();
                message = message.Trim();
                float RealTemp;

                if (float.TryParse(message, out RealTemp))//see if message is float (only temperature can be converted to int)
                {
                    lblTemperature.Text = "The temperature is currently: " + RealTemp + "°C";
                }
                switch (message) //filter message for strings
                {
                    case "LIGHT_DETECTED":
                        {
                            pnlGarbage.BackColor = Color.PaleGreen;
                            lblGarbage.Text = "Garbage has been set out!";

                        }
                        break;
                    case "NO_LIGHT_DETECTED":
                        {
                            pnlGarbage.BackColor = Color.Yellow;
                            lblGarbage.Text = "Garbage is not set out yet.";
                        }
                        break;
                }
            }
        }
    }
}
