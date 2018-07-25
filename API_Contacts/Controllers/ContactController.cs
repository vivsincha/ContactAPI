using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Contact.Model;
using API_Contacts.Repository;

namespace API_Contacts.Controllers
{
    public class ContactController : ApiController
    {
        private IRepository<ContactDetail> _Contactrepository = null;
        public ContactController()
        {
            this._Contactrepository = new Repository<ContactDetail>();
        }
       /// <summary>  
        /// Get Contact List  
        /// </summary>  
        /// <returns></returns>  
        [Route("api/GetContacts")]
        [HttpGet]
    public HttpResponseMessage GetContactDetail()
        {
            var result = _Contactrepository.GetAll();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, result);
            return response;
        }
        /// <summary>  
        /// Get Contact Detail  
        /// </summary>  
        /// <param name="ContactId"></param>  
        /// <returns></returns>  
        [Route("api/GetContact")]
        [HttpGet]
        public HttpResponseMessage GetContact(int ContactId)
        {
            var result = _Contactrepository.GetById(ContactId);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, result);
            return response;
        }
        /// <summary>  
        /// Delete Contact Detail  
        /// </summary>  
        /// <param name="ContactId"></param>  
        /// <returns></returns>  
        [Route("api/DeleteContact")]
        [HttpGet]
        public HttpResponseMessage DeleteContact(int ContactId)
        {
            var result = _Contactrepository.Delete(ContactId);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, result);
            return response;
        }
        /// <summary>  
        /// UpdateContact Detail  
        /// </summary>  
        /// <param name="ContactId"></param>  
        /// <returns></returns>  
        [Route("api/UpdateContact")]
        [HttpGet]
        public HttpResponseMessage UpdateContact(ContactDetail cd)
        {
            var result = _Contactrepository.Update(cd);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, result);
            return response;
        }
    }
}
