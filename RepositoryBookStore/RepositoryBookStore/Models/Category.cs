using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RepositoryBookStore.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        public string CategoryName { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}