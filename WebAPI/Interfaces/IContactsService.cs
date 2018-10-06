using System;
using WebAPI.Models;
using WebAPI.Models.ViewModel;

namespace WebAPI.Interfaces
{
    public interface IContactsService
    {
        PagedResult<PersonViewModel> Get(int page, int pageSize);
        PersonViewModel GetById(int perpesonId);
        PersonViewModel Insert(Person person);
        PersonViewModel Update(Person person);
        void Dispose();
    }
}
