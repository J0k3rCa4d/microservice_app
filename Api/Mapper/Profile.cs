using AutoMapper;
using Api.Data;
using Api.Dto;
using Api.Services;

namespace Api.Mapper
{
    public class MapsProfile : Profile
    {
        public MapsProfile()
        {
            CreateMap<ExampleRequest, Example>()
                .ForMember(dst => dst.Name, opts => opts.MapFrom( src => src.name ))
                .ForMember(dst => dst.Timestamp, opts => opts.MapFrom( src => src.t))
                .ForMember(dst => dst.Value, opts => opts.MapFrom( src => src.v ));
        }
    }
}