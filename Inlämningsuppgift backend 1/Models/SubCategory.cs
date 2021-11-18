using Inlämningsuppgift_backend_1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Inlämningsuppgift_backend_1
{
    [Index(nameof(Name), IsUnique = true)]
    public class SubCategory
    {
        [Key]
        public int Id { get; set; }


        [Requierd]
        public string Name { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }


        public virtual ICollection<Product> Products { get; set; }
    }
}
