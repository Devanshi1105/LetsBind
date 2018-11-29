using GalaSoft.MvvmLight.Ioc;
using LetsCookApp.Managers.ApiProvider;
using LetsCookApp.Managers.SettingsManager;
using LetsCookApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsCookApp
{
    public class AppSetup
    {
        public AppSetup()
        {
            //Viewmodel
            SimpleIoc.Default.Register<LoginViewModel>();
            SimpleIoc.Default.Register<HomeViewModel>();
            SimpleIoc.Default.Register<SignUpViewModel>();
            SimpleIoc.Default.Register<CategoryViewModel>();

            // Services
            SimpleIoc.Default.Register<ISettingsManager, SettingsManager>();
           SimpleIoc.Default.Register<IApiProvider, ApiProvider>();
            SimpleIoc.Default.Register<IManager, Manager>();
        }

        public void Clear()
        {
            SimpleIoc.Default.Unregister<LoginViewModel>(); 
            SimpleIoc.Default.Unregister<SignUpViewModel>();
            SimpleIoc.Default.Unregister<CategoryViewModel>();

            SimpleIoc.Default.Register<LoginViewModel>(); 
            SimpleIoc.Default.Register<SignUpViewModel>();
            SimpleIoc.Default.Register<CategoryViewModel>();

        }
        public LoginViewModel LoginViewModel
        {
            get
            {
                return SimpleIoc.Default.GetInstance<LoginViewModel>();
            }
        }
        public SignUpViewModel SignUpViewModel
        {
            get
            {
                return SimpleIoc.Default.GetInstance<SignUpViewModel>();
            }
        }

        public HomeViewModel HomeViewModel
        {
            get
            {
                return SimpleIoc.Default.GetInstance<HomeViewModel>();
            }
        }
        public CategoryViewModel CategoryViewModel
        {
            get
            {
                return SimpleIoc.Default.GetInstance<CategoryViewModel>();
            }
        }
    }
}
