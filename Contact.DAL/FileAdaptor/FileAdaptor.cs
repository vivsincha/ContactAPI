using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contact.Model;
using System.IO;
using Newtonsoft.Json;

namespace Contact.DAL.FileAdaptor
{
    public class FileAdaptor : IContactDataAdaptor
    {
        public bool Create(ContactDetails contactDetails)
        {
            throw new NotImplementedException();
        }

        public bool Delete(ContactDetails contactDetails)
        {
            throw new NotImplementedException();
        }

        public List<ContactDetails> Select()
        {
            return JsonConvert.DeserializeObject<List<ContactDetails>>(File.ReadAllText(@"D:\apicontactrepo\Contact.DAL\FileAdaptor\DummyData\ContactsData.json"));
        }

        public bool Update(ContactDetails contactDetails)
        {
            throw new NotImplementedException();
        }
    }
}
