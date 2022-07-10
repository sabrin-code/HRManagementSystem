using HrManagemntSystem.Application.Abstraction.Token;
using HrManagemntSystem.Application.Dtos;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrManagementSystem.Infrastructure.Operations
{
    public class TokenHandler : ITokenHandler
    {
        public readonly IConfiguration _configuration;
        public TokenHandler(IConfiguration configuration)
        {
            _configuration = configuration; 
        }
        public AccessTokenDto CreateAccessToken(int minute)
        {
            AccessTokenDto accessTokenDto = new AccessTokenDto();
            SymmetricSecurityKey symmetricSecurityKey = new(Encoding.UTF8.GetBytes(_configuration["Token:SecurityKey"]));
            SigningCredentials signingCredentials=new(symmetricSecurityKey,SecurityAlgorithms.HmacSha256);
            accessTokenDto.Expiration=DateTime.UtcNow.AddMinutes(minute);
            JwtSecurityToken securityToken = new(

                audience: _configuration["Token:Audience"],
                issuer: _configuration["Token:Issuer"],
                expires: accessTokenDto.Expiration,
                notBefore: DateTime.UtcNow,
                signingCredentials: signingCredentials


                );
            JwtSecurityTokenHandler jwtSecurityTokenHandler=new JwtSecurityTokenHandler();
            accessTokenDto.AccessToken=jwtSecurityTokenHandler.WriteToken(securityToken);
            return accessTokenDto;

            

        }
    }
}
