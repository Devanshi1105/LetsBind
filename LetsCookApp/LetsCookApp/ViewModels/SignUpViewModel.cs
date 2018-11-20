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
        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; RaisePropertyChanged(() => Email); }
        }


        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; RaisePropertyChanged(() => FirstName); }
        }


        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; RaisePropertyChanged(() => Password); }
        }

        private string retypePassword;
        public string RetypePassword
        {
            get { return retypePassword; }
            set
            {

                retypePassword = value;
                RaisePropertyChanged(() => RetypePassword);
            }
        }

        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; RaisePropertyChanged(() => LastName); }
        }
        private string mobileNumber;
        public string MobileNumber
        {
            get { return mobileNumber; }
            set { mobileNumber = value; RaisePropertyChanged(() => MobileNumber); }
        }
        private string phoneNumber;
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; RaisePropertyChanged(() => PhoneNumber); }
        }

        private string address1;
        public string Address1
        {
            get { return address1; }
            set { address1 = value; RaisePropertyChanged(() => Address1); }
        }
        private string address2;
        public string Address2
        {
            get { return address2; }
            set { address2 = value; RaisePropertyChanged(() => Address2); }
        }
        private string address3;
        public string Address3
        {
            get { return address3; }
            set { address3 = value; RaisePropertyChanged(() => Address3); }
        }
        private string city;
        public string City
        {
            get { return city; }
            set { city = value; RaisePropertyChanged(() => City); }
        }

        private string state;
        public string State
        {
            get { return state; }
            set { state = value; RaisePropertyChanged(() => State); }
        }
        private string country;
        public string Country
        {
            get { return country; }
            set { country = value; RaisePropertyChanged(() => Country); }
        }

        private string postCode;
        public string Postcode
        {
            get { return postCode; }
            set { postCode = value; RaisePropertyChanged(() => Postcode); }
        }
        private string hobbies;
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
            set
            {
                fullName = value;
                RaisePropertyChanged(() => FullName);
            }
        }

        private int userid;
        public int UserId
        {
            get { return userid; }
            set
            {
                userid = value;
                RaisePropertyChanged(() => UserId);
            }
        }

        private string dateOfBirth;
        public string DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; RaisePropertyChanged(() => DateOfBirth); }
        }
        private string userName;
        public string UserName
        {
            get { return userName; }
            set
            {
                userName = value; RaisePropertyChanged(() => UserName);
            }
        }

        private string occupation;
        public string Ocupation
        {
            get { return occupation; }
            set
            {
                occupation = value; RaisePropertyChanged(() => Ocupation);
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

        private string title;
        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                if (value == "Sign in")
                {
                    IsEnable = true;
                    BtnText = "FINISH";
                }
                else
                {
                    IsEnable = false;
                    BtnText = "UPDATE";
                }
                RaisePropertyChanged(() => Title);
            }
        }

        private string btnText;
        public string BtnText
        {
            get { return btnText; }
            set
            {
                btnText = value;
                if (value == "Sign in")
                {
                    IsEnable = true;
                }
                else
                {
                    IsEnable = false;
                }
                RaisePropertyChanged(() => BtnText);
            }
        }

        private bool isenable;
        public bool IsEnable
        {
            get { return isenable; }
            set { isenable = value; RaisePropertyChanged(() => IsEnable); }
        }

        private string imageBase64;
        public string ImageBase64
        {
            get { return this.imageBase64; }
            set
            {
                if (Equals(value, this.imageBase64))
                {
                    return;
                }
                this.imageBase64 = value;
                RaisePropertyChanged(() => ImageBase64);
            }
        }






        #endregion

        #region Validation
        private bool Validate()
        {
            bool val = false;
            if (string.IsNullOrEmpty(UserName))
            {
                UserDialogs.Instance.Alert("Username is Required");
                val = false;
            }
           else if (string.IsNullOrEmpty(FirstName))
            {
                UserDialogs.Instance.Alert("FullName is Required");
                val = false;
            }
            else if (string.IsNullOrEmpty(LastName))
            {
                UserDialogs.Instance.Alert("LastName is Required");
                val = false;
            }
            else if (string.IsNullOrEmpty(Gender))
            {
                UserDialogs.Instance.Alert("Gender is Required.");
                val = false;
            }
            else if (string.IsNullOrEmpty(DateOfBirth))
            {
                UserDialogs.Instance.Alert("BirthDay is Required.");
                val = false;
            }
            else if (string.IsNullOrEmpty(Password))
            {
                UserDialogs.Instance.Alert("Password is Required.");
                val = false;
            }
            else if (Password != RetypePassword)
            {
                UserDialogs.Instance.Alert("Password and retype-password should be equal.");
                val = false;
            }


            else if (string.IsNullOrEmpty(MobileNumber))
            {
                UserDialogs.Instance.Alert("MobileNumber is Required.");
                val = false;
            }
            else if (string.IsNullOrEmpty(PhoneNumber))
            {
                UserDialogs.Instance.Alert("PhoneNumber is Required.");
                val = false;
            }
            else if (string.IsNullOrEmpty(Email))
            {
                UserDialogs.Instance.Alert("Email is Required.");
                val = false;
            }
            else if (string.IsNullOrEmpty(Address1))
            {
                UserDialogs.Instance.Alert("Address1 is Required.");
                val = false;
            }
            else if (string.IsNullOrEmpty(City))
            {
                UserDialogs.Instance.Alert("City is Required.");
                val = false;
            }
            else if (string.IsNullOrEmpty(Postcode))
            {
                UserDialogs.Instance.Alert("PostCode is Required.");
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
                var SignupRequest = new SignupRequest
                {
                    Address1 = Address1,
                    Address2 = Address2,
                    Address3 = Address3,
                    State = State,
                    City = City,
                    Country = Country,
                    Email = Email,
                    FirstName = FirstName,
                    Hobbies = Hobbies,
                    LastName = LastName,
                    UserName = UserName,
                    MobileNumber = MobileNumber,
                    Password = Password,
                    PhoneNumber = PhoneNumber,
                    Postcode = postCode,
                    Picture = ImageBase64,

                    DateOfBirth = DateOfBirth,
                    Gender = Gender
                };



                await Task.Run(() =>
                {
                    UserDialogs.Instance.ShowLoading("Requesting..");
                    if (BtnText == "UPDATE")
                    {
                        SignupRequest.UserId = UserId;
                        userManager.SignUpUpdate(SignupRequest, () =>
                        {
                            var SignupResponse = userManager.SignupResponse;
                            Device.BeginInvokeOnMainThread(() =>
                            {
                                if (SignupResponse.StatusCode == 200)
                                {
                                    UserDialogs.Instance.HideLoading();
                                    UserDialogs.Instance.Alert(SignupResponse.Message);
                                    FullName = DateOfBirth = Ocupation = Email = UserName = Password = MobileNumber = AboutMe = "";
                                    Address1 = Address2 = Address3 = City = State = Country = Postcode = Gender = Hobbies = PhoneNumber = "";
                                    App.Current.MainPage.Navigation.PushAsync(new SignInView());
                                }
                                else
                                {
                                    UserDialogs.Instance.Alert(SignupResponse.Message, "Error",  "OK");
                                }
                            });

                            UserDialogs.Instance.HideLoading();
                        },
                     (requestFailedReason) =>
                     {
                         UserDialogs.Instance.Alert(requestFailedReason.Message, "Error", "OK");
                         UserDialogs.Instance.HideLoading();
                     });

                    }

                    else
                    {
                        userManager.SignUp(SignupRequest, () =>
                        {
                            var SignupResponse = userManager.SignupResponse;
                            Device.BeginInvokeOnMainThread(() =>
                            {
                                if (SignupResponse.StatusCode == 200)
                                {
                                    UserDialogs.Instance.HideLoading();
                                    UserDialogs.Instance.Alert(SignupResponse.Message);
                                    FullName = DateOfBirth = Ocupation = Email = UserName = Password = MobileNumber = AboutMe = "";
                                    Address1 = Address2 = Address3 = City = State = Country = Postcode = Gender = Hobbies = PhoneNumber = "";
                                    App.Current.MainPage.Navigation.PushAsync(new SignInView());
                                }
                                else
                                {
                                    UserDialogs.Instance.Alert(SignupResponse.Message, "Error", "OK");
                                }
                            });

                            UserDialogs.Instance.HideLoading();
                        },
                      (requestFailedReason) =>
                      {
                          UserDialogs.Instance.Alert(requestFailedReason.Message, "Error", "OK");
                          UserDialogs.Instance.HideLoading();
                      });

                    }

                });


                #endregion



            }
        }
    }
}