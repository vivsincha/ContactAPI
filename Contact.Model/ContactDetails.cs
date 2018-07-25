using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.Model
{
    public class ContactDetails
    {
        //public int ContactId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public string PhoneNum { get; set; }
        public bool IsActive { get; set; }
    }
}
