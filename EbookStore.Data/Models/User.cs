using System;
using System.Collections.Generic;
using System.Text;

namespace EbookStore.Mobile.Models
{
    public class User
    {

        public string Login { get; set; }
        
        public string Password { get; set; }
        
        /// <summary>
        /// Account creation date.
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Owned Books.
        /// </summary>
        public ICollection<Book> OwnedBooks { get; set; }

        /// <summary>
        /// Books in Cart.
        /// </summary>
        public ICollection<Book> Cart { get; set; }
    }
}
