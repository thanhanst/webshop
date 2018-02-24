﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace WebShop.Model.Models
{
    [Table("Products")]
    public class Product
    {   
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        public string Name { set; get; }

        [Required]
        public string Alias { set; get; }

        [Required]
        public int CategoryID { set; get; }
        [ForeignKey("CategoryID")]
        public virtual ProductCategory ProductCategory { set; get; }

        public string Image { set; get; }
        public XElement MoreImage { set; get; }

        [Required]
        public decimal Price { set; get; }

        public decimal? Promotion { set; get; }
        public int? Warranty { set; get; }
        public string Description { set; get; }
        public string Content { set; get; }        
        
        public bool? HomeFlag { set; get; }
        public bool? HotFlag { set; get; }
        public int? ViewCount { set; get; }
    }
}