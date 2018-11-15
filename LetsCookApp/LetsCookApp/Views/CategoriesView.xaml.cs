using Rg.Plugins.Popup.Services;
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
    public partial class CategoriesView : ContentPage
    {
        public CategoriesView()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void SubCategories_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SubCategoryView());
        }
        private void Menu_Tapped(object sender, EventArgs e)
        {
            App.AppSetup.HomeViewModel.IsMenuListPresented = true;
        }
        private  void Search_Tapped(object sender, EventArgs e)
        {
            var page = new SearchView();

             PopupNavigation.PushAsync(page);
        }


    }
}