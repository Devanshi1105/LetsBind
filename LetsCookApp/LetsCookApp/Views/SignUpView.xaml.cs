using Plugin.Media;
using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LetsCookApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUpView : ContentPage
    {
        public ICommand TakePicture { get; set; }
        public ICommand SelectPicture
        {
            get; set;
        }
        public SignUpView()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            TakePicture = new Command(async () => await TakePictureAsync());
            SelectPicture = new Command(async () => await SelectPictureAsync());
            BindingContext = App.AppSetup.SignUpViewModel;
        }

        private void Create_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new Views.HomeView();
            //Navigation.PushAsync(new CategoriesView());
        }
        private void SignIn_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SignInView());
        }

        private void Close_Tapped(object sender, EventArgs e)
        {
            Navigation.PopToRootAsync();
        }


        public async Task TakePictureAsync()
        {
            await CrossMedia.Current.Initialize();
            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                await DisplayAlert("No Camera", ":( No camera avaialble.", "OK");
                return;
            }
            try
            {
                var file = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions
                {
                    Directory = "Test",

                    DefaultCamera = CameraDevice.Front
                });

                if (file == null)
                    return;



                await DisplayAlert("File Location", file.Path, "OK");

                imgphoto.Source = ImageSource.FromStream(() =>
                {
                    var stream = file.GetStream();
                    file.Dispose();
                    return stream;
                });

            }
            catch (Exception ex)
            {
                await DisplayAlert("No Camera", ":( " + ex.Message, "OK");
            }
        }
        public async Task SelectPictureAsync()
        {

            if (!CrossMedia.Current.IsPickPhotoSupported)
            {
                await DisplayAlert("Photos Not Supported", ":( Permission not granted to photos.", "OK");
                return;
            }
            var file = await CrossMedia.Current.PickPhotoAsync();

            if (file == null)
                return;

            imgphoto.Source = ImageSource.FromStream(() =>
            {
                var stream = file.GetStream();
                file.Dispose();
                return stream;
            });
        }

        private string imageBase64;
        public string ImageBase64
        {
            get { return this.imageBase64; }
            set
            {
                if (Equals(value, this.imageBase64))
                {
                    return;
                }
                this.imageBase64 = value;
                // RaisePropertyChanged(() => ImageBase64);
            }
        }
        private ImageSource picture;
        public ImageSource Picture
        {
            get { return picture; }
            set
            {

                picture = value;
                // RaisePropertyChanged(() => Picture);
            }
        }

        private async void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            var actionSheet = await DisplayActionSheet("", "Cancel", null, new string[] { "Take Picture", "Select Picture" });
            if (actionSheet == "Select Picture")
            {
                SelectPicture.Execute(null);
            }
            else if (actionSheet == "Take Picture")
            {
                TakePicture.Execute(null);
            }
        }
    }
}