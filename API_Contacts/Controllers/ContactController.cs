﻿using System;
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
        [Route]
        [HttpGet]
        public HttpResponseMessage GetContactDetails()
        {
            try
            {
                var result = _contactRepository.GetAll();
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, result);
                return response;
            }
            catch (Exception ex)
            {
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
                return response;
            }
        }
        /// <summary>  
        /// Get Contact Detail  
        /// </summary>  
        /// <param name="ContactId"></param>  
        /// <returns></returns>  
        [Route("api/GetContact/{Id}")]
        [HttpPost]
        public HttpResponseMessage GetContact(int Id)
        {
            try
            {
                var result = _contactRepository.GetById(Id);
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, result);
                return response;
            }
            catch (Exception ex)
            {
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
                return response;
            }
        }
        /// <summary>  
        /// Delete Contact Detail  
        /// </summary>  
        /// <param name="ContactId"></param>  
        /// <returns></returns>  
        [Route("api/InsertContact")]
        [HttpPost]
        public HttpResponseMessage InsertContact(ContactDetails cd)
        {
            try
            {
                var result = _contactRepository.Insert(cd);
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, result);
                return response;
            }
            catch (Exception ex)
            {
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
                return response;
            }
        }

        [Route("api/DeleteContact/{id}")]
        [HttpPost]
        public HttpResponseMessage DeleteContact(int id)
        {
            try
            {
                var result = _contactRepository.Delete(id);
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, result);
                return response;
            }
            catch (Exception ex)
            {
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
                return response;
            }
        }
        /// <summary>  
        /// UpdateContact Detail  
        /// </summary>  
        /// <param name="ContactId"></param>  
        /// <returns></returns>  
        [Route("api/UpdateContact")]
        [HttpPost]
        public HttpResponseMessage UpdateContact(ContactDetails cd)
        {
            try
            {
                var result = _contactRepository.Update(cd);
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, result);
                return response;
            }
            catch (Exception ex)
            {
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
                return response;
            }
        }

        [Route("api/DeactivateContact/{id}")]
        [HttpPost]
        public HttpResponseMessage DeactivateContact(int id)
        {
            try
            {
                var result = _contactRepository.Deactivate(id);
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, result);
                return response;
            }
            catch (Exception ex)
            {
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
                return response;
            }
        }

        [Route("api/ActivateContact/{id}")]
        [HttpPost]
        public HttpResponseMessage ActivateContact(int id)
        {
            try
            {
                var result = _contactRepository.Activate(id);
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, result);
                return response;
            }
            catch (Exception ex)
            {
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
                return response;
            }
        }
    }
}
