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
    public class ShoppingListViewModel : BaseViewModel
    {
        #region Constructor    

        public ICommand GetShoppingListByUserIdCommand { get; private set; }

        public ShoppingListViewModel()
        {
            GetShoppingListByUserIdCommand = new Command(() => GetShoppingListByUserIdExecute());

        }

        #endregion

        #region Property



        #endregion

        #region Method

        #endregion

        #region Command Excute

        public void GetShoppingListByUserIdExecute()
        {
            var obj = new GetShoppingListByUserIdRequest()
            {
                UserId =Convert.ToInt32 (App.AppSetup.HomeViewModel.UserId),
            };
            UserDialogs.Instance.ShowLoading("Requesting..");
            userManager.GetShoppingListByUserId(obj, () =>
            {

                var response = userManager.GetShoppingListByUserIdResponse;
                if (response.StatusCode == 200)
                {
                    UserDialogs.Instance.HideLoading();
                    //NewlyAddedRecipes = new List<NewlyAddedRecipe>(newlyAddedRecipe.NewlyAddedRecipes);
                    Device.BeginInvokeOnMainThread(async () =>
                    {
                        await ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PushAsync(new ShoppingListView());
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