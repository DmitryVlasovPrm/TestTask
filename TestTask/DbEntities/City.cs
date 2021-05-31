using System;
using System.Collections.Generic;

#nullable disable

namespace TestTask
{
    public partial class City
    {
        public City()
        {
            Contacts = new HashSet<Contact>();
        }

        public int CityId { get; set; }
        public string CityName { get; set; }

        public virtual ICollection<Contact> Contacts { get; set; }
    }
}
