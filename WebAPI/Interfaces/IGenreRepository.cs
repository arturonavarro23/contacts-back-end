using System;
using System.Collections.Generic;
using WebAPI.Models.ViewModel;

namespace WebAPI.Interfaces
{
    public interface IGenreRepository: IDisposable
    {
        IEnumerable<GenreViewModel> GetAllGenres();
    }
}
