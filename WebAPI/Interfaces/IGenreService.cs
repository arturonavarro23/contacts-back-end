using System;
using System.Collections.Generic;
using WebAPI.Models.ViewModel;

namespace WebAPI.Interfaces
{
    public interface IGenreService
    {
        IEnumerable<GenreViewModel> GetAllGenres();
        void Dispose();
    }
}
