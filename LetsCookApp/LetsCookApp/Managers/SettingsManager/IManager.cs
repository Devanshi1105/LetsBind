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
        void getSubCategory(SubCategoryRequest commonRequest, Action success, Action<SubCategoryResponse> failed);
        void getDishView(DishViewRequest commonRequest, Action success, Action<DishViewResponse> failed);
        void getProfile(GetProfileRequest commonRequest, Action success, Action<ProfileResponse> failed);
        void Login(LoginRequest request, Action success, Action<BaseResponseModel> failed);
        void ForgetPassword(LoginRequest request, Action success, Action<BaseResponseModel> failed);

        void SignUp(SignupRequest commonRequest, Action success, Action<SignupResponse> failed);
        void SignUpUpdate(ProfileUpdateRequest commonRequest, Action success, Action<SignupResponse> failed);

        void getCountry(CommonRequest commonRequest, Action success);


        CategoryResponse CategoryResponse { get; }
        SubCategoryResponse SubCategoryResponse { get; }
        DishViewResponse DishViewResponse { get; }
        LoginResponse LoginResponse { get; }
        SignupResponse SignupResponse { get; }
        ProfileResponse ProfileResponse { get; }
        CountryResponse CountryResponse { get; }
    }
}
