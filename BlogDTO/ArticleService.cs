using AutoMapper;
using BlogDAL.Interfaces;
using BlogDAL.Models;
using BlogDAL.Repository;
using BlogDTO.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDTO
{
    public class ArticleService
    {
        //todo make it generic
        private readonly IGenericRepository<Article> articleRep;
        public ArticleService()
        {
            articleRep = new GenericRepository<Article>();
            ConnectionStr = ConfigurationManager.ConnectionStrings["DBBLOG"].ConnectionString;
        }
        public string ConnectionStr { get; set; }
        public ArticleDTO GetById(int id)
        {
            var itemById=articleRep.FindById(id);
            var mappedItem = MapDALtoDTO(itemById);
            //todo add mapper
            //todo finish mapping all fields
            return mappedItem;// new ArticleDTO itemById;
        }
        private ArticleDTO MapDALtoDTO(Article curArticle)
        {
            var configuration = new MapperConfiguration(cfg => cfg.CreateMap<Article, ArticleDTO>());
            IMapper iMapper = configuration.CreateMapper();
            ArticleDTO curArticleDTO = iMapper.Map<Article, ArticleDTO>(curArticle);
            return curArticleDTO;
        }
    }
}
