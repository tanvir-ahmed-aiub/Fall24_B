using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class StudentService
    {
        public static List<StudentDTO> GetAll() {
            var srepo = DataAccess.StudentData();
            var data = srepo.Get();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Student,StudentDTO>();
            });
            var mapper = new Mapper(config); ;
            var ret = mapper.Map<List<StudentDTO>>(data);

            return  ret;
            
        }
        public static StudentDTO Get(int id)
        {
            var srepo = DataAccess.StudentData();
            var data = srepo.Get(id);
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Student, StudentDTO>();
            });
            var mapper = new Mapper(config); ;
            var ret = mapper.Map<StudentDTO>(data);

            return ret;

        }
        public static void Create(StudentDTO s)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<StudentDTO, Student>();
            });
            var mapper = new Mapper(config); ;
            var st = mapper.Map<Student>(s);
            var repo = DataAccess.StudentData();
            repo.Add(st);

        }
    }
}
