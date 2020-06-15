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
    public partial class ScheduleTab : UserControl
    {
        public ScheduleTab()
        {
            InitializeComponent();
        }

        enum Room
        {
            Room1,
            Room2,
            Room3,
            Room4,
            Room5,
            Kitchen,
            Bathroom,
            Livingroom
        }
        private void ScheduleTab_Load(object sender, EventArgs e)
        {

        }

        private void BtnCleaned_Click(object sender, EventArgs e)
        {
            if (cbRooms.SelectedIndex > -1)
            {
                int i = cbRooms.SelectedIndex;
                lbCleaningTime.Items.Add(Convert.ToString((Room)i) + " was cleaned at " + DateTime.Now.ToShortDateString() + " . ");
            }
            else
                MessageBox.Show("Please select a room.");
            
        }
    }
}
