using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Infosys.OnlineShoppingCodeFirst.DAL.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required]
        [Column(TypeName ="varchar(100)")]
        public string ProductName { get; set; }

        [Column(TypeName ="varchar(250)")]
        public string Description { get; set; }

        [Range(minimum: 0, maximum: 2000000)]
        public decimal Price { get; set; }

        [Range(minimum:0, maximum: int.MaxValue)]
        public int Quantity { get; set; }

        //Auditable Columns
        public DateTime AddedDate { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; }

        //Navigation Property
        public Category Category { get; set; }

        //FK
        public int CategoryId { get; set; } //One to One Relationship

    }
}
