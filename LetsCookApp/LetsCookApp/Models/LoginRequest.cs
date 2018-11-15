using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsCookApp.Models
{
    public class LoginRequest
    {
        public string email { get; set; }
        public string password { get; set; }
    }

    public class LoginResponse: BaseResponseModel
    {
        public virtual bool Succeeded { get; set; }
       

    }

    public class BaseResponseModel
    {
        public virtual int ErrorCode { get; set; }
        public virtual string ErrorMessage { get; set; }
    }


}
