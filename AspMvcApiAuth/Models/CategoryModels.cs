using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AspMvcApiAuth.Models
{
    public class CategoryModels
    {
    }

    public class Category
    {
        public int CategoryID { get; set; }

        [Required]
        public string Name { get; set; }
    }

    public class CategoryDbContext : DbContext
    {
        public CategoryDbContext() : base("DafaultConnection")
        {

        }

        public DbSet<Category> Categories { get; set; }
    }
}