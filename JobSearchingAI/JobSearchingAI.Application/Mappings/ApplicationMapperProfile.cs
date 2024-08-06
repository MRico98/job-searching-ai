namespace JobSearchingAI.Application.Mappings;

using AutoMapper;
using JobSearchingAI.Core.Entities;
using JobSearchingAI.Infraestructure.Service.Response;

public class ApplicationMapperProfile : Profile
{
    public ApplicationMapperProfile()
    {
        CreateMap<ApiJob, Job>()
            .ForMember(dest => dest.SalaryMax, opt => opt.MapFrom(src => src.SalaryMax))
            .ForMember(dest => dest.SalaryMin, opt => opt.MapFrom(src => src.SalaryMin))
            .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
            .ForMember(dest => dest.Longitud, opt => opt.MapFrom(src => src.Longitude))
            .ForMember(dest => dest.Latitud, opt => opt.MapFrom(src => src.Latitude))
            .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description));
    }
}