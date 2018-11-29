
using Acr.UserDialogs;
using LetsCookApp.Models;
using LetsCookApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace LetsCookApp.ViewModels
{
    public class CategoryViewModel : BaseViewModel
    {
        #region Constructor    

        public ICommand GetCotegaryCommand { get; private set; }
        public ICommand GetSubCotegaryCommand { get; private set; }
        public CategoryViewModel()
        {
            GetCotegaryCommand = new Command(() => GetCotegaryExecute());
            GetSubCotegaryCommand = new Command(() => GetSubCotegaryExecute());
        }
        #endregion

        #region Property


        private List<Category> categories;
        public List<Category> Categories
        {
            get { return categories; }
            set { categories = value; RaisePropertyChanged(() => Categories); }
        }

        private List<Recipe> recipe;
        public List<Recipe> Recipes
        {
            get { return recipe; }
            set { recipe = value; RaisePropertyChanged(() => Recipes); }
        }


        #endregion

        #region Method

        #endregion

        #region Command Excute

        public void GetCotegaryExecute()
        {
            var obj = new CommonRequest();
            UserDialogs.Instance.ShowLoading("Requesting..");
            userManager.getAllCategory(obj, () =>
            {

                var categoryResponse = userManager.CategoryResponse;
                if (categoryResponse.StatusCode == 200)
                {
                    UserDialogs.Instance.HideLoading();
                    Categories = new List<Category>(categoryResponse.Categories);
                    Xamarin.Forms.Device.BeginInvokeOnMainThread(() =>
                    {
                        App.Current.MainPage = new Views.HomeView();
                    });

                }
            },
             (requestFailedReason) =>
             {
                 Xamarin.Forms.Device.BeginInvokeOnMainThread(() =>
                 {
                     //  UserDialogs.Instance.Alert(requestFailedReason.Message, null, "OK");
                     UserDialogs.Instance.HideLoading();
                 });
             });
        }

        public void GetSubCotegaryExecute()
        {
            Xamarin.Forms.Device.BeginInvokeOnMainThread(async () =>
            {
                await ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PushAsync(new SubCategoryView());
            });
            //var obj = new CommonRequest();
            //UserDialogs.Instance.ShowLoading("Requesting..");
            //userManager.getSubCategory(obj, () =>
            //{

            //    var subCategoryResponse = userManager.SubCategoryResponse;
            //    if (subCategoryResponse.StatusCode == 200)
            //    {
            //        UserDialogs.Instance.HideLoading();
            //        //Recipes = new List<Category>(subCategoryResponse.Recipes);
            //        Xamarin.Forms.Device.BeginInvokeOnMainThread(async () =>
            //        {
            //           await ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PushAsync(new SubCategoryView());
            //        });

            //    }
            //},
            // (requestFailedReason) =>
            // {
            //     Xamarin.Forms.Device.BeginInvokeOnMainThread(() =>
            //     {
            //         //  UserDialogs.Instance.Alert(requestFailedReason.Message, null, "OK");
            //         UserDialogs.Instance.HideLoading();
            //     });
            // });
        }
        #endregion



    }
}