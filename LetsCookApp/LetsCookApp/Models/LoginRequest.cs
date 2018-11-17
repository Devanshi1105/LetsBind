using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsCookApp.Models
{
    public class LoginRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class LoginResponse: BaseResponseModel
    {
        public UserData UserData { get; set; }
    }
    public class UserData
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string EmailId { get; set; }
        public string PhotoURL { get; set; }
    }

    public class BaseResponseModel
    {
        public virtual string Message { get; set; }
        public virtual int StatusCode { get; set; }
        public virtual bool Success { get; set; }
    }


}
