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

        private void RetrieveAllUserInfoFromDB()
        {
            Debug.WriteLine("RetrieveAllUserInfoFromDB called.");
            using (FWFCUsersdbEntities context = new FWFCUsersdbEntities())
            {
                var currentUser = context.Users.Where(c => c.UserName == this.thisUser.UserName).FirstOrDefault();
                this.thisUser.UserID = currentUser.UserID;
                this.thisUser.First_Name = currentUser.First_Name;
                this.thisUser.Last_Name = currentUser.Last_Name;
                this.thisUser.Roles = currentUser.Roles;
                this.thisUser.LastAccessDateTime = currentUser.LastAccessDateTime;
                this.thisUser.ModifiedDateTime = currentUser.ModifiedDateTime;
                this.thisUser.isAdmin = currentUser.isAdmin;
                this.thisUser.UserStatus = currentUser.UserStatus;
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
        }
    }
}
