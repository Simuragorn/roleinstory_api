using AutoMapper;
using EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RoleInStory.Application.Services.Locations.Dtos;
using RoleInStory.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleInStory.Application.Services.Locations
{
    public class LocationService : ILocationService
    {
        private readonly RoleInStoryContext _dbContext;
        private readonly IMapper _mapper;
        public LocationService(RoleInStoryContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<List<LocationDto>> GetAllAsync()
        {
            List<Location> locations = await _dbContext.Locations.AsNoTracking().ToListAsync();
            return _mapper.Map<List<LocationDto>>(locations);
        }
    }
}
