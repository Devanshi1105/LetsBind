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


        }

        private void Menu_Tapped(object sender, EventArgs e)
        {
            App.AppSetup.HomeViewModel.IsMenuListPresented = true;
        }
        private void Timeline_Tapped(object sender, EventArgs e)
        {
            TLine.IsVisible =grdTimeline.IsVisible= true;
            ALine.IsVisible = FLine.IsVisible = GLine.IsVisible = false;
            grdAboutme.IsVisible = listFriends.IsVisible = grdGallery.IsVisible = false;
        }
        private void AboutMe_Tapped(object sender, EventArgs e)
        {
            ALine.IsVisible =grdAboutme.IsVisible= true;
            TLine.IsVisible = FLine.IsVisible = GLine.IsVisible = false;
            grdTimeline.IsVisible = listFriends.IsVisible = grdGallery.IsVisible = false;

        }
        private void Friends_Tapped(object sender, EventArgs e)
        {
            FLine.IsVisible = listFriends.IsVisible= true;
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
            GLine.IsVisible =grdGallery.IsVisible= true;
            TLine.IsVisible = FLine.IsVisible = ALine.IsVisible = false;
            grdTimeline.IsVisible = listFriends.IsVisible = grdAboutme.IsVisible = false;
        }
        private void Search_Tapped(object sender, EventArgs e)
        {
            var page = new SearchView();

            Rg.Plugins.Popup.Services.PopupNavigation.PushAsync(page);
        }
    }


}
