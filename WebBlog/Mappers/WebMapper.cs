using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebBlog.Mappers
{
    public static class WebMapper <T,K> where T : class
        where K:class
    {
        public static T MapDTOtoView(K DTOItem) 
        {
            var configuration = new MapperConfiguration(cfg => cfg.CreateMap<K, T>());
            IMapper iMapper = configuration.CreateMapper();
            T curViewModel = iMapper.Map<K, T>(DTOItem);
            return curViewModel;

        }
    }
}