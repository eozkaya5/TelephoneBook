using Core.Entities.Concrete;
using Core.Utilities.Result.Abstarct;
using Core.Utilities.Security.Jwt;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISecurityService
    {
        IDataResult<d> Register(UserForRegisterDto userForRegisterDto, string password);
        IDataResult<d> Login(UserForLoginDto userForLoginDto);
        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(d user);
    }
}
