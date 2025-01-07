using AutoMapper;
using BLL.DTOs;
using DAL.EF;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class CourseService
    {
        public static Mapper getMapper() {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<CourseDTO, Course>();
                cfg.CreateMap<Course, CourseDTO>();
            });
            var mapper = new Mapper(config);
            return mapper;
        }
        public static List<CourseDTO> Get() {
            var data = new CourseRepo().Get();
            return getMapper().Map<List<CourseDTO>>(data);
        }
    }
}
