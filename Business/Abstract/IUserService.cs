using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {     
        List<OperationClaim> GetClaims(d user);
        void Add(d user);
        d GetByMail(string email);
    }
}
