using AutoMapper;
using Dreamer.Application.Models.SampleModel;
using Dreamer.Domain.Entity;

namespace Dreamer.Application.Profiles;

public class SampleProfile : Profile
{
    public SampleProfile()
    {
        CreateMap<Sample, SampleSingleModel>();
    }
}