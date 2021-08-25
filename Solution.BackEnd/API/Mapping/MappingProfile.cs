using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using data = DAL.DO.Objects;

namespace API.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<data.Marcas, DataModels.Marcas>().ReverseMap();
            CreateMap<data.Modelos, DataModels.Modelos>().ReverseMap();
            CreateMap<data.Autos, DataModels.Autos>().ReverseMap();
            CreateMap<data.TiposAutos, DataModels.TiposAutos>().ReverseMap();
            CreateMap<data.Estado, DataModels.Estado>().ReverseMap();
            CreateMap<data.Combustible, DataModels.Combustible>().ReverseMap();
            CreateMap<data.Transmisiones, DataModels.Transmisiones>().ReverseMap();
            CreateMap<data.AspNetUsers, DataModels.AspNetUsers>().ReverseMap();

        }

    }
}
