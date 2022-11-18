using AutoMapper;
using Dreamer.Application.Models.SampleModels;
using Dreamer.Domain.Entities;

namespace Dreamer.Application.Profiles;

public class SampleProfile : Profile
{
    public SampleProfile()
    {
        CreateMap<Sample, SampleSingleModel>();
    }
}