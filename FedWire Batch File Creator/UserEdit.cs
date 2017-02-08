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
        private bool CanEditExistingUser;
        private UserAccess ExistingUserFocus = new UserAccess();

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
            Debug.WriteLine("Clearing Form Data");
            textBoxFirstName.Text = null;
            textBoxLastName.Text = null;
            textBoxUserName.Text = null;
            textBoxPassword1.Text = null;
            textBoxPassword2.Text = null;

            checkBoxAdmin.Checked = false;

            ToggleEnableBatchCheckBoxes(false);
            ToggleEnableWireCheckBoxes(false);
            ToggleEnableTemplateCheckBoxes(false);
        }

        private void AllowEditExistingUser(bool canEdit)
        {
            ClearAllBoxes();
            ToggleUnLockAllFields(!canEdit);
            CanEditExistingUser = canEdit;
        }

        private void userListComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            
            if (userListComboBox.SelectedValue.ToString() == ">>New User<<")
            {
                if (buttonUserModifyMain.Text != "Save New User")
                {
                    buttonUserModifyMain.Text = "Save New User";
                }

                Debug.WriteLine(">>New User<< Selected");

                buttonUserModifyMain.Enabled = false;
                AllowEditExistingUser(false);

                textBoxUserName.Enabled = true;
                labelUserName.Enabled = true;
            }
            else
            {
                if (buttonUserModifyMain.Text != "Edit User")
                {
                    buttonUserModifyMain.Text = "Edit User";
                }

                buttonUserModifyMain.Enabled = true;
                AllowEditExistingUser(true);

                GetTextBoxValuesSelectedUser();
                
                textBoxUserName.Enabled = false;
                labelUserName.Enabled = false;
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
                var selectedUser = context.Users.Where(c => (c.First_Name + " " + c.Last_Name) == userName).SingleOrDefault();
                if (selectedUser != null)
                {
                    Debug.WriteLine("User Found!");
                    AssociateSelectedUserMain(selectedUser);
                    ExistingUserFocus.thisUser = selectedUser;

                    var selectedUserRoles = context.Roles.Where(c => c.FK_UserID == selectedUser.UserID).SingleOrDefault();
                    if (selectedUserRoles != null)
                    {
                        Debug.WriteLine("User Roles Found!");
                        AssociateSelectedUserRole(selectedUserRoles);
                        ExistingUserFocus.thisUserRole = selectedUserRoles;
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

        private void ToggleUnLockAllFields(bool isUnlocked)
        {
            groupBoxPermissions.Enabled = isUnlocked;
            textBoxFirstName.Enabled = isUnlocked;
            textBoxLastName.Enabled = isUnlocked;
            buttonChangePassword.Enabled = isUnlocked;
            labelFirstName.Enabled = isUnlocked;
            labelLastName.Enabled = isUnlocked;
        }

        private void buttonUserModifyMain_Click(object sender, EventArgs e)
        {
            if (buttonUserModifyMain.Text == "Save")
            {
                AssociateFieldsExistingUserFocus();
                ExistingUserFocus.UpdateUserInfo();
                userListComboBox.DataSource = GetUserNamesForCB();
            }
            if (CanEditExistingUser == true)
            {
                ToggleUnLockAllFields(true);
                buttonUserModifyMain.Text = "Save";
            }
            else if (CanEditExistingUser == false)
            {
                
            }
            
        }

        private void AssociateFieldsExistingUserFocus()
        {
            ExistingUserFocus.thisUser.First_Name = textBoxFirstName.Text;
            ExistingUserFocus.thisUser.Last_Name = textBoxLastName.Text;

            ExistingUserFocus.thisUser.isAdmin = checkBoxAdmin.Checked;

            ExistingUserFocus.thisUserRole.CreateNewBatch = checkBoxCreateNewBatch.Checked;
            ExistingUserFocus.thisUserRole.ModifyBatch = checkBoxModifyBatch.Checked;
            ExistingUserFocus.thisUserRole.VerifyBatch = checkBoxVerifyBatch.Checked;
            ExistingUserFocus.thisUserRole.DeleteBatch = checkBoxDeleteBatch.Checked;
            ExistingUserFocus.thisUserRole.ExportBatch = checkBoxExportBatch.Checked;

            ExistingUserFocus.thisUserRole.CreateNewTemplate = checkBoxNewTemplate.Checked;
            ExistingUserFocus.thisUserRole.ModifyTemplate = checkBoxVerifyTemplate.Checked;
            ExistingUserFocus.thisUserRole.VerifyTemplate = checkBoxVerifyTemplate.Checked;
            ExistingUserFocus.thisUserRole.DeleteTemplate = checkBoxDeleteTemplate.Checked;

            ExistingUserFocus.thisUserRole.CreateNewWire = checkBoxCreateNewWire.Checked;
            ExistingUserFocus.thisUserRole.ModifyWire = checkBoxVerifyWire.Checked;
            ExistingUserFocus.thisUserRole.VerifyWire = checkBoxVerifyWire.Checked;
            ExistingUserFocus.thisUserRole.DeleteWire = checkBoxDeleteWire.Checked;
        }

        private void ToggleEnableBatchCheckBoxes(bool isEnabled)
        {
            checkBoxCreateNewBatch.Checked = isEnabled;
            checkBoxModifyBatch.Checked = isEnabled;
            checkBoxVerifyBatch.Checked = isEnabled;
            checkBoxDeleteBatch.Checked = isEnabled;
            checkBoxExportBatch.Checked = isEnabled;
        }

        private void ToggleEnableWireCheckBoxes(bool isEnabled)
        {
            checkBoxCreateNewWire.Checked = isEnabled;
            checkBoxModifyWire.Checked = isEnabled;
            checkBoxVerifyWire.Checked = isEnabled;
            checkBoxDeleteWire.Checked = isEnabled;
        }

        private void ToggleEnableTemplateCheckBoxes(bool isEnabled)
        {
            checkBoxNewTemplate.Checked = isEnabled;
            checkBoxModifyTemplate.Checked = isEnabled;
            checkBoxVerifyTemplate.Checked = isEnabled;
            checkBoxDeleteTemplate.Checked = isEnabled;
        }

        private void checkBoxAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAdmin.Checked == true)
            {
                ToggleEnableBatchCheckBoxes(true);
                ToggleEnableWireCheckBoxes(true);
                ToggleEnableTemplateCheckBoxes(true);
            }
        }
    }
}
