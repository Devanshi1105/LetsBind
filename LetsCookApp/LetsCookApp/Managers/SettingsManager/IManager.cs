using LetsCookApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsCookApp.Managers.SettingsManager
{
    public interface IManager
    {
        void getAllCategory(CommonRequest commonRequest, Action success, Action<CategoryResponse> failed);

        void Login(LoginRequest commonRequest, Action success, Action<LoginResponse> failed);
        void SignUp(SignupRequest commonRequest, Action success, Action<SignupResponse> failed);

        CategoryResponse CategoryResponse { get; }
        LoginResponse LoginResponse { get; }
        SignupResponse SignupResponse { get; }
    }
}
