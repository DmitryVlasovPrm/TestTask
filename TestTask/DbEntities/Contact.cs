using System;
using System.Collections.Generic;

#nullable disable

namespace TestTask
{
    public partial class Contact
    {
        public int ContactId { get; set; }
        public string PhoneNumber { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string PatronymicName { get; set; }
        public string Sex { get; set; }
        public string BirthdayDate { get; set; }
        public int? CategoryId { get; set; }
        public int? CityId { get; set; }
        public int? ContactInfoId { get; set; }

        public virtual Category Category { get; set; }
        public virtual City City { get; set; }
        public virtual ContactInfo ContactInfo { get; set; }
    }
}
