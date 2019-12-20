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
        public async Task<ArticleDTO> GetById(int id)
        {
            
            var itemById= await articleRep.FindById(id);
            var mappedItem = MapDALtoDTO(itemById);
            return mappedItem;// new ArticleDTO itemById;
            
        }
        private ArticleDTO MapDALtoDTO(Article curArticle)
        {
            var configuration = new MapperConfiguration(cfg => cfg.CreateMap<Article, ArticleDTO>());
            IMapper iMapper = configuration.CreateMapper();
            ArticleDTO curArticleDTO = iMapper.Map<Article, ArticleDTO>(curArticle);
            return curArticleDTO;
        }
        private Task<ArticleDTO> MapDALtoDTO(Task<Article> curArticle)
        {
            var configuration = new MapperConfiguration(cfg => cfg.CreateMap<Task<Article>, Task<ArticleDTO>>());
            IMapper iMapper = configuration.CreateMapper();
            Task<ArticleDTO> curArticleDTO = iMapper.Map<Task<Article>, Task<ArticleDTO>>(curArticle);
            return curArticleDTO;
        }
    }
}
