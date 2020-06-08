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
    public partial class ComplaintsTab : UserControl
    {
        public ComplaintsTab()
        {
            InitializeComponent();
        }

        private Complaints complaint;
        List<Complaints> ListComplaints = new List<Complaints>();

        private void BtnAddComplaint_Click(object sender, EventArgs e)
        {
            if (tbComplaints.Text != "")
            {
                string c = tbComplaints.Text;
                string d = DateTime.Now.ToString();

                complaint = new Complaints(d, c);

                ListComplaints.Add(complaint);

                tbComplaints.Text = "";
            }
            else
            {
                MessageBox.Show("Complaint field is empty. Please write a complaint.");
            }
        }

        private void TbComplaints_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
