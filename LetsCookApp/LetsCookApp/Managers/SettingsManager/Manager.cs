using Acr.UserDialogs;
using LetsCookApp.Managers.ApiProvider;
using LetsCookApp.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LetsCookApp.Managers.SettingsManager
{
    public class Manager : IManager
    {
        private readonly IApiProvider _apiProvider;
        private readonly ISettingsManager _settingsManager;

        public CategoryResponse CategoryResponse { get { return categoryResponse; } }

        public ProfileResponse ProfileResponse { get { return profileResponse; } } 
        public LoginResponse LoginResponse { get { return loginResponse; } }

        public SignupResponse SignupResponse { get { return signupResponse; } }

        public CountryResponse CountryResponse { get { return countryResponse; } }
        public Manager(IApiProvider apiProvider, ISettingsManager settingsManager)
        {
            _apiProvider = apiProvider;
            _settingsManager = settingsManager;
        }
        #region Header
        public Dictionary<string, string> GetHeaders()
        {
            Dictionary<string, string> header = new Dictionary<string, string>();
           // header.Add("Authorization", "Basic " + Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes("LetsCookApp" + ":" + "LetsCookApp")));
            return header;
        }

        #endregion
        string error = "Please Check Internet Connection.";
        private CategoryResponse categoryResponse { get; set; }
        private ProfileResponse profileResponse { get; set; }
        private CountryResponse countryResponse { get; set; }


        private LoginResponse loginResponse { get; set; }
        private SignupResponse signupResponse { get; set; }
        public async void  getAllCategory(CommonRequest commonRequest, Action success, Action<CategoryResponse> failed)
        {
            bool IsNetwork = true;//await DependencyService.Get<IMediaService>().CheckNewworkConnectivity();
            if (IsNetwork)
            {

                var url = string.Format("{0}getAllCategories.php", _settingsManager.ApiHost);

                await Task.Run(async () =>
                {
                    Dictionary<string, string> head = GetHeaders();
                    var result =  _apiProvider.Get<CategoryResponse, CommonRequest>(url,  null).Result;
                    if (result.IsSuccessful)
                    {
                        if (success != null)
                        {
                            categoryResponse = result.Result;
                            success.Invoke();
                        }
                    }
                    else
                    {
                        failed.Invoke(result.Result);
                    }
                });
            }
            else
            {
                UserDialogs.Instance.HideLoading(); UserDialogs.Instance.Alert(error, null, "OK");
            }
        }

        public async void getProfile(GetProfileRequest commonRequest, Action success, Action<ProfileResponse> failed)
        {
            bool IsNetwork = true;//await DependencyService.Get<IMediaService>().CheckNewworkConnectivity();
            if (IsNetwork)
            {
                //commonRequest.Email = "ksantosh.kundkar12@gmail.com";
                //commonRequest.Password = "123456";
                string para = "email=" + commonRequest.EmailId + "&userid=" + commonRequest.UserId;
                var url = string.Format("{0}profile.php?"+para, _settingsManager.ApiHost);

                await Task.Run(() =>
                {
                    Dictionary<string, string> head = GetHeaders();
                    var result = _apiProvider.Get<ProfileResponse,LoginRequest >(url, null).Result;
                    if (result.IsSuccessful)
                    {
                        if (success != null)
                        {
                            profileResponse = result.Result;
                            success.Invoke();
                        }
                    }
                    else
                    {
                        failed.Invoke(result.Result);
                    }
                });
            }
            else
            {
                UserDialogs.Instance.HideLoading(); UserDialogs.Instance.Alert(error, null, "OK");
            }
        }

        public async void getCountry(CommonRequest commonRequest, Action success)
        {
            bool IsNetwork = true;//await DependencyService.Get<IMediaService>().CheckNewworkConnectivity();
            if (IsNetwork)
            {
               
                var url = string.Format("{0}country.php?" , _settingsManager.ApiHost);

                await Task.Run(() =>
                {
                    Dictionary<string, string> head = GetHeaders();
                    var result = _apiProvider.Get<CountryResponse,CommonRequest>(url, null).Result;
                    if (result.IsSuccessful)
                    {
                        if (success != null)
                        {
                            countryResponse = result.Result;
                            success.Invoke();
                        }
                    }
                    //else
                    //{
                    //    failed.Invoke(result.Result);
                    //}
                });
            }
            else
            {
                UserDialogs.Instance.HideLoading(); UserDialogs.Instance.Alert(error, null, "OK");
            }
        }

        public async void Login(LoginRequest request, Action success, Action<BaseResponseModel> failed)
        {
            var pp = request;
            bool IsNetwork = true;//await DependencyService.Get<IMediaService>().CheckNewworkConnectivity();
            if (IsNetwork)
            {
               
                var url = string.Format("{0}login.php", _settingsManager.ApiHost);

                await Task.Factory.StartNew(() =>
                {
                   
                    var result = _apiProvider.Post<LoginResponse, LoginRequest>(url, request).Result;
                    if (result.IsSuccessful)
                    {
                        if (success != null)
                        {
                            loginResponse = result.Result;
                            success.Invoke();
                        }
                    }
                    else
                    {
                        failed.Invoke(result.Result);
                    }
                });
            }
            else
            {
                UserDialogs.Instance.HideLoading(); UserDialogs.Instance.Alert(error, null, "OK");
            }
        }

        public async void ForgetPassword(LoginRequest request, Action success, Action<BaseResponseModel> failed)
        {
            var pp = request;
            bool IsNetwork = true;//await DependencyService.Get<IMediaService>().CheckNewworkConnectivity();
            if (IsNetwork)
            {

                var url = string.Format("{0}forgotpassword.php", _settingsManager.ApiHost);

                await Task.Factory.StartNew(() =>
                {

                    var result = _apiProvider.Post<LoginResponse, LoginRequest>(url, request).Result;
                    if (result.IsSuccessful)
                    {
                        if (success != null)
                        {
                            loginResponse = result.Result;
                            success.Invoke();
                        }
                    }
                    else
                    {
                        failed.Invoke(result.Result);
                    }
                });
            }
            else
            {
                UserDialogs.Instance.HideLoading(); UserDialogs.Instance.Alert(error, null, "OK");
            }
        }


        public async void SignUp(SignupRequest signupRequest, Action success, Action<SignupResponse> failed)
        {
            bool IsNetwork = true;//await DependencyService.Get<IMediaService>().CheckNewworkConnectivity();
            if (IsNetwork)
            {

                var url = string.Format("{0}register.php", _settingsManager.ApiHost);

                await Task.Factory.StartNew(() =>
                {

                    var result = _apiProvider.Post<SignupResponse, SignupRequest>(url, signupRequest).Result;
                    if (result.IsSuccessful)
                    {
                        if (success != null)
                        {
                            signupResponse = result.Result;
                            success.Invoke();
                        }
                    }
                    else
                    {
                        failed.Invoke(result.Result);
                    }
                });
            }
            else
            {
                UserDialogs.Instance.HideLoading(); UserDialogs.Instance.Alert(error, null, "OK");
            }
        }

        public async void SignUpUpdate(ProfileUpdateRequest signupRequest, Action success, Action<SignupResponse> failed)
        {
            bool IsNetwork = true;//await DependencyService.Get<IMediaService>().CheckNewworkConnectivity();
            if (IsNetwork)
            {

                var url = string.Format("{0}profile.php", _settingsManager.ApiHost);

                await Task.Factory.StartNew(() =>
                {

                    var result = _apiProvider.Post<SignupResponse, ProfileUpdateRequest>(url, signupRequest).Result;
                    if (result.IsSuccessful)
                    {
                        if (success != null)
                        {
                            signupResponse = result.Result;
                            success.Invoke();
                        }
                    }
                    else
                    {
                        failed.Invoke(result.Result);
                    }
                });
            }
            else
            {
                UserDialogs.Instance.HideLoading(); UserDialogs.Instance.Alert(error, null, "OK");
            }
        }


    }
}
