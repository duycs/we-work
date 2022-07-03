﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AppShareServices.Models;

namespace ProductDomain.AgreegateModels.ProductAgreegate
{
    public class Category : Entity
    {
        [Required]
        [MaxLength(36)]
        public string Code { get; set; }

        [MaxLength(250)]
        public string? Name { get; set; }

        [MaxLength(500)]
        public string? Description { get; set; }

        public virtual ICollection<Product>? Products { get; set; }

        [JsonIgnore]
        public virtual ICollection<ProductCategory>? ProductCategories { get; set; }
    }
}

