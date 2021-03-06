﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace FedWire_Batch_File_Creator
{
    public partial class MainMenu : Form
    {
        public UserAccess CurrentUserSession = new UserAccess();
        

        public MainMenu()
        {
            InitializeComponent();
            ForceUserLogin();
        }

        private void TryEnableAdminOptions()
        {
            administrationToolStripMenuItem.Visible = false;
            if (CurrentUserSession.thisUser.isAdmin == true)
            {
                administrationToolStripMenuItem.Visible = true;
            }
        }

        private void SetCurrentUserNamesLabel()
        {
            if (labelFNLNShow.Text != null)
            {
                labelFNLNShow.Text = "Current User: " + CurrentUserSession.thisUser.First_Name + " " + CurrentUserSession.thisUser.Last_Name;
            }
            Debug.WriteLine("Current User: " + CurrentUserSession.thisUser.First_Name + " " + CurrentUserSession.thisUser.Last_Name);
        }

        private void ForceUserLogin()
        {
            if (CurrentUserSession.thisUser.UserName == null)
            {
                UserLogin tsULForm = new UserLogin();
                tsULForm.ShowDialog();
                CurrentUserSession = tsULForm.currentUserSession;
                SetCurrentUserNamesLabel();
            }
            TryEnableAdminOptions();
        }

        private int GetSelectedBatchID()
        {
            int selectedBatchID;
            BatchSelect batchSelectForm = new BatchSelect();
            batchSelectForm.ShowDialog();
            try
            {
                selectedBatchID = batchSelectForm.SelectedBatchID;
            }
            catch
            {
                Debug.WriteLine("Failed to Associate BatchID!");
                selectedBatchID = 999999999;  // Default Value on Batch ID Fail
            }
            
            return selectedBatchID;
        }

        private void CreateNewFedWireBasic()
        {
            int currentSelectedBatch = GetSelectedBatchID();
            if (currentSelectedBatch != 999999999)
            {
                Debug.WriteLine("MAINMENU: Opening new FedWireBasic under Batch ID: " + currentSelectedBatch);
                DomesticWireForm newDomesticWire = new DomesticWireForm(CurrentUserSession, currentSelectedBatch);
                newDomesticWire.ShowDialog();
            }
            else
            {
                Debug.WriteLine("MAINMENU:  Unable to Associate BatchID to new FedWireBasic!");
            }
            
        }

        private void openNewDomesticWireButton_Click(object sender, EventArgs e)
        {
            CreateNewFedWireBasic();
        }

        private void domesticWireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateNewFedWireBasic();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult confirmLogOut = MessageBox.Show("Are you sure you want to Log Out?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (confirmLogOut.Equals(DialogResult.OK))
            {
                CurrentUserSession.LogOut();
                ForceUserLogin();
            }
        }

        private void createEditUserToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UserEdit newUserEdit = new UserEdit();
            newUserEdit.ShowDialog();
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult confirmExit = MessageBox.Show("Are you sure you want to Exit?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (confirmExit.Equals(DialogResult.OK))
            {
                CurrentUserSession.LogOut();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
