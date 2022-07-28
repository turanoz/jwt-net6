using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JwtIdentity.Core.Configuration;
using JwtIdentity.Core.Dtos;
using JwtIdentity.Core.Entities;

namespace JwtIdentity.Core.Services
{
    public interface ITokenService
    {
        TokenDto CreateToken(UserApp userApp);
        ClientTokenDto CreateTokenByClient(Client client);
    }
}
