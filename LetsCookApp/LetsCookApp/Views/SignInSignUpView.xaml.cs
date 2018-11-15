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
        }

        private void Create_Clicked(object sender, EventArgs e)
        {
             Navigation.PushAsync(new SignUpView());
        }

        private void HomeMaster_Clicked(object sender, EventArgs e)
        {
             Navigation.PushAsync(new HomeView());
        }
        private void Signin_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SignInView());
        }
    }
}
