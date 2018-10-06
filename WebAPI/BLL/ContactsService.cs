using System;
using WebAPI.Interfaces;
using WebAPI.Models;
using WebAPI.Models.ViewModel;

namespace WebAPI.BLL
{
	public class ContactsService: IContactsService
    {
        readonly IContactsRepository repository;

        public ContactsService(IContactsRepository repository)
        {
            this.repository = repository;
        }

        public void Dispose()
        {
            repository.Dispose();
        }

        public PagedResult<PersonViewModel> Get(int page, int pageSize)
        {
            return repository.Get(page, pageSize);
        }

        public PersonViewModel GetById(int perpesonId)
        {
            return repository.GetById(perpesonId);
        }

        public PersonViewModel Insert(Person person)
        {
            return repository.Insert(person);
        }

        public PersonViewModel Update(Person person)
        {
            return repository.Update(person);
        }
    }
}
