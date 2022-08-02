using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T>:DataResult<T>
    {
        //sen burada bana data ve mesaj ver sonucuda DataResultan al
        //ister sadece data ve mesaj ver
        public SuccessDataResult(T data,string message):base(data,true,message)
        {

        }
        //sadece data ver
        public SuccessDataResult(T data):base(data,true)
        {

        }
        //sadece mesaj ver
        public SuccessDataResult(string message):base(default,true,message)
        {

        }
        //hic bir sey verme
        public SuccessDataResult():base(default,true)
        {

        }
    }
}
