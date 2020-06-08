﻿using System;
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
    public partial class AgreementsTab : UserControl
    {
        public AgreementsTab()
        {
            InitializeComponent();
        }

        List<string> Agreements = new List<string>(); //list for storing agreement information
        List<string> AcceptedAgreements = new List<string>();

        private void UpdateAgreements() // method for updating the list of agreements
        {
            lbAgreements.Items.Clear();

            foreach (string value in Agreements)
            {
                lbAgreements.Items.Add($"{value}");
            }
        }
        private void AddAgreement() // method for adding a agreement
        {

            string agreement = tbAgreementInfo.Text;

            Agreements.Add(agreement);

            UpdateAgreements();
        }

        private void BtnShowAllAgreements_Click(object sender, EventArgs e)
        {
            UpdateAgreements();
        }

        private void BtnShowAcceptedAgreement_Click(object sender, EventArgs e)
        {
            lbAgreements.Items.Clear();

            foreach (string value in AcceptedAgreements)
            {
                lbAgreements.Items.Add(value + " : Accepted");
            }
        }

        private void BtnAddAgreement_Click(object sender, EventArgs e)
        {
            if (tbAgreementInfo.Text != "")
            {
                AddAgreement();
                tbAgreementInfo.Text = "";
            }
            else
            {
                MessageBox.Show("Areement field is empty. Please write an agreement.");
            }
        }

        private void BtnAcceptAgreement_Click(object sender, EventArgs e)
        {
            string accepted = (string)lbAgreements.SelectedItem;

            if (accepted != null)
            {
                AcceptedAgreements.Add(accepted);
            }
            else
            {
                MessageBox.Show("Please select an agreement.");
            }
        }

        private void BtnRemoveAgreement_Click(object sender, EventArgs e)
        {
            int index = 0;
            int selectedAgreementIndex = lbAgreements.SelectedIndex;
            if (selectedAgreementIndex < 0)
            {
                MessageBox.Show("Please select an agreement.");
            }
            else
            {
                string selectedAgreement = lbAgreements.Items[selectedAgreementIndex].ToString();
                for (index = 0; index <= Agreements.Count - 1; index++)
                {
                    if (selectedAgreement == Agreements[index])
                    {
                        Agreements.RemoveAt(index);
                    }
                }

                for (index = 0; index <= AcceptedAgreements.Count - 1; index++)
                {
                    if (selectedAgreement == AcceptedAgreements[index])
                    {
                        AcceptedAgreements.RemoveAt(index);
                    }
                }

            }

            UpdateAgreements();
        }

        private void BtnAddAgreement_Click_1(object sender, EventArgs e)
        {

        }
    }
}
