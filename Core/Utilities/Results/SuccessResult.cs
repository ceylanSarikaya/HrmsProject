using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessResult:Result
    {
        //base:inhertiance bahs ettiğimiz resultur.
        //Miras aldığımız Result da işlemimiz doğru ise true dondurecek ve mesaj verecek ancaka yanlız mesaj vermeden de 
        //göndermek icicn tek parametreli consturactör oluşturduk
        public SuccessResult(string message) : base(true,message)
        {

        }
        public SuccessResult() : base(true)
        {

        }
    }
}
