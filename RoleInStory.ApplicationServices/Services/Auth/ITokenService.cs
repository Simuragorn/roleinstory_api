using RoleInStory.Core.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleInStory.Business.Services.Auth
{
    public interface ITokenService
    {
        public string CreateToken(AppUser user);
    }
}
