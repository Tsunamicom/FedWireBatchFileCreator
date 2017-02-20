using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Validation;
using System.Diagnostics;

namespace FedWire_Batch_File_Creator
{
    public static class EFHelperExtensions
    {
        /// <summary>
        /// Attempts to Save the requested FWFCUsersDBEntites data to the DB utilizing Entity Framework SaveChanges() method.
        /// On Fail:  Will output error to Debugger.
        /// </summary>
        /// <param name="context"></param>
        public static void AttemptSaveChanges(this FWFCUsersdbEntities context)
        {
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
        }

        /// <summary>
        /// Attempts to Save the requested FWFCdbEntities data to the DB utilizing Entity Framework SaveChanges() method.
        /// On Fail:  Will output error to Debugger.
        /// </summary>
        /// <param name="context"></param>
        public static void AttemptSaveChanges(this FWFCdbEntities context)
        {
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
        }
    }
}
