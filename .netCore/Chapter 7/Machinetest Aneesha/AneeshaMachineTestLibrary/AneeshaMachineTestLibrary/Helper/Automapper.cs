using AneeshaMachineTestLibrary.DTO;
using AneeshaMachineTestLibrary.Model;
using AutoMapper;

namespace AneeshaMachineTestLibrary.Helper;

public class Automapper : Profile
{
    public Automapper()
    {
       CreateMap<Book, BookDto>().ReverseMap();
    }
    
}