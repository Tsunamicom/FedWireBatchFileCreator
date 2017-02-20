using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Data.Entity.Validation;

namespace FedWire_Batch_File_Creator
{
    public class UserAccess
    {
        public User thisUser = new User();
        public Role thisUserRole = new Role();
        public Security thisUserSecurity = new Security();

        private void RetrieveAllUserInfoFromDB()
        {
            Debug.WriteLine("USERACCESS: RetrieveAllUserInfoFromDB called.");
            using (FWFCUsersdbEntities context = new FWFCUsersdbEntities())
            {
                // Associate Main User Detail
                var currentUser = context.Users.Where(c => c.UserName == this.thisUser.UserName).FirstOrDefault();
                if (currentUser != null)
                {
                    Debug.WriteLine("USER: Associating User Main Info");
                    this.thisUser.UserID = currentUser.UserID;
                    this.thisUser.First_Name = currentUser.First_Name;
                    this.thisUser.Last_Name = currentUser.Last_Name;
                    this.thisUser.Roles = currentUser.Roles;
                    this.thisUser.CreatedDateTime = currentUser.CreatedDateTime;
                    this.thisUser.LastAccessDateTime = currentUser.LastAccessDateTime;
                    this.thisUser.ModifiedDateTime = currentUser.ModifiedDateTime;
                    this.thisUser.isAdmin = currentUser.isAdmin;
                    this.thisUser.UserStatus = currentUser.UserStatus;
                }
                else { Debug.WriteLine("USER: User Not Found!"); }

                // Associate User Roles
                var currentUserRole = context.Roles.Where(c => c.FK_UserID == currentUser.UserID).FirstOrDefault();
                if (currentUserRole != null)
                {
                    Debug.WriteLine("ROLE: Associating User Role Info");
                    this.thisUserRole.CreateNewBatch = currentUserRole.CreateNewBatch;
                    this.thisUserRole.CreateNewTemplate = currentUserRole.CreateNewTemplate;
                    this.thisUserRole.CreateNewWire = currentUserRole.CreateNewWire;
                    this.thisUserRole.DeleteBatch = currentUserRole.DeleteBatch;
                    this.thisUserRole.DeleteTemplate = currentUserRole.DeleteTemplate;
                    this.thisUserRole.DeleteWire = currentUserRole.DeleteWire;
                    this.thisUserRole.ExportBatch = currentUserRole.ExportBatch;
                    this.thisUserRole.ModifyBatch = currentUserRole.ModifyBatch;
                    this.thisUserRole.ModifyTemplate = currentUserRole.ModifyTemplate;
                    this.thisUserRole.ModifyWire = currentUserRole.ModifyWire;
                    this.thisUserRole.VerifyBatch = currentUserRole.VerifyBatch;
                    this.thisUserRole.VerifyTemplate = currentUserRole.VerifyTemplate;
                    this.thisUserRole.VerifyWire = currentUserRole.VerifyWire;
                }
                else { Debug.WriteLine("ROLE: No User Roles Found!"); }

                // Associate User Security
                var currentUserSecurity = context.Securities.Where(c => c.FK_UserID == currentUser.UserID).FirstOrDefault();
                if (currentUserSecurity != null)
                {
                    Debug.WriteLine("SECURITY: Associating User Security Info");
                    this.thisUserSecurity.Question1 = currentUserSecurity.Question1;
                    this.thisUserSecurity.Question2 = currentUserSecurity.Question2;
                    this.thisUserSecurity.Question3 = currentUserSecurity.Question3;
                    this.thisUserSecurity.Question4 = currentUserSecurity.Question4;
                    this.thisUserSecurity.Question5 = currentUserSecurity.Question5;
                    this.thisUserSecurity.Answer1 = currentUserSecurity.Answer1;
                    this.thisUserSecurity.Answer2 = currentUserSecurity.Answer2;
                    this.thisUserSecurity.Answer3 = currentUserSecurity.Answer3;
                    this.thisUserSecurity.Answer4 = currentUserSecurity.Answer4;
                    this.thisUserSecurity.Answer5 = currentUserSecurity.Answer5;
                    this.thisUserSecurity.SecurityPIN = currentUserSecurity.SecurityPIN;
                }
                else { Debug.WriteLine("SECURITY: No Security Info Found!"); }
            }
        }

        private void AssociateRoleInfo(Role currentRole)
        {
            Debug.WriteLine("ROLE:  User Roles Found:  Updating DB with New Roles");
            currentRole.CreateNewBatch = thisUserRole.CreateNewBatch;
            currentRole.ModifyBatch = thisUserRole.ModifyBatch;
            currentRole.VerifyBatch = thisUserRole.VerifyBatch;
            currentRole.DeleteBatch = thisUserRole.DeleteBatch;
            currentRole.ExportBatch = thisUserRole.ExportBatch;

            currentRole.CreateNewTemplate = thisUserRole.CreateNewTemplate;
            currentRole.ModifyTemplate = thisUserRole.ModifyTemplate;
            currentRole.VerifyTemplate = thisUserRole.VerifyTemplate;
            currentRole.DeleteTemplate = thisUserRole.DeleteTemplate;

            currentRole.CreateNewWire = thisUserRole.CreateNewWire;
            currentRole.ModifyWire = thisUserRole.ModifyWire;
            currentRole.VerifyWire = thisUserRole.VerifyWire;
            currentRole.DeleteWire = thisUserRole.DeleteWire;
        }

        public void UpdateUserInfo()
        {
            using (FWFCUsersdbEntities context = new FWFCUsersdbEntities())
            {
                User updatingUser = context.Users.Where(c => c.UserID == thisUser.UserID).SingleOrDefault();
                if (updatingUser != null)
                {
                    Debug.WriteLine("USER:  User Found:  Updating DB with Basic Info");
                    updatingUser.ModifiedDateTime = DateTime.Now;
                    updatingUser.UserName = thisUser.UserName;
                    updatingUser.First_Name = thisUser.First_Name;
                    updatingUser.Last_Name = thisUser.Last_Name;
                    updatingUser.Password = thisUser.Password;
                    updatingUser.isAdmin = thisUser.isAdmin;

                    Role updatingUserRole = context.Roles.Where(c => c.FK_UserID == updatingUser.UserID).SingleOrDefault();
                    if (updatingUserRole != null)
                    {
                        AssociateRoleInfo(updatingUserRole);
                    }
                    else
                    {
                        Debug.WriteLine("ROLE:  No Existing Roles Found!  Creating New Role record in DB.");
                        thisUserRole.FK_UserID = updatingUser.UserID;
                        context.Roles.Add(thisUserRole);
                    }

                    context.AttemptSaveChanges();
                }
            }
        }

        public void UpdatePassword()
        {
            using (FWFCUsersdbEntities context = new FWFCUsersdbEntities())
            {
                var updatePasswordFocusUser = context.Users.Where(c => c.UserID == thisUser.UserID).SingleOrDefault();
                if (updatePasswordFocusUser != null)
                {
                    Debug.WriteLine("USER:  User Found!  Updating Password.");
                    updatePasswordFocusUser.Password = thisUser.Password;
                }
                else
                {
                    Debug.WriteLine("USER:  User Not Found in DB!  Unable to update Password.");
                }
                context.AttemptSaveChanges();
            }
        }

        public void LogOut()
        {
            Debug.WriteLine("USERACCESS: LogOut called.");
            using (FWFCUsersdbEntities context = new FWFCUsersdbEntities())
            {
                var logoutUser = context.Users.Where(c => c.UserName == this.thisUser.UserName).FirstOrDefault();
                
                if (!(logoutUser == null))
                {
                    Debug.WriteLine("USERACCESS: Attempting to Log Out " + logoutUser.UserName);
                    logoutUser.UserStatus = "LOGOUT";
                }
                context.AttemptSaveChanges();
                ClearAllDBRelation();
            }
        }

        public void NewUserSession()
        {
            Debug.WriteLine("USERACCESS:  NewUserSession called.");
            using (FWFCUsersdbEntities context = new FWFCUsersdbEntities())
            {
                if (context.Users.Any(c => c.UserName == thisUser.UserName))
                {
                    Debug.WriteLine("USER:  User found in DB!");
                    var currentUser = context.Users.Where(c => c.UserName == thisUser.UserName).SingleOrDefault();
                    if (currentUser.Password == thisUser.Password)
                    {
                        Debug.WriteLine("USER:  Password Match!");
                        currentUser.UserStatus = "LOGGEDIN";
                        currentUser.LastAccessDateTime = DateTime.Now;
                        context.AttemptSaveChanges();
                        RetrieveAllUserInfoFromDB();
                    }
                    else { ClearAllDBRelation(); }
                }
                else { ClearAllDBRelation(); }
            }
        }

        private void ClearAllDBRelation()
        {
            Debug.WriteLine("USERACCESS:  ClearAllDBRelation called.");
            thisUser = new User();
            thisUserRole = new Role();
            thisUserSecurity = new Security();
        }

        public List<string> GetUserNames()  // Future Consideration:  Maybe Add this to separate static class
        {
            Debug.WriteLine("DB:  Acquiring User List from DB");
            List<string> thisList = new List<string>();

            using (FWFCUsersdbEntities context = new FWFCUsersdbEntities())
            {
                var userList = context.Users.ToList();
                foreach (var user in userList)
                {
                    thisList.Add(user.UserID + ": " + user.First_Name + " " + user.Last_Name);
                }
            }

            return thisList;
        }

        private bool VerifyUniqueUserName()
        {
            bool validated = false;
            Debug.WriteLine("USER:  Verifying whether UserName is Unique");
            using (FWFCUsersdbEntities context = new FWFCUsersdbEntities())
            {
                User uniqueUser = context.Users.Where(c => c.UserName == thisUser.UserName).SingleOrDefault();
                if (uniqueUser == null)
                {
                    Debug.WriteLine("USER:  User Name is Unique!");
                    validated = true;
                }
                else
                {
                    Debug.WriteLine("USER:  User Name is NOT Unique! Cannot Save new User over Existing!");
                }
            }
            return validated;
        }

        public void SaveNewUserAccessToDB()
        {
            Debug.WriteLine("USER:  Attempting to Save New User to DB");
            if (VerifyUniqueUserName() == true)
            {
                SaveNewUserToDB();
                UpdateUserInfo();
            }
        }

        private void SaveNewUserToDB()
        {
            using (FWFCUsersdbEntities context = new FWFCUsersdbEntities())
            {
                thisUser.CreatedDateTime = DateTime.Now;
                thisUser.ModifiedDateTime = DateTime.Now;
                thisUser.UserStatus = "NEW";
                context.Users.Add(thisUser);
                context.AttemptSaveChanges();
                thisUser = context.Users.Where(c => c.UserName == thisUser.UserName).SingleOrDefault();
                if (thisUser != null)
                {
                    Debug.WriteLine("USER:  New User's DB UserID = " + thisUser.UserID);
                }
                else
                {
                    Debug.WriteLine("USER:  There has been an error associating a new UserID!");
                }
            }
            
        }
    }
}
