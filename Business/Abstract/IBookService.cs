using Core.Utilities.Result.Abstarct;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBookService
    {
        IResult Add(Book book);
        IResult Update(Book book);
        IResult Delete(Book book);
        IDataResult<List<Book>> GetById(int id);
        IDataResult<List<Book>> Get();

    }
}
