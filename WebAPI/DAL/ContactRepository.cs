using System;
using System.Linq;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WebAPI.Context;
using WebAPI.Interfaces;
using WebAPI.Models;
using WebAPI.Models.ViewModel;
using WebAPI.Utils;

namespace WebAPI.DAL
{
    public class ContactRepository: IContactsRepository, IDisposable
    {

        readonly ContextAPI context;
        readonly IMapper mapper;
        bool disposed;

        public ContactRepository(ContextAPI context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public PagedResult<PersonViewModel> Get(int page, int pageSize)
        {
            return context.Person
                          .GetPaged<PersonViewModel, Person>((int)page, pageSize, mapper);
        }


        public PersonViewModel GetById(int pesonId)
        {
            var person = context.Person
                               .SingleOrDefault(m => m.ID == pesonId);

            return mapper.Map<PersonViewModel>(person);
        }

        public PersonViewModel Update(Person person)
        {
            context.Entry(person).State = EntityState.Modified;
            context.SaveChanges();
            return mapper.Map<PersonViewModel>(person);
        }

        public PersonViewModel Insert(Person person)
        {
            context.Person.Add(person);
            context.SaveChanges();
            return GetById(person.ID);
        }
    }
}
