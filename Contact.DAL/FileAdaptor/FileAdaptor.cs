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
        private readonly string _filePath;
        public FileAdaptor()
        {
            _filePath = AppDomain.CurrentDomain.BaseDirectory + "\\bin\\FileAdaptor\\DummyData\\ContactsData.json";
            
        }

        public List<ContactDetails> Select()
        {
            if (!File.Exists(_filePath))
                return JsonConvert.DeserializeObject<List<ContactDetails>>(File.ReadAllText(_filePath));
            else
                return new List<ContactDetails>();
        }

        public object SelectById(int id)
        {
            if (!File.Exists(_filePath))
            {
                List<ContactDetails> lstcontact = JsonConvert.DeserializeObject<List<ContactDetails>>(File.ReadAllText(_filePath));
                if (lstcontact.Find(x => x.ContactId == id) != null)
                {
                    return lstcontact.Find(x => x.ContactId == id);
                }
                return null;
            }
            else
                return null;
        }

        public bool Create(ContactDetails contactDetails)
        {
            if (!File.Exists(_filePath))
            {
                var jsondata = File.ReadAllText(_filePath);
                List<ContactDetails> lstcontact = JsonConvert.DeserializeObject<List<ContactDetails>>(jsondata);
                lstcontact.Add(contactDetails);
                jsondata = JsonConvert.SerializeObject(lstcontact);
                File.WriteAllText(_filePath, jsondata);
                return true;
            }
            else
                return false;
        }

        public bool Delete(int id)
        {
            if (!File.Exists(_filePath))
            {
                var jsondata = File.ReadAllText(_filePath);
                List<ContactDetails> lstcontact = JsonConvert.DeserializeObject<List<ContactDetails>>(jsondata);
                if (lstcontact.Find(x => x.ContactId == id) != null)
                {
                    lstcontact.Remove(lstcontact.Find(x => x.ContactId == id));
                    jsondata = JsonConvert.SerializeObject(lstcontact);
                    File.WriteAllText(_filePath, jsondata);
                    return true;
                }
                else
                    return false;

            }
            else
                return false;
        }

       

        public bool Update(ContactDetails contactDetails)
        {
            if (!File.Exists(_filePath))
            {
                var jsondata = File.ReadAllText(_filePath);
                List<ContactDetails> lstcontact = JsonConvert.DeserializeObject<List<ContactDetails>>(jsondata);
                lstcontact.Remove(lstcontact.Find(x => x.ContactId == contactDetails.ContactId));
                lstcontact.Add(contactDetails);
                jsondata = JsonConvert.SerializeObject(lstcontact);
                File.WriteAllText(_filePath, jsondata);
                return true;
            }
            else
                return false;
        }
        public bool Activate(int id)
        {
            if (!File.Exists(_filePath))
            {
                ContactDetails cd = new ContactDetails();
                var jsondata = File.ReadAllText(_filePath);
                List<ContactDetails> lstcontact = JsonConvert.DeserializeObject<List<ContactDetails>>(jsondata);
                cd = lstcontact.Find(x => x.ContactId == id);
                if (cd.IsActive == false && lstcontact.Find(x => x.ContactId == id) != null)
                {
                    cd.IsActive = true;
                    lstcontact.Remove(lstcontact.Find(x => x.ContactId == id));
                    lstcontact.Add(cd);
                    jsondata = JsonConvert.SerializeObject(lstcontact);
                    File.WriteAllText(_filePath, jsondata);
                    return true;
                }
                else
                    return false;

            }
            else
                return false;

        }
        public bool Deactivate(int id)
        {
            if (!File.Exists(_filePath))
            {
                ContactDetails cd = new ContactDetails();
                var jsondata = File.ReadAllText(_filePath);
                List<ContactDetails> lstcontact = JsonConvert.DeserializeObject<List<ContactDetails>>(jsondata);
                cd = lstcontact.Find(x => x.ContactId == id);
                if (cd.IsActive == true && lstcontact.Find(x => x.ContactId == id) != null)
                {
                    cd.IsActive = false;
                    lstcontact.Remove(lstcontact.Find(x => x.ContactId == id));
                    lstcontact.Add(cd);
                    jsondata = JsonConvert.SerializeObject(lstcontact);
                    File.WriteAllText(_filePath, jsondata);
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }

       
    }
}
