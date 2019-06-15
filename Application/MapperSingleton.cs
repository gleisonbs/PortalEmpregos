using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PortalEmpregos.Domain.Entities;
using AutoMapper;

namespace PortalEmpregos.Application.Services
{
    public class MapperSingleton
    {
        private MapperSingleton() {}

        private static IMapper _mapper;
        public static IMapper Instance 
        {
            get 
            {
                if (_mapper is null)
                {
                    var config = new MapperConfiguration(cfg => {
                        cfg.CreateMap<Company, CompanyDTO>();
                        cfg.CreateMap<CompanyDTO, Company>();
                        cfg.CreateMap<JobOpening, JobOpeningDTO>();
                        cfg.CreateMap<JobOpeningDTO, JobOpening>();
                    });

                    _mapper = config.CreateMapper();
                }

                return _mapper;
            }
        }
    }
}
