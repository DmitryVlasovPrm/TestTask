using System;
using System.Collections.Generic;

#nullable disable

namespace TestTask
{
    public partial class ContactInfo
    {
        public ContactInfo()
        {
            Contacts = new HashSet<Contact>();
        }

        public int ContactInfoId { get; set; }
        public DateTime DownloadTime { get; set; }
        public string CsvFileName { get; set; }
        public string Comment { get; set; }

        public virtual ICollection<Contact> Contacts { get; set; }
    }
}
