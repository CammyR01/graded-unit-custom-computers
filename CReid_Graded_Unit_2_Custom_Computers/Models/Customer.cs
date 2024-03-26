using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CReid_Graded_Unit_2_Custom_Computers.Models
{
    public class Customer : User
    {
        [Display(Name = "Customer Type")]
        public CustomerType CustomerType { get; set; }
    }

    public enum CustomerType //Customers can be a regular customer or a business/corporate customer
    {
        Regular,
        Business
    }

}