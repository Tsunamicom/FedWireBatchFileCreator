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
        private UserAccess UserFocus = new UserAccess();

        public UserEdit()
        {
            InitializeComponent();
            ResetUserListComboBoxData();
        }

        // ************************ START - HELPER METHODS ************************

        private void AllowEditExistingUser(bool canEdit)
        {
            ClearAllBoxes();
            ToggleUnLockAllFields(!canEdit);
            CanEditExistingUser = canEdit;
        }

        private void AssociateFieldsUserFocus()
        {
            UserFocus.thisUser.UserName = textBoxUserName.Text;
            UserFocus.thisUser.First_Name = textBoxFirstName.Text;
            UserFocus.thisUser.Last_Name = textBoxLastName.Text;

            UserFocus.thisUser.Password = textBoxPassword1.Text;

            UserFocus.thisUser.isAdmin = checkBoxAdmin.Checked;

            UserFocus.thisUserRole.CreateNewBatch = checkBoxCreateNewBatch.Checked;
            UserFocus.thisUserRole.ModifyBatch = checkBoxModifyBatch.Checked;
            UserFocus.thisUserRole.VerifyBatch = checkBoxVerifyBatch.Checked;
            UserFocus.thisUserRole.DeleteBatch = checkBoxDeleteBatch.Checked;
            UserFocus.thisUserRole.ExportBatch = checkBoxExportBatch.Checked;

            UserFocus.thisUserRole.CreateNewTemplate = checkBoxNewTemplate.Checked;
            UserFocus.thisUserRole.ModifyTemplate = checkBoxVerifyTemplate.Checked;
            UserFocus.thisUserRole.VerifyTemplate = checkBoxVerifyTemplate.Checked;
            UserFocus.thisUserRole.DeleteTemplate = checkBoxDeleteTemplate.Checked;

            UserFocus.thisUserRole.CreateNewWire = checkBoxCreateNewWire.Checked;
            UserFocus.thisUserRole.ModifyWire = checkBoxVerifyWire.Checked;
            UserFocus.thisUserRole.VerifyWire = checkBoxVerifyWire.Checked;
            UserFocus.thisUserRole.DeleteWire = checkBoxDeleteWire.Checked;
        }

        private void AssociateSelectedUserMain(User selectedUser)
        {
            textBoxFirstName.Text = selectedUser.First_Name;
            textBoxLastName.Text = selectedUser.Last_Name;
            textBoxUserName.Text = selectedUser.UserName;

            textBoxPassword1.Text = selectedUser.Password;
            textBoxPassword2.Text = selectedUser.Password;

            checkBoxAdmin.Checked = selectedUser.isAdmin;
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

        private void ClearAllBoxes()
        {
            Debug.WriteLine("FORM:  Clearing Form Data");
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

        private void GetTextBoxValuesSelectedUser()
        {
            string userName = userListComboBox.SelectedValue.ToString();
            Debug.WriteLine("FORM:  Looking up User in DB: " + userName);
            using (FWFCUsersdbEntities context = new FWFCUsersdbEntities())
            {
                var selectedUser = context.Users.Where(c => (c.UserID + ": " + c.First_Name + " " + c.Last_Name) == userName).SingleOrDefault();
                if (selectedUser != null)
                {
                    Debug.WriteLine("FORM:  User Found!");
                    AssociateSelectedUserMain(selectedUser);
                    UserFocus.thisUser = selectedUser;

                    var selectedUserRoles = context.Roles.Where(c => c.FK_UserID == selectedUser.UserID).SingleOrDefault();
                    if (selectedUserRoles != null)
                    {
                        Debug.WriteLine("FORM:  User Roles Found!");
                        AssociateSelectedUserRole(selectedUserRoles);
                        UserFocus.thisUserRole = selectedUserRoles;
                    }
                    else
                    {
                        Debug.WriteLine("FORM:  User Roles Not Found!");
                    }
                }
                else
                {
                    Debug.WriteLine("FORM:  User Not Found!");
                }
            }
        }

        private List<string> GetUserNamesForCB(UserAccess existingUserFocus)
        {
            List<string> applicableUserNames = new List<string>();
            applicableUserNames.Add(">>New User<<");
            applicableUserNames.AddRange(existingUserFocus.GetUserNames());
            return applicableUserNames;
        }

        private void ResetUserFocus()
        {
            UserFocus = new UserAccess();
        }

        private void ResetPasswordFormFields()
        {
            buttonChangePassword.Enabled = true;
            buttonChangePassword.Text = "Change Password";
            textBoxPassword1.Enabled = false;
            textBoxPassword2.Enabled = false;
        }

        private void ResetUserListComboBoxData()
        {
            Debug.WriteLine("Resetting User List Combo Box Data");
            userListComboBox.DataSource = GetUserNamesForCB(UserFocus);
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

        private void ToggleUnLockAllFields(bool isUnlocked)
        {
            groupBoxPermissions.Enabled = isUnlocked;
            textBoxFirstName.Enabled = isUnlocked;
            textBoxLastName.Enabled = isUnlocked;
            buttonChangePassword.Enabled = isUnlocked;
            labelFirstName.Enabled = isUnlocked;
            labelLastName.Enabled = isUnlocked;
        }

        private void TryEnableUserModifyMainButton()
        {
            if (VerifyTextBoxesAreNotEmpty() == true)
            {
                buttonUserModifyMain.Enabled = true;
            }
            else
            {
                buttonUserModifyMain.Enabled = false;
            }
        }

        private bool ValidatePasswordRequirements(string password)
        {
            bool isValid = false;
            // Logic will be entered here to validate password requirements (length, characters, etc).
            return isValid;
        }

        private bool VerifyTextBoxesAreNotEmpty()
        {
            bool emptyBoxesFound = false;

            if (textBoxUserName.Text != "" &&
                textBoxFirstName.Text != "" &&
                textBoxLastName.Text != "" &&
                textBoxPassword1.Text != "" &&
                textBoxPassword2.Text != "")
            {
                emptyBoxesFound = true;
            }
            return emptyBoxesFound;
        }

        // ************************ END - HELPER METHODS ************************

        


        // ************************ START - FORM METHODS ************************

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            if (buttonChangePassword.Text == "Change Password")
            {
                textBoxPassword1.Enabled = true;
                textBoxPassword2.Enabled = true;
                buttonChangePassword.Text = "Save";
                buttonUserModifyMain.Enabled = false;
            }
            else
            {
                if (textBoxPassword1.Text != "" && textBoxPassword2.Text != "")
                {
                    if (textBoxPassword1.Text == textBoxPassword2.Text)
                    {
                        Debug.WriteLine("FORM:  Associating Password to UserFocus");
                        UserFocus.thisUser.Password = textBoxPassword1.Text;
                        buttonChangePassword.Text = "Change Password";
                        textBoxPassword1.Enabled = false;
                        textBoxPassword2.Enabled = false;
                        TryEnableUserModifyMainButton();
                    }
                    else
                    {
                        Debug.WriteLine("FORM:  Unable to Save Password - textBoxPassword1 and textBoxPassword2 do not match!");
                        MessageBox.Show("Passwords must Match!");
                    }
                }
                else
                {
                    Debug.WriteLine("FORM:  Unable to Save Password - Blank Fields detected!");
                    MessageBox.Show("Password Fields cannot be Blank!");
                }
            }

        }

        private void buttonUserModifyMain_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Clicking buttonUserModifyMain");
            if (buttonUserModifyMain.Text == "Save")
            {
                AssociateFieldsUserFocus();
                UserFocus.UpdateUserInfo();
                ResetUserListComboBoxData();
            }

            if (CanEditExistingUser == true)
            {
                ToggleUnLockAllFields(true);
                buttonUserModifyMain.Text = "Save";
                Debug.WriteLine("FORM:  Enabling Edit Mode");
            }
            else if (CanEditExistingUser == false)
            {
                if (VerifyTextBoxesAreNotEmpty() &&
                    userListComboBox.SelectedValue.ToString() == ">>New User<<")
                {
                    var result = MessageBox.Show("Add " + textBoxUserName.Text + " to Users?", "Confirm Add User", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Debug.WriteLine("FORM:  Saving New User to DB");
                        AssociateFieldsUserFocus();
                        UserFocus.SaveNewUserAccessToDB();
                        ResetUserListComboBoxData();
                    }
                    else
                    {
                        textBoxUserName.Focus();
                    }
                }
                else
                {
                    Debug.WriteLine("FORM:  Not enough info to save!");
                }
            }
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

        private void userListComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            ResetPasswordFormFields();
            if (userListComboBox.SelectedValue.ToString() == ">>New User<<")
            {
                if (buttonUserModifyMain.Text != "Save New User")
                {
                    buttonUserModifyMain.Text = "Save New User";
                }

                Debug.WriteLine("FORM:  >>New User<< Selected");

                buttonUserModifyMain.Enabled = false;
                AllowEditExistingUser(false);
                ResetUserFocus();
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

        private void textBoxFirstName_Leave(object sender, EventArgs e)
        {
            TryEnableUserModifyMainButton();
        }

        private void textBoxLastName_Leave(object sender, EventArgs e)
        {
            TryEnableUserModifyMainButton();
        }

        private void textBoxUserName_Leave(object sender, EventArgs e)
        {
            TryEnableUserModifyMainButton();
        }

        // ************************ END - FORM METHODS ************************
    }
}
