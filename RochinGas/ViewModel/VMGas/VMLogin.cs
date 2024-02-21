using RochinGas.View;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RochinGas.ViewModel.VMGas
{
    public class VMLogin:BaseViewModel
    {
        #region Constructor
        public VMLogin(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
        #region Proces
        public async Task SignInUser()
        {
            await Navigation.PushModalAsync(new SingIn());
        }
        public async Task GoToMain()
        {
            await Navigation.PushModalAsync(new TiempoReal());
        }
        #endregion
        #region Commands
        public ICommand IniciarCommand => new Command(async () => await GoToMain());
        public ICommand registrarCommand => new Command(async () => await SignInUser());
        #endregion
    }
}
