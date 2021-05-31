using System;
using System.Collections.Generic;

#nullable disable

namespace TestTask
{
    public partial class Category
    {
        public Category()
        {
            Contacts = new HashSet<Contact>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<Contact> Contacts { get; set; }
    }
}
