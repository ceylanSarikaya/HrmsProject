using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //2 parametreyi aynı anda verebiliriz burada ki consturactör overloding aşırı yüklenme diyoruz.
        //this: Result kendisidir. this demek classın kendisi demek
        //:this(success) :Bu kod result tek parametreli constructoruna succesi yolla yani 2 parametreli yerin aynı anda çalışmasını sağlıyor
        public Result(bool success,string message):this(success)
        {
            Message = message;
            //IsSuccess = success; bunu burada kaldırma sebebi buradaki consturactor aşagıdakınıde kapsıyor ve aynı işlem yapıldıgı icin gereksiz kod olmaması adına silinecek
        }
        //yanlızca success parametresi verebiliriz 
        public Result(bool success)
        {
            IsSuccess = success;
        }
        public bool IsSuccess { get; }

        public string Message { get; }
    }
}
