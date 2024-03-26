using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CReid_Graded_Unit_2_Custom_Computers.Models
{
    public class DatabaseInitialiser : DropCreateDatabaseAlways<CustomComputersDbContext>
    {
        protected override void Seed(CustomComputersDbContext context)
        {
            base.Seed(context);

            //If there are no records in the Users table
            if(!context.Users.Any()) 
            {
                //Creating Roles
                //Need a role manager to create roles
                RoleManager<IdentityRole> roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

                //If role doesn't exist
                if(!roleManager.RoleExists("Admin"))
                {
                    //Then create the role
                    roleManager.Create(new IdentityRole("Admin"));
                }

                //If role doesn't exist
                if (!roleManager.RoleExists("Sales Assistant"))
                {
                    //Then create the role
                    roleManager.Create(new IdentityRole("Sales Assistant"));
                }

                //If role doesn't exist
                if (!roleManager.RoleExists("Invoices Clerk"))
                {
                    //Then create the role
                    roleManager.Create(new IdentityRole("Invoices Clerk"));
                }

                //If role doesn't exist
                if (!roleManager.RoleExists("Store Manager"))
                {
                    //Then create the role
                    roleManager.Create(new IdentityRole("Store Manager"));
                }

                //If role doesn't exist
                if (!roleManager.RoleExists("Assistant Manager"))
                {
                    //Then create the role
                    roleManager.Create(new IdentityRole("Assistant Manager"));
                }

                //If role doesn't exist
                if (!roleManager.RoleExists("Stores Manager"))
                {
                    //Then create the role
                    roleManager.Create(new IdentityRole("Stores Manager"));
                }

                //If role doesn't exist
                if (!roleManager.RoleExists("Stores Assistant"))
                {
                    //Then create the role
                    roleManager.Create(new IdentityRole("Stores Assistant"));
                }

                //If role doesn't exist
                if (!roleManager.RoleExists("Customer"))
                {
                    //Then create the role
                    roleManager.Create(new IdentityRole("Customer"));
                }

                //Creating Users
                //Need a user manager to create users
                UserManager<User> userManager = new UserManager<User>(new UserStore<User>(context));

                //Adding admin
                //If user doesn't exist
                if(userManager.FindByName("admin@customcomputers.com") == null) 
                {
                    //Weak password validation for test users
                    userManager.PasswordValidator = new PasswordValidator
                    {
                        RequireDigit = false,
                        RequiredLength = 1,
                        RequireLowercase = false,
                        RequireUppercase = false,
                        RequireNonLetterOrDigit = false
                    };

                    //Create admin
                    var administrator = new Employee
                    {
                        UserName = "admin@customcomputers.com",
                        Email = "admin@customcomputers.com",
                        FirstName = "Admin",
                        LastName = "Admin",
                        AddressLine1 = "190 Cathedral Street",
                        AddressLine2 = "",
                        City = "Glasgow",
                        PostCode = "G4 0RF",
                        PhoneNumber = "01234567890",
                        RegisteredAt = DateTime.Now,
                        EmailConfirmed = true,
                        IsActive = true
                    };

                    //Add the admin and password to the Users table
                    userManager.Create(administrator, "a");
                    //Assign user to the admin role
                    userManager.AddToRole(administrator.Id, "Admin");
                }

                //Adding Sales Assistant
                if (userManager.FindByName("salesassistant@customcomputers.com") == null)
                {
                    //Weak password validation for test users
                    userManager.PasswordValidator = new PasswordValidator
                    {
                        RequireDigit = false,
                        RequiredLength = 1,
                        RequireLowercase = false,
                        RequireUppercase = false,
                        RequireNonLetterOrDigit = false
                    };

                    //Create Sales Assistant
                    var salesassistant = new Employee
                    {
                        UserName = "salesassistant@customcomputers.com",
                        Email = "salesassistant@customcomputers.com",
                        FirstName = "Sales",
                        LastName = "Assistant",
                        AddressLine1 = "190 Cathedral Street",
                        AddressLine2 = "",
                        City = "Glasgow",
                        PostCode = "G4 0RF",
                        PhoneNumber = "01234567890",
                        RegisteredAt = DateTime.Now,
                        EmailConfirmed = true,
                        IsActive = true
                    };

                    //Add the admin and password to the Users table
                    userManager.Create(salesassistant, "sa");
                    //Assign user to the admin role
                    userManager.AddToRole(salesassistant.Id, "Sales Assistant");
                }

                //Adding Invoices Clerk
                if (userManager.FindByName("invoicesclerk@customcomputers.com") == null)
                {
                    //Weak password validation for test users
                    userManager.PasswordValidator = new PasswordValidator
                    {
                        RequireDigit = false,
                        RequiredLength = 1,
                        RequireLowercase = false,
                        RequireUppercase = false,
                        RequireNonLetterOrDigit = false
                    };

                    //Create Invoices Clerk
                    var invoicesclerk = new Employee
                    {
                        UserName = "invoicesclerk@customcomputers.com",
                        Email = "invoicesclerk@customcomputers.com",
                        FirstName = "Invoices",
                        LastName = "Clerk",
                        AddressLine1 = "190 Cathedral Street",
                        AddressLine2 = "",
                        City = "Glasgow",
                        PostCode = "G4 0RF",
                        PhoneNumber = "01234567890",
                        RegisteredAt = DateTime.Now,
                        EmailConfirmed = true,
                        IsActive = true
                    };

                    //Add the admin and password to the Users table
                    userManager.Create(invoicesclerk, "ic");
                    //Assign user to the admin role
                    userManager.AddToRole(invoicesclerk.Id, "Invoices Clerk");
                }

                //Adding Invoices Clerk
                if (userManager.FindByName("invoicesclerk@customcomputers.com") == null)
                {
                    //Weak password validation for test users
                    userManager.PasswordValidator = new PasswordValidator
                    {
                        RequireDigit = false,
                        RequiredLength = 1,
                        RequireLowercase = false,
                        RequireUppercase = false,
                        RequireNonLetterOrDigit = false
                    };

                    //Create Invoices Clerk
                    var invoicesclerk = new Employee
                    {
                        UserName = "invoicesclerk@customcomputers.com",
                        Email = "invoicesclerk@customcomputers.com",
                        FirstName = "Invoices",
                        LastName = "Clerk",
                        AddressLine1 = "190 Cathedral Street",
                        AddressLine2 = "",
                        City = "Glasgow",
                        PostCode = "G4 0RF",
                        PhoneNumber = "01234567890",
                        RegisteredAt = DateTime.Now,
                        EmailConfirmed = true,
                        IsActive = true
                    };

                    //Add the admin and password to the Users table
                    userManager.Create(invoicesclerk, "ic");
                    //Assign user to the admin role
                    userManager.AddToRole(invoicesclerk.Id, "Invoices Clerk");
                }
            }
        }
    }
}