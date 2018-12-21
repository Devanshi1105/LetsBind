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
   public class MyFavouritesRecipesViewModel : BaseViewModel
    {
        #region Constructor    

        public ICommand GetFavsByUserIdCommand { get; private set; }

        public MyFavouritesRecipesViewModel()
        {
            GetFavsByUserIdCommand = new Command(() => GetFavsByUserIdExecute());

        }

        #endregion

        #region Property



        #endregion

        #region Method

        #endregion

        #region Command Excute

        public void GetFavsByUserIdExecute()
        {
            var obj = new GetFavsByUserIdRequest()
            {
                 UserId=(App.AppSetup.HomeViewModel.UserId),
            };
            UserDialogs.Instance.ShowLoading("Requesting..");
            userManager.GetFavsByUserId(obj, () =>
            {

                var response = userManager.GetFavsByUserIdResponse;
                if (response.StatusCode == 200)
                {
                    UserDialogs.Instance.HideLoading();
                    //NewlyAddedRecipes = new List<NewlyAddedRecipe>(newlyAddedRecipe.NewlyAddedRecipes);
                    Device.BeginInvokeOnMainThread(async () =>
                    {
                        await ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PushAsync(new MyFavouritesRecipesView());
                    });

                }
            },
             (requestFailedReason) =>
             {
                 Device.BeginInvokeOnMainThread(() =>
                 {
                     //  UserDialogs.Instance.Alert(requestFailedReason.Message, null, "OK");
                     UserDialogs.Instance.HideLoading();
                 });
             });
        }

        #endregion



    }
}