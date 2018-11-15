using Acr.UserDialogs;
using LetsCookApp.Models;
using LetsCookApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace LetsCookApp.ViewModels
{
    public class SignUpViewModel : BaseViewModel
    {

        #region Constructor
       
        public SignUpViewModel()
        {
            FinishCommand = new Command(() => FinishCommandExecute());
        }

       
        #endregion

        #region Property
        private string email ;
        public string Email
        {
            get { return email; }
            set { email = value; RaisePropertyChanged(() => Email); }
        }
        private string memberName ;
        public string MemberName
        {
            get { return memberName; }
            set { memberName = value; RaisePropertyChanged(() => MemberName); }
        }

        private string password ;
        public string Password
        {
            get { return password; }
            set { password = value; RaisePropertyChanged(() => Password); }
        }
        private string firstName ;
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; RaisePropertyChanged(() => FirstName); }
        }
        private string lastName ;
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; RaisePropertyChanged(() => LastName); }
        }
        private string mobilePhone ;
        public string MobilePhone
        {
            get { return mobilePhone; }
            set { mobilePhone = value; RaisePropertyChanged(() => MobilePhone); }
        }
        private string phoneNumber ;
        public string Mobile
        {
            get { return phoneNumber; }
            set { phoneNumber = value; RaisePropertyChanged(() => Mobile); }
        }
        
        private string add1 ;
        public string Add1
        {
            get { return add1; }
            set { add1 = value; RaisePropertyChanged(() => Add1); }
        }
        private string add2 ;
        public string Add2
        {
            get { return add2; }
            set { add2 = value; RaisePropertyChanged(() => Add2); }
        }
        private string city ;
        public string City
        {
            get { return city; }
            set { city = value; RaisePropertyChanged(() => City); }
        }

        private string state ;
        public string State
        {
            get { return state; }
            set { state = value; RaisePropertyChanged(() => State); }
        }
        private string country ;
        public string Country
        {
            get { return country; }
            set { country = value; RaisePropertyChanged(() => Country); }
        }
        
        private string postCode ;
        public string PostCode
        {
            get { return postCode; }
            set { postCode = value; RaisePropertyChanged(() => PostCode); }
        }
        private string hobbies ;
        public string Hobbies
        {
            get { return hobbies; }
            set { hobbies = value; RaisePropertyChanged(() => Hobbies); }
        }
        private string picture;
        public string Picture
        {
            get { return picture; }
            set { picture = value; RaisePropertyChanged(() => Picture); }
        }

        private string fullName;
        public string FullName
        {
            get { return fullName; }
            set { fullName = value;
                RaisePropertyChanged(() => FullName);
            }
        }

        private string birthDate;
        public string BirthDay
        {
            get { return birthDate; }
            set { birthDate = value; RaisePropertyChanged(() => BirthDay); }
        }
        private string userName;
        public string UserName
        {
            get { return userName; }
            set { userName = value; RaisePropertyChanged(() => UserName);
            }
        }

        private string occupation;
        public string Ocupation
        {
            get { return occupation; }
            set { occupation = value; RaisePropertyChanged(() => Ocupation);
            }
        }
        private string aboutMe;
        public string AboutMe
        {
            get { return aboutMe; }
            set { aboutMe = value; RaisePropertyChanged(() => AboutMe); }
        }

        private string gender;

        public string Gender
        {
            get { return gender; }
            set { gender = value; RaisePropertyChanged(() => Gender); }
        }







        #endregion

        #region Validation
        private bool Validate()
        {
            bool val = false;
            if (string.IsNullOrEmpty(FullName))
            {
                UserDialogs.Instance.Alert("FullName is Required");
                val = false;
            }
            else if (string.IsNullOrEmpty(BirthDay))
            {
                UserDialogs.Instance.Alert("BirthDay is Required");
                val = false;
            }
            else if (string.IsNullOrEmpty(Gender))
            {
                UserDialogs.Instance.Alert("Gender is Required");
                val = false;
            }
            else if (string.IsNullOrEmpty(UserName))
            {
                UserDialogs.Instance.Alert("Username is Required");
                val = false;
            }
            
           
            
            else if (string.IsNullOrEmpty(Password))
            {
                UserDialogs.Instance.Alert("Password is Required");
                val = false;
            }
            else if (string.IsNullOrEmpty(occupation))
            {
                UserDialogs.Instance.Alert("occupation is Required");
                val = false;
            }
            else if (string.IsNullOrEmpty(Mobile))
            {
                UserDialogs.Instance.Alert("Mobile is Required");
                val = false;
            }
            else
            {
                val = true;
            }
            return val;
        }
        #endregion

        #region Command
        public ICommand FinishCommand { get; private set; }
        private async void FinishCommandExecute()
        {
            if (Validate() == true)
            {
                //var SignupRequest = new SignupRequest
                //{
                //    email = UserName,
                //    password = Password
                //};

                //await Task.Run(() =>
                //{
                //    UserDialogs.Instance.ShowLoading("Requesting..");
                //    userManager.SignUp(SignupRequest, () =>
                //    {
                //        var SignupResponse = userManager.SignupResponse;
                //        Device.BeginInvokeOnMainThread(() =>
                //        {
                //            if (SignupResponse.ErrorCode == 201)
                //            {
                //                UserDialogs.Instance.HideLoading();
                //                App.Current.MainPage.Navigation.PushAsync(new CategoriesView());
                //            }
                //            else
                //            {
                //                UserDialogs.Instance.Alert("Error", SignupResponse.ErrorMessage, "OK");
                //            }
                //        });
                //        RaisePropertyChanged(() => SignupResponse);
                //        UserDialogs.Instance.HideLoading();
                //    },
                //       (requestFailedReason) =>
                //       {
                //           UserDialogs.Instance.HideLoading();
                //       });
                //});

                UserDialogs.Instance.HideLoading();
                App.Current.MainPage.Navigation.PushAsync(new CategoriesView());
            }
            
        }
        #endregion



    }
}
