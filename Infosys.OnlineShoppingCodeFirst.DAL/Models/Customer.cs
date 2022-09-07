using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Infosys.OnlineShoppingCodeFirst.DAL.Models
{
    public class Customer
    {
       // [Key]//Annotation or Attribute //Represents Primary Key
        public int CustomerId { get; set; } //Primary Key Column
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public string MobileNo { get; set; }
        public DateTime DateOfBirth { get; set; }       

        //Auditable Columns
        public DateTime AddedDate { get; set; } = DateTime.Now; //NOT NULL

        public DateTime? ModifiedDate { get; set; }
    }
}
