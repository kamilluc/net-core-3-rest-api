using AutoMapper;
using RestApi.Dtos;
using RestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApi.Profiles
{
    public class CommandsProfie : Profile
    {
        public CommandsProfie()
        {
            CreateMap<Command, CommandReadDto>();
        }
    }
}
