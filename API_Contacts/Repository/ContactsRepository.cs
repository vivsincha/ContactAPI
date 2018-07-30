using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Contact.Model;
using System.Data;
using System.Data.Entity;
using Contact.DAL;

namespace API_Contacts.Repository
{
    public class ContactsRepository : IRepository<ContactDetails>
    {
        private IContactDataAdaptor _contactDataAdaptor;
        
        public ContactsRepository(IContactDataAdaptor contactDataAdaptor)
        {
            _contactDataAdaptor = contactDataAdaptor;
        }

        IEnumerable<ContactDetails> IRepository<ContactDetails>.GetAll()
        {
            return _contactDataAdaptor.Select();
        }

        bool IRepository<ContactDetails>.Insert(ContactDetails obj)
        {
            return _contactDataAdaptor.Create(obj);
        }
        
       public bool Delete(object Id)
        {
            return _contactDataAdaptor.Delete((int)Id);
        }

       

        bool IRepository<ContactDetails>.Update(ContactDetails obj)
        {
            return _contactDataAdaptor.Update(obj);
        }

        bool IRepository<ContactDetails>.Delete(object Id)
        {
            return _contactDataAdaptor.Delete((int)Id);
        }

        public bool Activate(object Id)
        {
            return _contactDataAdaptor.Activate((int)Id);
        }

        public bool Deactivate(object Id)
        {
            return _contactDataAdaptor.Deactivate((int)Id);
        }
        object IRepository<ContactDetails>.GetById(int Id)
        {
            return (ContactDetails)_contactDataAdaptor.SelectById(Id);
        }
    }

}
