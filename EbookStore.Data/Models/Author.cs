﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EbookStore.Mobile.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Nationality { get; set; }
        public string Description { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
