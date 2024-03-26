using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace CReid_Graded_Unit_2_Custom_Computers.Models
{
        public class CustomComputersDbContext : IdentityDbContext<User>
        {
            public CustomComputersDbContext()
                : base("CustomComputersConnection", throwIfV1Schema: false)
            {
            }

            public static CustomComputersDbContext Create()
            {
                return new CustomComputersDbContext();
            }
        }
    }