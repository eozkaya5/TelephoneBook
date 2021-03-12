using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Result.Abstarct
{
    public interface IResult
    {
        bool Success { get; }//sadece okunabilir(set; yaz demek)
        string Message { get; }
    }
}
