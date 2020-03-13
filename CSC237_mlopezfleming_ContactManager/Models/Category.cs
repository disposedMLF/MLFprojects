using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CSC237_mlopezfleming_ContactManager.Models
{
    public class Category
    {
        // primary key - generate by database
        [Key]
        public int CategoryId { get; set; }

        public string Name { get; set; }
    }
}
