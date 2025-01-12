using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ProductService
    {
        public static Mapper GetMapper()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Product, ProductDTO>();
                cfg.CreateMap<ProductDTO, Product>();
                cfg.CreateMap<Product, ProductCateDTO>();
                cfg.CreateMap<Category, CategoryDTO>();
            });
            return new Mapper(config);
        }
        public static List<ProductDTO> Get()
        {
            var repo = DataAccessFactory.ProductData();
            var data = repo.Get();
            return GetMapper().Map<List<ProductDTO>>(data);
        }
        public static ProductDTO Get(int id)
        {
            var repo = DataAccessFactory.ProductData();
            var data = repo.Get(id);
            return GetMapper().Map<ProductDTO>(data);
        }
        public static ProductCateDTO GetwithCate(int id ) {
            var repo = DataAccessFactory.ProductData();
            var data = repo.Get(id);
            return GetMapper().Map<ProductCateDTO>(data);

        }
    }
}
