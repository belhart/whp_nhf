﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace F1Stats.Web.Models
{
    public class MapperFactory
    {
        public static IMapper CreateMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<F1Stats.Data.Versenyzo, F1Stats.Web.Models.Versenyzo>().
                ForMember(dest => dest.Rajtszam, map => map.MapFrom(src => src.rajtszam)).
                ForMember(dest => dest.Nev, map => map.MapFrom(src => src.nev)).
                ForMember(dest => dest.CsapatNev, map => map.MapFrom(src => src.csapat_nev)).
                ForMember(dest => dest.Eletkor, map => map.MapFrom(src => src.eletkor)).
                ForMember(dest => dest.OsszPont, map => map.MapFrom(src => src.ossz_pont)).
                ForMember(dest => dest.IdenybeliPont, map => map.MapFrom(src => src.idenybeli_pont));
            });

            return config.CreateMapper();
        }
    }
}