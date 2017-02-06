using System;
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
    public partial class UserEdit : Form
    {
        List<string> UserList = new List<string>();

        public UserEdit()
        {
            InitializeComponent();
            userListComboBox.DataSource = GetUserNamesForCB();
        }

        private List<string> GetUserNamesForCB()
        {
            Debug.WriteLine("Acquiring User List from DB");
            List<string> thisList = new List<string>();
            thisList.Add(">>New User<<");

            using (FWFCUsersdbEntities context = new FWFCUsersdbEntities())
            {
                var userList = context.Users.ToList();
                foreach (var user in userList)
                {
                    thisList.Add(user.First_Name + " " + user.Last_Name);
                }
            }

            return thisList;
        }

        private void ClearAllBoxes()
        {
            textBoxFirstName.Text = null;
            textBoxLastName.Text = null;
            textBoxUserName.Text = null;
            textBoxPassword1.Text = null;
            textBoxPassword2.Text = null;

            checkBoxAdmin.Checked = false;

            checkBoxCreateNewBatch.Checked = false;
            checkBoxModifyBatch.Checked = false;
            checkBoxVerifyBatch.Checked = false;
            checkBoxDeleteBatch.Checked = false;
            checkBoxExportBatch.Checked = false;

            checkBoxCreateNewWire.Checked = false;
            checkBoxModifyWire.Checked = false;
            checkBoxVerifyWire.Checked = false;
            checkBoxDeleteWire.Checked = false;

            checkBoxNewTemplate.Checked = false;
            checkBoxModifyTemplate.Checked = false;
            checkBoxVerifyTemplate.Checked = false;
            checkBoxDeleteTemplate.Checked = false;
            
            

            
            
            

            ;
        }

        private void userListComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (userListComboBox.SelectedValue.ToString() != ">>New User<<")
            {
                buttonCreateNew.Enabled = false;
                buttonEditUser.Enabled = true;
                ClearAllBoxes();
                GetTextBoxValuesSelectedUser();
            }
            else
            {
                buttonCreateNew.Enabled = true;
                buttonEditUser.Enabled = false;
            }
        }

        private void AssociateSelectedUserRole(Role selectedUserRoles)
        {
            checkBoxCreateNewBatch.Checked = selectedUserRoles.CreateNewBatch;
            checkBoxModifyBatch.Checked = selectedUserRoles.ModifyBatch;
            checkBoxVerifyBatch.Checked = selectedUserRoles.VerifyBatch;
            checkBoxDeleteBatch.Checked = selectedUserRoles.DeleteBatch;
            checkBoxExportBatch.Checked = selectedUserRoles.ExportBatch;

            checkBoxCreateNewWire.Checked = selectedUserRoles.CreateNewWire;
            checkBoxModifyWire.Checked = selectedUserRoles.ModifyWire;
            checkBoxVerifyWire.Checked = selectedUserRoles.VerifyWire;
            checkBoxDeleteWire.Checked = selectedUserRoles.DeleteWire;

            checkBoxNewTemplate.Checked = selectedUserRoles.CreateNewTemplate;
            checkBoxModifyTemplate.Checked = selectedUserRoles.ModifyTemplate;
            checkBoxVerifyTemplate.Checked = selectedUserRoles.VerifyTemplate;
            checkBoxDeleteTemplate.Checked = selectedUserRoles.DeleteTemplate;
        }

        private void AssociateSelectedUserMain(User selectedUser)
        {
            textBoxFirstName.Text = selectedUser.First_Name;
            textBoxLastName.Text = selectedUser.Last_Name;
            textBoxUserName.Text = selectedUser.UserName;
            checkBoxAdmin.Checked = selectedUser.isAdmin;
        }

        private void GetTextBoxValuesSelectedUser()
        {
            string userName = userListComboBox.SelectedValue.ToString();
            Debug.WriteLine("Looking up User in DB: " + userName);
            using(FWFCUsersdbEntities context = new FWFCUsersdbEntities())
            {
                var selectedUser = context.Users.Where(c => (c.First_Name + " " + c.Last_Name) == userName).FirstOrDefault();
                if (selectedUser != null)
                {
                    Debug.WriteLine("User Found!");
                    AssociateSelectedUserMain(selectedUser);

                    var selectedUserRoles = context.Roles.Where(c => c.FK_UserID == selectedUser.UserID).FirstOrDefault();
                    if (selectedUserRoles != null)
                    {
                        Debug.WriteLine("User Roles Found!");
                        AssociateSelectedUserRole(selectedUserRoles);
                    }
                    else
                    {
                        Debug.WriteLine("User Roles Not Found!");
                    }
                }
                else
                {
                    Debug.WriteLine("User Not Found!");
                }
            }
        }
    }
}
