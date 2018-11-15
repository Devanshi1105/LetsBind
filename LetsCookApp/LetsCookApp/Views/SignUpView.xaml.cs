using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LetsCookApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUpView : ContentPage
    {
        public SignUpView()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            BindingContext = App.AppSetup.SignUpViewModel;
        }
        private void SignIn_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SignInView());
        }

        private void Close_Tapped(object sender, EventArgs e)
        {
            Navigation.PopToRootAsync();
        }
    }
}