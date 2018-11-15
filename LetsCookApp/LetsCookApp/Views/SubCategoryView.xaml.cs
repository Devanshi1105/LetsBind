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
    public partial class SubCategoryView : ContentPage
    {
        public SubCategoryView()
        {

            List<SubCategory> _listAvailableAward = new List<SubCategory>()
            {
                new SubCategory {foodIcon = "cacke.png" ,DishName = "Cake Recipes", likeIcon = "icon.png" ,timeIcon = "icon.png" ,Time = "9 MIn", servingIcon = "icon.png", Servings="6 Servings",ingrendIcon="icon.png" , Ingrendients="14 Ingredients" ,plusIcon="icon.png"},
                new SubCategory {foodIcon = "donat.png" ,DishName = "Donut Recipe", likeIcon = "icon.png" ,timeIcon = "icon.png" ,Time = "30 MIn", servingIcon = "icon.png", Servings="4 Servings",ingrendIcon="icon.png" , Ingrendients="8 Ingredients" ,plusIcon="icon.png"},
                new SubCategory {foodIcon = "ruge.png" ,DishName = "Rugelach Recipe", likeIcon = "icon.png" ,timeIcon = "icon.png" ,Time = "15 MIn", servingIcon = "icon.png", Servings="4 Servings",ingrendIcon="icon.png" , Ingrendients="7 Ingredients" ,plusIcon="icon.png"},
                new SubCategory {foodIcon = "cacke.png" ,DishName = "Cake Recipes", likeIcon = "icon.png" ,timeIcon = "icon.png" ,Time = "9 MIn", servingIcon = "icon.png", Servings="6 Servings",ingrendIcon="icon.png" , Ingrendients="14 Ingredients" ,plusIcon="icon.png"},

            };

            //RaisePropertyChanged(() => ListAvailableAward);
           
            InitializeComponent();
            listSubCatgory.ItemsSource = _listAvailableAward;

            NavigationPage.SetHasNavigationBar(this, false);
        }
        private void Search_Tapped(object sender, EventArgs e)
        {
            var page = new SearchView();

            Rg.Plugins.Popup.Services.PopupNavigation.PushAsync(page);
        }
        private void Menu_Tapped(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
        private void listSubCatgory_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                // var item = (Result)e.SelectedItem;
                Navigation.PushAsync(new DishView());
            }
        }

    }
 
    public class SubCategory
    {
        public ImageSource foodIcon { get; set; }
        public string DishName { get; set; }
        public ImageSource likeIcon { get; set; }
        public ImageSource timeIcon { get; set; }
        public string Time { get; set; }
        public ImageSource servingIcon { get; set; }
        public string Servings { get; set; }
        public ImageSource ingrendIcon { get; set; }
        public string Ingrendients { get; set; }
        public ImageSource plusIcon { get; set; }
        public double UserRating { get; set; }
    }
}