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
        void getProfile(LoginRequest commonRequest, Action success, Action<ProfileResponse> failed);
        void Login(LoginRequest request, Action success, Action<BaseResponseModel> failed);
        void ForgetPassword(LoginRequest request, Action success, Action<BaseResponseModel> failed);

        void SignUp(SignupRequest commonRequest, Action success, Action<SignupResponse> failed);
        void SignUpUpdate(SignupRequest commonRequest, Action success, Action<SignupResponse> failed);

        CategoryResponse CategoryResponse { get; }
        LoginResponse LoginResponse { get; }
        SignupResponse SignupResponse { get; }
        ProfileResponse ProfileResponse { get; }
    }
}
