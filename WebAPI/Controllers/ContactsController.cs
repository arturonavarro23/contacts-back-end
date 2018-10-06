using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Interfaces;
using WebAPI.Models;
using WebAPI.Models.ViewModel;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class ContactsController : Controller
    {

        readonly IContactsService contactsService;
        readonly IMapper mapper;
        public ContactsController(IContactsService contactsService, IMapper mapper) {
            this.contactsService = contactsService;
            this.mapper = mapper;
        }


        // GET: api/contacts
        [HttpGet]
        public IActionResult Get(int? page = 1, int pageSize = 4)
        {
            var contacts = contactsService.Get((int)page, pageSize);
            return Ok(contacts);
        }

        // GET api/contacts/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var contact = contactsService.GetById(id);
            return Ok(contact);
        }

        // POST api/contacts
        [HttpPost]
        public IActionResult Post([FromBody] PersonViewModel person)
        {
            var newPerson = contactsService.Insert(mapper.Map<Person>(person));
            return Ok(newPerson);
        }

        // PUT api/contacts
        [HttpPut]
        public IActionResult Put([FromBody] PersonViewModel person)
        {
            var updatedPerson = contactsService.Update(mapper.Map<Person>(person));
            return Ok(updatedPerson);
        }

        protected override void Dispose(bool disposing)
        {
            contactsService.Dispose();
            base.Dispose(disposing);
        }
    }
}
