using AutoMapper;
using Contracts;
using SearchService.Models;

namespace SearchService.RequesrHelpers;

public sealed class MappingProfiles: Profile
{
    public MappingProfiles()
    {
        CreateMap<AuctionCreated, Item>();
    }
}
