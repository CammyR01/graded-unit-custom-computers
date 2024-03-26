using System.Data.Entity;
using System;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;
using Microsoft.AspNet.Identity.Owin;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CReid_Graded_Unit_2_Custom_Computers.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public abstract class User : IdentityUser
    {
        //Extending user with extra properties
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "AddressLine1")]
        public string AddressLine1 { get; set; }

        [Display(Name = "AddressLine2")]
        public string AddressLine2 { get; set; }

        public string City { get; set; }

        [Display(Name = "Post Code")]
        public string PostCode { get; set; }

        [Display(Name = "Phone Number")]
        public override string PhoneNumber { get; set; }

        public DateTime RegisteredAt { get; set; }

        public bool IsActive { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }

        //Using ApplicationUserManager to get the users current role
        private ApplicationUserManager userManager;

        //The CurrentRole property won't be mapped as a field in the Users table, it's needed to get the current role of the logged in user
        [NotMapped]
        public string CurrentRole
        {
            get
            {
                if(userManager == null)
                {
                    userManager = HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>();
                }

                return userManager.GetRoles(Id).Single();
            }
        }
    }
}