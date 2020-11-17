using System;
using System.Collections.Generic;
using System.Text;

namespace EbookStore.Mobile.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Author Author { get; set; }
        public Uri PhotoUri { get; set; }
        public string Description { get; set; }
        public ICollection<string> Categories { get; set; }
        public ICollection<string> Languages { get; set; }
        public float Prize { get; set; }
    }
}
