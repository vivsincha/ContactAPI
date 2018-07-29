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

        public ContactDetails GetById(int Id)
        {

            return (ContactDetails)_contactDataAdaptor.SelectById(Id);
        }

        bool IRepository<ContactDetails>.Insert(ContactDetails obj)
        {
            return _contactDataAdaptor.Create(obj);
        }
        
       public bool Delete(object Id)
        {
            return _contactDataAdaptor.Delete((int)Id);
        }

        public bool Deactivate(object Id)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        
    }

    //public class ContactsRepository<T> : IRepository<T> where T : class
    //{
    //    private ContactDbEntities context;
    //    //-- -- -- -- -- -- -- -- -- -- - > represent edmx context name
    //    private DbSet<T> dbSet;
    //    //-- -- -- -- -- -- -- -- -- -- -- -- -- - > represent respective table to perform certain operations
    //    public ContactsRepository()
    //    {
    //        context = new ContactDbEntities();
    //        dbSet = context.Set<T>();
    //    }
    //    public IEnumerable<T> GetAll()/* -- -- -- -- -- -- -- -- -- > To get all data from respective table */
    //    {
    //        return dbSet.ToList();
    //    }
    //    public T GetById(object id) /*-- -- -- -- -- -- -- -- -- -- -- -- - > To get particular row data based on id(this id field should be the primary key field)*/
    //    {
    //        return dbSet.Find(id);
    //    }
    //    public T Insert(T obj)/* -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- > Add new record to respectiv table*/
    //    {
    //        dbSet.Add(obj);
    //        Save();
    //        return obj;
    //    }
    //    public void Delete(object id) /*-- -- -- -- -- -- -- -- -- -- > Delete respective record from respective table based on primarykey id*/
    //    {
    //        T entityToDelete = dbSet.Find(id);
    //        Delete(entityToDelete);
    //    }
    //    public void Delete(T entityToDelete)
    //    //-- -- -- -- -- -- -- -- -- > this is to record the state as detached  
    //    //while we deleting data from table
    //    {
    //        if (context.Entry(entityToDelete).State == EntityState.Detached)
    //        {
    //            dbSet.Attach(entityToDelete);
    //            //-- -- -- -- -- -- -- -- -- -- -- -- > it add the row like in particular table, particular field, particular value has been deleted with timestamps.
    //        }
    //        dbSet.Remove(entityToDelete);
    //    }
    //    public T Update(T obj)/* -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- > it 's to update the existing record */
    //    {
    //        dbSet.Attach(obj);
    //        context.Entry(obj).State = EntityState.Modified;
    //        //-- -- -- -- -- - > same to record the modified state and where, what and when
    //        Save();
    //        return obj;
    //    }
    //    public void Save()
    //    {
    //        try
    //        {
    //            context.SaveChanges();
    //            //----------------------------------------- > to keep changing the entityframe as well db
    //        }
    //        catch (Exception dbEx)
    //        {
    //            //foreach (var validationErrors in dbEx.EntityValidationErrors)
    //            //{
    //            //    foreach (var validationError in validationErrors.ValidationErrors)
    //            //    {
    //            //        System.Console.WriteLine("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
    //            //        //--- > you just put the log to know the errors
    //            //        }
    //            //}
    //        }
    //    }
    //    protected virtual void Dispose(bool disposing) /*-- -- -- -- -- -- -- - > this dispose method after very instance*/
    //    {
    //        if (disposing)
    //        {
    //            if (context != null)
    //            {
    //                context.Dispose();
    //                context = null;
    //            }
    //        }
    //    }

    //    string IRepository<T>.Delete(object Id)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
