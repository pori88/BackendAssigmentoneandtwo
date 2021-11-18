﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Inlämningsuppgift_backend_1.Models
{
    public class ProductCreateModel
    {
        [Required]
        public string Name { get; set; }


        public string Description { get; set; } = "";

        [Required]
        public decimal Price { get; set; }

        [Required]
        public string ImageUrl { get; set; } = "";

        [Required]
        public int SubCatergoryId { get; set; }
    }
}
