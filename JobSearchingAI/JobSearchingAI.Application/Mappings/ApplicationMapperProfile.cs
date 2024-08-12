namespace JobSearchingAI.Application.Mappings;

using AutoMapper;
using JobSearchingAI.Core.Entities;
using JobSearchingAI.Infraestructure.Service.Response;

public class ApplicationMapperProfile : Profile
{
    public ApplicationMapperProfile()
    {
        CreateMap<ApiJob, Job>()
            .ForMember(dest => dest.Id, opt => Guid.NewGuid())
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Title))
            .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description));

        CreateMap<ApiCompany, Company>()
            .ForMember(dest => dest.Id, opt => Guid.NewGuid())
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.DisplayName));
    }
}