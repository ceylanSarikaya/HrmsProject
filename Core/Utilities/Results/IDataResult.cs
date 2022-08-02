using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    //void işlemimiz aynı zamanda mesage ,işlem sonuçu ve data içermesi için
    public interface IDataResult<T>:IResult
    {
        //t türünde bir data olucak
        T Data { get; }
    }
}
