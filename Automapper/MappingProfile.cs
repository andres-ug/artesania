namespace artesania.Automapper;

using AutoMapper;
using artesania.DTOs;
using artesania.Entities;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Product, ProductDto>().ReverseMap();
        CreateMap<ShoppingCart, ShoppingCartDto>().ReverseMap();
    }
}