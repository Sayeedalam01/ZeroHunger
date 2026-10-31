using AutoMapper;
using BLL.Models;
using DAL.EF.Tables;

namespace BLL
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Employee, EmployeeModel>().ReverseMap();
            CreateMap<CollectRequest, CollectRequestModel>().ReverseMap();
            CreateMap<FoodItem, FoodItemModel>().ReverseMap();
            CreateMap<Restaurant, RestaurantModel>().ReverseMap();
        }
    }
}