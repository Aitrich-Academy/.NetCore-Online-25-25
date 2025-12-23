using AlishaMachineTest.Dto;
using AlishaMachineTest.Model;
using AutoMapper;

namespace AlishaMachineTest.Helper
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Book, BookDto>().ReverseMap();
        }
    }
}
