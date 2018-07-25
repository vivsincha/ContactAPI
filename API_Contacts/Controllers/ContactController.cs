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
        private IRepository<ContactDetails> _contactRepository = null;
        public ContactController(IRepository<ContactDetails> contactRepo)
        {
            _contactRepository = contactRepo;
        }
        /// <summary>  
        /// Get Contact List  
        /// </summary>  
        /// <returns></returns>  
        [Route("api/GetContacts")]
        [HttpGet]
        public HttpResponseMessage GetContactDetail()
        {
            var result = _contactRepository.GetAll();
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
            var result = _contactRepository.GetById(ContactId);
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
            var result = _contactRepository.Delete(ContactId);
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
        public HttpResponseMessage UpdateContact(ContactDetails cd)
        {
            var result = _contactRepository.Update(cd);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, result);
            return response;
        }
    }
}
