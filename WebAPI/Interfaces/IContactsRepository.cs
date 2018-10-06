using System;
using System.Collections.Generic;
using WebAPI.Models;
using WebAPI.Models.ViewModel;

namespace WebAPI.Interfaces
{
    public interface IContactsRepository : IDisposable
    {
        PagedResult<PersonViewModel> Get(int page, int pageSize);
        PersonViewModel GetById(int perpesonId);
        PersonViewModel Insert(Person person);
        PersonViewModel Update(Person person);
    }
}
