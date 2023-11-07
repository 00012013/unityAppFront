﻿namespace UnityApp.Models
{
    public class Author
    {
        
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}

