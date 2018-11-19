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


            // Services
            SimpleIoc.Default.Register<ISettingsManager, SettingsManager>();
           SimpleIoc.Default.Register<IApiProvider, ApiProvider>();
            SimpleIoc.Default.Register<IManager, Manager>();
        }

        public void Clear()
        {
            SimpleIoc.Default.Unregister<LoginViewModel>();
            //SimpleIoc.Default.Unregister<HomeViewModel>();
            SimpleIoc.Default.Unregister<SignUpViewModel>();

            SimpleIoc.Default.Register<LoginViewModel>();
          
            SimpleIoc.Default.Register<SignUpViewModel>();

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
    }
}
