using System;
using AutoMapper;
using WebAPI.Models;
using WebAPI.Models.ViewModel;

namespace WebAPI.MapperProfile
{
    public class MapperProfile: Profile
    {
        public MapperProfile()
        {
            CreateMap<Person, PersonViewModel>();
            CreateMap<PersonViewModel, Person>();
        }
    }
}
