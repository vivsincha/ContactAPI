using Contact.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.DAL
{
    public interface IContactDataAdaptor
    {
        bool Create(ContactDetails contactDetails);
        List<ContactDetails> Select();
        Object SelectById(int id);
        bool Update(ContactDetails contactDetails);
        bool Delete(int id);
        bool Activate(int id);
        bool Deactivate(int id);
    }
}
