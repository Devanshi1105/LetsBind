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
    public partial class MenuView : ContentPage
    {
        public ListView menuList;
        public MenuView()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            this.menuList = masterMenuList;
        }

        private void masterMenuList_ItemTapped(object sender, ItemTappedEventArgs e)
        { 
        
            NavigateTo((ViewModels.Menu)e.Item);
        }

        private void Menu_Tapped(object sender, EventArgs e)
        {
            App.AppSetup.HomeViewModel.IsMenuListPresented = false;
        }

        void NavigateTo(ViewModels.Menu menu)
        {
            if (menu.TargetType == typeof(CategoriesView))
            {
                ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PopToRootAsync();
            }
            else if (menu.TargetType == typeof(MyProfileView))
            {
                 ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PushAsync(new MyProfileView());
            }
            else if (menu.TargetType == typeof(NewlyAddedRecipes))
            {
                ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PushAsync(new NewlyAddedRecipes());
            }
            else if (menu.TargetType == typeof(PopularReceipesView))
            {
                ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PushAsync(new PopularReceipesView());
            }
            else if (menu.TargetType == typeof(MyFavouritesRecipesView))
            {
                ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PushAsync(new MyFavouritesRecipesView());
            }
            else if (menu.TargetType == typeof(ShoppingListView))
            {
                ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PushAsync(new ShoppingListView());
            }
            else if (menu.TargetType == typeof(SuggestRecipesView))
            {
                ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PushAsync(new SuggestRecipesView());
            }
            else if (menu.TargetType == typeof(HelpMeView))
            {
                ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PushAsync(new HelpMeView());
            }
            else if (menu.TargetType == typeof(AboutUsView))
            {
                ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PushAsync(new AboutUsView());
            }
            else if (menu.TargetType == typeof(SettingsView))
            {
                ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PushAsync(new SettingsView());
            }
            else if (menu.TargetType == typeof(ShareAppView))
            {
                ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PushAsync(new ShareAppView());
            }

            else if (menu.TargetType == typeof(Nullable))
            {
                App.Current.MainPage = new NavigationPage(new Views.SignInSignUpView());
            }
            App.AppSetup.HomeViewModel.IsMenuListPresented = false;
        }
    }
}