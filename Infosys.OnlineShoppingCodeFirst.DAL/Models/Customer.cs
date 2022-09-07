using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Infosys.OnlineShoppingCodeFirst.DAL.Models
{
    public class Customer
    {
        // [Key]//Annotation or Attribute //Represents Primary Key
        public int CustomerId { get; set; } //Primary Key Column

        [Required] //Not null        
        [Column(TypeName ="varchar(50)")]//Change the datatype with fixed size
        public string FirstName { get; set; }

        [Column(TypeName ="varchar(50)")]
        public string LastName { get; set; }

        [Required]
        [Column(TypeName ="varchar(100)")]
        public string EmailId { get; set; }

        [Required]
        [Column(TypeName ="char(10)")]
        public string MobileNo { get; set; }

        public DateTime DateOfBirth { get; set; }
       

        //Auditable Columns
        public DateTime AddedDate { get; set; } = DateTime.Now; //NOT NULL

        public DateTime? ModifiedDate { get; set; }
    }
}
