using HMU_Project_App.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

/*This application is part of the H.M.U. (Housmate Management Utility) project designed by
group 6 for the Advanced Phase Software Engineering course at Fontys University of Applied Sciences
and as such should not be copied or redistributed without permission from the authors.
The members of group 6 and thus the sole authors of this code are:
Aleksandar Nasev, David Horvath and Paulius Stankevičius.

For contact purposes, please refer to one of the following e-mails:
a.nasev@student.fontys.nl;
david.horvath@student.fontys.nl;
p.stankevicius@student.fontys.nl;*/
namespace HMU_Project_App
{
    public partial class HMU_MainForm : Form
    {

        public HMU_MainForm()
        {
            InitializeComponent();
            ListRules.Add("No smoking in the building.");
            ListRules.Add("No loud gatherings after 22:00.");
            ListRules.Add("Garbage bin must be taken out on time.");
            dashboardTab.BringToFront();
        }

        /*List that stores the rules, accessed by the adminTab and tabDashboard user controls*/
        public static List<string> ListRules = new List<string>();

        /*Complaint class alongside a complaints list that are acessed by the adminTab and complaintsTab*/
        public static Complaints complaint;
        public static List<Complaints> ListComplaints = new List<Complaints>();

        /*Lists for agreements and accepted agreements acessed by the agreementsTab*/
        public static List<string> Agreements = new List<string>(); //list for storing agreement information
        public static List<string> AcceptedAgreements = new List<string>(); //list that stores each agreement that has been accepted

        /*lists for storing shopping list data accessed by the shopping list tab*/
        public static List<string> Items = new List<string>(); 
        public static List<double> Prices = new List<double>();
        public static List<string> Categ = new List<string>();
        public static List<int> Amount = new List<int>();

        public static string adminPassword = "password";//the admin password, hardcoded

        /*Custom border code*/
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        /*Following buttons all open their respective tabs by bringing them to front or focusing them*/
        private void btnAgreements_Click(object sender, EventArgs e)
        {
            
            agreementsTab.BringToFront();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            scheduleTab.BringToFront();
        }


        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            
            dashboardTab.BringToFront();
        }

        private void BtnComplaints_Click(object sender, EventArgs e)
        {
            
            complaintsTab.BringToFront();
        }

        private void BtnShoppingList_Click(object sender, EventArgs e)
        {
            
            shoppingListTab.BringToFront();
        }
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            adminTab.BringToFront();
            loginTab.BringToFront();
        }

        /**/
        private void PlBorder_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture(); //controls mouse pressed
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        /*method makes sure to close the port if it is open when exiting the program*/
        private void HMU_Mainform_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (TempAndLightPort.IsOpen)
            {
                TempAndLightPort.Close();
            }
        }

        /*following methods refer to the minimize, maximize and close methods/buttons at the top right corner*/
        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        private void BtnMax_Click(object sender, EventArgs e) //button which controls window size
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                btnMax.Image = Resources.noun_minimize_1269338;
            }
            else
                WindowState = FormWindowState.Normal;
            btnMax.Image = Resources.noun_maximize_2042437;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit(); //button to exit application
        }

        /*Button and label exit can be both clicked to exit the program*/
        private void btnExit_click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void LblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
