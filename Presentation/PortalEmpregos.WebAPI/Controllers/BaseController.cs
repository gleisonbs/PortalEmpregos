using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortalEmpregos.Domain.Entities;
using PortalEmpregos.Application.Services;
using AutoMapper;

namespace PortalEmpregos.WebAPI.Controllers
{
    public class BaseController : ControllerBase
    {
        protected IMapper _mapper;
        public BaseController()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Company, CompanyDTO>();
            });

            _mapper = config.CreateMapper();
        }
    }
}
