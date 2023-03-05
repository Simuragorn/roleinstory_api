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

        public async Task<IReadOnlyList<LocationDto>> GetAllAsync()
        {
            List<Location> locations = await _dbContext.Locations.AsNoTracking().ToListAsync();
            return _mapper.Map<List<LocationDto>>(locations);
        }

        public async Task<LocationDto> CreateAsync(LocationDto locationDto)
        {
            Location location = _mapper.Map<Location>(locationDto);
            var addedLocation = await _dbContext.Locations.AddAsync(location);
            await _dbContext.SaveChangesAsync();
            return _mapper.Map<LocationDto>(addedLocation.Entity);
        }

        public async Task<LocationDto> UpdateAsync(LocationDto location)
        {
            Location existingLocation = await _dbContext.Locations.FirstOrDefaultAsync(l => l.Id == location.Id);
            if (existingLocation == null)
            {
                throw new Exception("Location does not exist");
            }
            existingLocation = _mapper.Map(location, existingLocation);
            var updatedLocation = _dbContext.Locations.Update(existingLocation);
            await _dbContext.SaveChangesAsync();
            return _mapper.Map<LocationDto>(updatedLocation.Entity);
        }
    }
}
