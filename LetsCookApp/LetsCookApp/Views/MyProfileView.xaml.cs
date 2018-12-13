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
    public partial class MyProfileView : ContentPage
    {
        public MyProfileView()
        {
           

            
            InitializeComponent();
            
            NavigationPage.SetHasNavigationBar(this, false);
            TLine.IsVisible = grdTimeline.IsVisible = true;
            ALine.IsVisible = FLine.IsVisible = GLine.IsVisible = false;
            grdAboutme.IsVisible = listFriends.IsVisible = grdGallery.IsVisible = false;
            BindingContext = App.AppSetup.HomeViewModel;
            //App.AppSetup.HomeViewModel.GetProfile();

            //App.AppSetup.HomeViewModel.AboutMe = "You can provide extra definitions to the linker to ensure the type, methods and/or fields are not eliminated from your application. In your own code the preferred way is to use the You can provide extra definitions to the linker to ensure the type, methods and/or fields are not eliminated from your application. In your own code the preferred way is to use the eliminated from your application. In your own code the preferred way is to use the eliminated from your application. In your own code the preferred way is to use the";
            lblreadmore.Text = "Read All";
            if (!string.IsNullOrEmpty(App.AppSetup.HomeViewModel.AboutMe))
            {
                lblaboutme.Text = LimitTo(App.AppSetup.HomeViewModel.AboutMe, 100);

                if (lblaboutme.Text.Length > 97)
                {
                    lblaboutme.Text = lblaboutme.Text + "...";
                }
                isvisibleProfileBioReadMore();
            }
        }

        public static string LimitTo(string data, int length)
        {
            return (data == null || data.Length < length) ? data : data.Substring(0, length);
        }
        public void isvisibleProfileBioReadMore()
        {
            lblreadmore.IsVisible = imgdown.IsVisible= App.AppSetup.HomeViewModel.AboutMe.Length > 100;
        }
       
        private void Menu_Tapped(object sender, EventArgs e)
        {
            App.AppSetup.HomeViewModel.IsMenuListPresented = true;
        }
        private void Timeline_Tapped(object sender, EventArgs e)
        {
            TLine.IsVisible =grdTimeline.IsVisible= imgArrow.IsVisible = true;
            ALine.IsVisible = FLine.IsVisible = GLine.IsVisible = false;
            grdAboutme.IsVisible = listFriends.IsVisible = grdGallery.IsVisible = false;
        }
        private void AboutMe_Tapped(object sender, EventArgs e)
        {
            ALine.IsVisible =grdAboutme.IsVisible= true;
            TLine.IsVisible = FLine.IsVisible = GLine.IsVisible = false;
            grdTimeline.IsVisible = listFriends.IsVisible = grdGallery.IsVisible = imgArrow.IsVisible= false;

        }
        private void Friends_Tapped(object sender, EventArgs e)
        {
            FLine.IsVisible = listFriends.IsVisible= imgArrow.IsVisible = true;
            TLine.IsVisible = ALine.IsVisible = GLine.IsVisible = false;
            grdTimeline.IsVisible = grdAboutme.IsVisible = grdGallery.IsVisible = false;
            List<SubCategory> _listAvailableAward = new List<SubCategory>()
            {
                new SubCategory {foodIcon = "cacke.png" ,DishName = "Santosh", likeIcon = "icon.png" ,timeIcon = "icon.png" ,Time = "9 MIn", servingIcon = "icon.png", Servings="6 Servings",ingrendIcon="icon.png" , Ingrendients="Team Lead" ,plusIcon="icon.png"},
                new SubCategory {foodIcon = "donat.png" ,DishName = "Dipika", likeIcon = "icon.png" ,timeIcon = "icon.png" ,Time = "30 MIn", servingIcon = "icon.png", Servings="4 Servings",ingrendIcon="icon.png" , Ingrendients="Graphics Designer" ,plusIcon="icon.png"},
                new SubCategory {foodIcon = "ruge.png" ,DishName = "John", likeIcon = "icon.png" ,timeIcon = "icon.png" ,Time = "15 MIn", servingIcon = "icon.png", Servings="4 Servings",ingrendIcon="icon.png" , Ingrendients="Tester" ,plusIcon="icon.png"},
            };
            listFriends.ItemsSource = _listAvailableAward;

        }
        private void Gallery_Tapped(object sender, EventArgs e)
        {
            GLine.IsVisible =grdGallery.IsVisible= imgArrow.IsVisible = true;
            TLine.IsVisible = FLine.IsVisible = ALine.IsVisible = false;
            grdTimeline.IsVisible = listFriends.IsVisible = grdAboutme.IsVisible = false;
        }
        private void Search_Tapped(object sender, EventArgs e)
        {
            var page = new SearchView();

            Rg.Plugins.Popup.Services.PopupNavigation.PushAsync(page);
        }

        private void ReadMore_Tapped(object sender, EventArgs e)
        {
            if (lblreadmore.Text == "Read All")
            {
                lblaboutme.Text = LimitTo(App.AppSetup.HomeViewModel.AboutMe, App.AppSetup.HomeViewModel.AboutMe.Length);
                lblreadmore.Text = "Read less"; imgdown.RotateTo(180,50,null);
            }
            else
            {
                lblaboutme.Text = LimitTo(App.AppSetup.HomeViewModel.AboutMe, 100);
                if (lblaboutme.Text.Length > 97)
                {
                    lblaboutme.Text = lblaboutme.Text + "...";
                }
                lblreadmore.Text = "Read All";
                imgdown.RotateTo(0, 50, null);
            }
        }
    }


}
