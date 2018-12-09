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
	public partial class DishView : ContentPage
	{
		public DishView ()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            var vm= App.AppSetup.CategoryViewModel;
            BindingContext = vm;

            var Urls = new System.Collections.ObjectModel.ObservableCollection<string>();
            Urls.Add(""+ vm.RecipeDishView.VideoUrl + "");
            videoView.BackgroundColor = Color.Black;
            videoView.ItemsSource = Urls;

            HtmlWebViewSource personHtmlSource = new HtmlWebViewSource();
            personHtmlSource.SetBinding(HtmlWebViewSource.HtmlProperty, "HTMLDesc");
            personHtmlSource.Html = vm.RecipeDishView.Preparation;  

            lst1.HeightRequest = vm.RecipeDishView.Ingredients.Count < 0 ? 50 : (vm.RecipeDishView.Ingredients.Count + 1) * 50; 
            prewebView.Source = personHtmlSource;




        }

        private void lst2_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = e.Item as Contacts;
            if (item.imgsource == "nact")
            {
                item.imgsource = "act";
            }
            else
            {
                item.imgsource = "nact";
            }
        }

        private void Menu_Tapped(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
        private void Search_Tapped(object sender, EventArgs e)
        {
            var page = new SearchView();

            Rg.Plugins.Popup.Services.PopupNavigation.PushAsync(page);
        }
        private void lst1_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = e.Item as Contacts;
            if (item.imgsource == "checkmarkon")
            {
                item.imgsource = "checkmark";
            }
            else
            {
                item.imgsource = "checkmarkon";
            }
        }
    }

    public class Contacts
    {
        public string Name
        {
            get;
            set;
        }
        public string Num
        {
            get;
            set;
        }
        public string imgsource
        {
            get;
            set;
        }
    }
}
