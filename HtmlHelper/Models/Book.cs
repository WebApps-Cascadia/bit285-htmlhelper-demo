using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HtmlHelperDemo.Models
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Edition { get; set; }
        public decimal Price { get; set; }
        public DateTime Publication { get; set; }
    }
}