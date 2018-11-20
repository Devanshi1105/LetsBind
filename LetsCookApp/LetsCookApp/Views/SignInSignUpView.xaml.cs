using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace LetsCookApp.Views
{
    public partial class SignInSignUpView : ContentPage
    {
        public SignInSignUpView()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            var viewmodel = App.AppSetup.LoginViewModel;
            BindingContext = viewmodel;

        }

        private void Create_Clicked(object sender, EventArgs e)
        {

            //FullName = BirthDay = Ocupation = Email = UserName = Password = MobilePhone = AboutMe = "";
            App.AppSetup.SignUpViewModel.Title = "Sign in";
            Navigation.PushAsync(new SignUpView());
        }

        private void HomeMaster_Clicked(object sender, EventArgs e)
        {
             Navigation.PushAsync(new HomeView());
        }
        private void Signin_Clicked(object sender, EventArgs e)
        {
            var viewmodel = App.AppSetup.LoginViewModel;
            viewmodel.UserName = viewmodel.Password = "";
            Navigation.PushAsync(new SignInView());
        }
        private void ForgotPassword_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ForgotPasswordView());
        }

    }
}
