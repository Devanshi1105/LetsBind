using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsCookApp.Models
{
   public class SignupRequest
    {
        public string email { get; set; }
        public string Member_Name { get; set; }
        public string password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mobile_Phone { get; set; }
        public string phone_number { get; set; }
        public string Add1 { get; set; }
        public string Add2 { get; set; }
        public string City { get; set; }
        public string state { get; set; }
        public string Country { get; set; }
        public string Postcode { get; set; }
        public string Hobbies { get; set; }
        public string Picture { get; set; }
    }
    public class SignupResponse : BaseResponseModel
    {
        public virtual bool Succeeded { get; set; }


    }
}
