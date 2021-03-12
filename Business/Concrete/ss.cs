using Business.Abstract;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using System.Collections.Generic;

namespace Business.ConCrete
{
    public class ss : IUserService
    {
        IUserDal _userDal;

        public ss(IUserDal userDal)
        {
            _userDal = userDal;
        }      
        public void Add(d user)
        {
            _userDal.Add(user);
        }

        public d GetByMail(string email)
        {
            return _userDal.Get(u => u.Email == email);
        }
        public List<OperationClaim> GetClaims(d user)
        {
            return _userDal.GetClaims(user);
        }
    }
}
