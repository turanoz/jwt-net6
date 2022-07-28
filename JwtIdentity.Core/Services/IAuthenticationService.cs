﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JwtIdentity.Core.Dtos;
using JwtIdentity.Shared.Dtos;

namespace JwtIdentity.Core.Services
{
    public interface IAuthenticationService
    {
        Task<Response<TokenDto>> CreateTokenAsync(LoginDto loginDto);
        Task<Response<TokenDto>> CreateTokenByRefreshTokenAsync(string refreshToken);
        Task<Response<NoDataDto>> RevokeRefreshTokenAsync(string refreshToken);
        Response<ClientTokenDto> CreateTokenByClient(ClientLoginDto clientLoginDto);
    }
}