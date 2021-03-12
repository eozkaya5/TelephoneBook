using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstarct;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Conctere.EntityFramewok
{
    public class EfBookDal:EfEntityRepositoryBase<Book,BookDbContext>,IBookDal
    {
    }
}
