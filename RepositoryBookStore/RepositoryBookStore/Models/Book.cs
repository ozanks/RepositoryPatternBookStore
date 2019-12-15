using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RepositoryBookStore.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public int UnitInStock { get; set; }
        public decimal UnitPrice { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public virtual ICollection<Category> Categories { get; set; }
    }
}