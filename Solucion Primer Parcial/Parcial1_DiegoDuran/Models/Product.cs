using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Parcial1_DiegoDuran.Models
{
    public class Product
    {
        [Key]
        [Range(1, 99999, ErrorMessage = "The space of {0} , must be in the range from {1} to {2}")]
        public int ProductID { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Please enter a description from 3 to 30 characters lenght")]
        public string Description { get; set; } 
        
        [Required]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; } 

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime LastBuy { get; set; }

    }
}