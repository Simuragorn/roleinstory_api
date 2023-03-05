using AutoMapper;
using EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RoleInStory.Application.Dtos;
using RoleInStory.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleInStory.Business.Services.BaseService
{
    public class GeneralService<Entity, EntityDto> : IGeneralService<Entity, EntityDto>
       where Entity : BaseEntity
       where EntityDto : BaseEntityDto
    {
        protected readonly RoleInStoryContext _dbContext;
        protected readonly IMapper _mapper;
        public GeneralService(RoleInStoryContext context, IMapper mapper)
        {
            _dbContext = context;
            _mapper = mapper;
        }

        public async Task<List<EntityDto>> GetAllAsync()
        {
            List<Entity> existingEntities = await _dbContext.Set<Entity>().AsNoTracking().ToListAsync();
            return _mapper.Map<List<EntityDto>>(existingEntities);
        }

        public async Task<EntityDto> GetAsync(int id)
        {
            Entity existingEntity = await _dbContext.Set<Entity>().AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
            return _mapper.Map<EntityDto>(existingEntity);
        }

        public async Task<EntityDto> CreateAsync(EntityDto dto)
        {
            var entity = _mapper.Map<Entity>(dto);
            var addedEntity = await _dbContext.Set<Entity>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return _mapper.Map<EntityDto>(addedEntity.Entity);
        }

        public async Task<EntityDto> UpdateAsync(EntityDto dto)
        {
            Entity existingEntity = await _dbContext.Set<Entity>().FirstOrDefaultAsync(e => e.Id == dto.Id);
            if (existingEntity == null)
            {
                throw new Exception("Entity does not exist");
            }
            existingEntity = _mapper.Map(dto, existingEntity);
            _dbContext.Set<Entity>().Update(existingEntity);
            await _dbContext.SaveChangesAsync();
            return _mapper.Map<EntityDto>(existingEntity);
        }

        public async Task<EntityDto> DeleteAsync(int id)
        {
            Entity existingEntity = await _dbContext.Set<Entity>().AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
            if (existingEntity == null)
            {
                throw new Exception($"Unable to delete entity");
            }
            await _dbContext.Set<Entity>().Where(e => e.Id == id).ExecuteDeleteAsync();
            return _mapper.Map<EntityDto>(existingEntity);
        }
    }
}
