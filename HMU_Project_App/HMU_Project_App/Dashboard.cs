using System;
using System.Drawing;
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

        /*Method adds every element in the list to th elistbox*/
        public void ViewRules()
        {
            lbViewRules.Items.Clear();
            int index = 0;
            foreach (string value in HMU_MainForm.ListRules)
            {
                lbViewRules.Items.Add(HMU_MainForm.ListRules[index]);
                index++;
            }
        }

        /*Following buttons either fill the listbox or clear it*/
        private void BtnViewRules_Click(object sender, EventArgs e)
        {
            ViewRules();
        }


        private void BtnHideRules_Click(object sender, EventArgs e)
        {
            lbViewRules.Items.Clear();
        }

       
        /*On dashboard load, if port is not open, open it. Also enable the timer if it is not yet enabled*/
        private void Dashboard_Load(object sender, EventArgs e)
        {
            /*if (!TempAndLightPort.IsOpen)
            {
                TempAndLightPort.Open();
            }
            if (!timerUpdate.Enabled)
            timerUpdate.Enabled = true;*/
        }

        
        /*On timer tick event, read the message from the serial port. If it is a float, update the temperature label. Otherwise,
        update the garbage label and panel with appropriate text and color depicting the garbage status based on the text from the serial port*/
        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            if (TempAndLightPort.BytesToRead > 0)
            {
                string message = TempAndLightPort.ReadLine();
                message = message.Trim();
                float RealTemp;

                if (float.TryParse(message, out RealTemp))//see if message is float (only temperature can be converted to int)
                {
                    lblTemperature.Text = "Temperature: " + RealTemp + " °C";
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
