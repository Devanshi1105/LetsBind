//using LetsCookApp.Views;
using LetsCookApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LetsCookApp.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public HomeViewModel()
        {
            IsMenuListPresented = false;
            _menuItemList = new List<Menu>()
            {
                new Menu {Title = "My Profile", imagesource="Profile.png", TargetType = typeof(MyProfileView)},
                new Menu {Title = "Newly Added Recipes", imagesource="Newly.png", TargetType = typeof(NewlyAddedRecipes)},
                new Menu {Title = "Popular Recipes", imagesource="Popular.png", TargetType = typeof(PopularReceipesView)},
                new Menu {Title = "Categories", imagesource="Categories", TargetType = typeof(CategoriesView)},
                new Menu {Title = "My Favourites Recipes",imagesource="Favourites.png",  TargetType = typeof(MyFavouritesRecipesView)},
                new Menu {Title = "Shopping List", imagesource="Shopping.png", TargetType = typeof(ShoppingListView)},
                new Menu {Title = "Suggest Recipes", imagesource="Suggest.png", TargetType = typeof(SuggestRecipesView)},
                new Menu {Title = "Please Help Me",imagesource="Help.png", TargetType = typeof(HelpMeView)},
                new Menu {Title = "About the App",imagesource="About.png", TargetType = typeof(AboutUsView)},
                new Menu {Title = "Settings", imagesource="Settings.png", TargetType = typeof(SettingsView)},
                new Menu {Title = "ShareApp", imagesource="ShareApp.png", TargetType = typeof(ShareAppView)},
                new Menu {Title = "Signout", imagesource="logout.png", TargetType = typeof(ShareAppView)},
            };
            RaisePropertyChanged(() => MenuItemList);
        }

        #region Set Properties

        private bool _isMenuListPresented;
        public bool IsMenuListPresented
        {
            get { return _isMenuListPresented; }
            set
            {
                _isMenuListPresented = value;
                RaisePropertyChanged(() => IsMenuListPresented);
            }
        }

        private List<Menu> _menuItemList;
        public List<Menu> MenuItemList
        {
            get { return _menuItemList; }
            set
            {
                _menuItemList = value;
                RaisePropertyChanged(() => MenuItemList);
            }
        }

        #endregion
    }

    public class Menu
    {
        public string Title { get; set; }
        public Type TargetType { get; set; }

        public ImageSource imagesource { get; set; }
    }
}
