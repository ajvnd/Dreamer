using AutoMapper;
using Dreamer.Application.Features.Sample.Models.SampleModels;

namespace Dreamer.Application.Features.Sample.Profiles;

public class SampleProfile : Profile
{
    public SampleProfile()
    {
        CreateMap<Domain.Entities.Sample, SampleSingleModel>();
    }
}