using Business.Abstract;
using Business.Contants;
using Core.Utilities.Result.Abstarct;
using Core.Utilities.Result.Concrete;
using DataAccess.Abstarct;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BookManager : IBookService
    {
        IBookDal _bookDal;

        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }

        public IResult Add(Book book)
        {
            _bookDal.Add(book);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Book book)
        {
            _bookDal.Delete(book);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Book>> GetAll(int id)
        {
           return new SuccessDataResult<List<Book>> (_bookDal.GetAll(x=>x.Id==id),Messages.Listed);
        }

        public IResult Update(Book book)
        {
            _bookDal.Update(book);
            return new SuccessResult(Messages.Updated);
        }
    }
}
