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
            Debug.WriteLine("RetrieveAllUserInfoFromDB called.");
            using (FWFCUsersdbEntities context = new FWFCUsersdbEntities())
            {
                // Associate Main User Detail
                var currentUser = context.Users.Where(c => c.UserName == this.thisUser.UserName).FirstOrDefault();
                if (currentUser != null)
                {
                    Debug.WriteLine("Associating User Main Info");
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
                else { Debug.WriteLine("User Not Found!"); }

                // Associate User Roles
                var currentUserRole = context.Roles.Where(c => c.FK_UserID == currentUser.UserID).FirstOrDefault();
                if (currentUserRole != null)
                {
                    Debug.WriteLine("Associating User Role Info");
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
                else { Debug.WriteLine("No User Roles Found!"); }

                // Associate User Security
                var currentUserSecurity = context.Securities.Where(c => c.FK_UserID == currentUser.UserID).FirstOrDefault();
                if (currentUserSecurity != null)
                {
                    Debug.WriteLine("Associating User Security Info");
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
                else { Debug.WriteLine("No Security Info Found!"); }
            }
        }

        public void LogOut()
        {
            Debug.WriteLine("LogOut called.");
            using (FWFCUsersdbEntities context = new FWFCUsersdbEntities())
            {
                var logoutUser = context.Users.Where(c => c.UserName == this.thisUser.UserName).FirstOrDefault();
                
                if (!(logoutUser == null))
                {
                    Debug.WriteLine("Attempting to Log Out " + logoutUser.UserName);
                    logoutUser.UserStatus = "LOGOUT";
                } 
                context.SaveChanges();
                ClearAllDBRelation();
            }
        }

        public void NewUserSession()
        {
            Debug.WriteLine("NewUserSession called.");
            using (FWFCUsersdbEntities context = new FWFCUsersdbEntities())
            {
                if (context.Users.Any(c => c.UserName == this.thisUser.UserName))
                {
                    Debug.WriteLine("User found in DB!");
                    var currentUser = context.Users.Where(c => c.UserName == this.thisUser.UserName).FirstOrDefault();
                    if (currentUser.Password == this.thisUser.Password)
                    {
                        Debug.WriteLine("Password Match!");
                        currentUser.UserStatus = "LOGGEDIN";
                        currentUser.LastAccessDateTime = DateTime.Now;
                        try
                        {
                            context.SaveChanges();
                        }
                        catch (DbEntityValidationException ex)
                        {
                            foreach (var entityValidationErrors in ex.EntityValidationErrors)
                            {
                                foreach (var validationError in entityValidationErrors.ValidationErrors)
                                {
                                    Debug.WriteLine("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                                }
                            }
                        }
                        RetrieveAllUserInfoFromDB();
                    }
                    else { ClearAllDBRelation(); }
                }
                else { ClearAllDBRelation(); }
            }
        }

        private void ClearAllDBRelation()
        {
            Debug.WriteLine("ClearAllDBRelation called.");
            thisUser = new User();
            thisUserRole = new Role();
            thisUserSecurity = new Security();
        }
    }
}
