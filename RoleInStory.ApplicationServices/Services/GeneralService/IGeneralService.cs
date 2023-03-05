using RoleInStory.Application.Dtos;
using RoleInStory.Core.Entities;

namespace RoleInStory.Business.Services.BaseService
{
    public interface IGeneralService<Entity, EntityDto>
       where Entity : BaseEntity
       where EntityDto : BaseEntityDto
    {

        public Task<List<EntityDto>> GetAllAsync();

        public Task<EntityDto> GetAsync(int id);

        public Task<EntityDto> CreateAsync(EntityDto dto);

        public Task<EntityDto> UpdateAsync(EntityDto dto);

        public Task<EntityDto> DeleteAsync(int id);
    }
}
