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

            lst1.ItemsSource = new List<Contacts>()
            {
    new Contacts() {
            Name = "Umair Here, you can see that we", Num = "0456445450945", imgsource = "checkmarkon.png",
        },
        new Contacts() {
            Name = "Cat Here, you can see that we", Num = "034456445905", imgsource = "checkmarkon.png",
        },
        new Contacts() {
            Name = "Nature Here, you can see that we", Num = "56445905", imgsource = "checkmark.png",
        },
        new Contacts() {
            Name = "Nature Here, you can see that we", Num = "56445905", imgsource = "checkmarkon.png",
        },
        new Contacts() {
            Name = "Cat Here, you can see that we", Num = "034456445905", imgsource = "checkmarkon.png",
        },
        new Contacts() {
            Name = "Nature Here, you can see that we", Num = "56445905", imgsource = "checkmark.png",
        },
        new Contacts() {
            Name = "Nature Here, you can see that we", Num = "56445905", imgsource = "checkmark.png",
        },
        new Contacts() {
            Name = "Nature Here, you can see that we", Num = "56445905", imgsource = "checkmarkon.png",
        },
        new Contacts() {
            Name = "Cat Here, you can see that we", Num = "034456445905", imgsource = "checkmarkon.png",
        },
        new Contacts() {
            Name = "Nature Here, you can see that we", Num = "56445905", imgsource = "checkmark.png",
        },
        new Contacts() {
            Name = "Nature Here, you can see that we", Num = "56445905", imgsource = "checkmarkon.png",
        },
};


            lst2.ItemsSource = new List<Contacts>()
            {
    new Contacts() {
            Name = "Umair Here, you can see that we used the ImageCell and set Binding. We set Binding of ‘Text’ with ‘Name’, ", Num = "0456445450945", imgsource = "checkmark.png",
        },
        new Contacts() {
            Name = "Cat Here, you can see that we used the ImageCell and set Binding. We set Binding of ‘Text’ with ‘Name’, ", Num = "034456445905", imgsource = "checkmark.png",
        },
        new Contacts() {
            Name = "Nature Here, you can see that we used the ImageCell and set Binding. We set Binding of ‘Text’ with ‘Name’, ", Num = "56445905", imgsource = "checkmark.png",
        },
         new Contacts() {
            Name = "Nature Here, you can see that we used the ImageCell and set Binding. We set Binding of ‘Text’ with ‘Name’, ", Num = "56445905", imgsource = "checkmark.png",
        },
                new Contacts() {
            Name = "Cat Here, you can see that we used the ImageCell and set Binding. We set Binding of ‘Text’ with ‘Name’, ", Num = "034456445905", imgsource = "checkmark",
        },
        new Contacts() {
            Name = "Nature Here, you can see that we used the ImageCell and set Binding. We set Binding of ‘Text’ with ‘Name’, ", Num = "56445905", imgsource = "checkmark.png",
        },
                new Contacts()
                {
                    Name = "Cat Here, you can see that we used the ImageCell and set Binding. We set Binding of ‘Text’ with ‘Name’, ", Num = "034456445905", imgsource = "checkmark.png",
                },
        new Contacts()
        {
            Name = "Nature Here, you can see that we used the ImageCell and set Binding. We set Binding of ‘Text’ with ‘Name’, ", Num = "56445905", imgsource = "checkmark.png",
        },
            };


            var Urls = new System.Collections.ObjectModel.ObservableCollection<string>();
            Urls.Add("https://www.youtube.com/watch?v=O-RgquKVTPE");
            videoView.BackgroundColor = Color.Black;
            videoView.ItemsSource = Urls;

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
