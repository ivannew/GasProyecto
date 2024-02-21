using RochinGas.View;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RochinGas.ViewModel.VMGas
{
    public class VMSignIn:BaseViewModel
    {
        #region Constructor
        public VMSignIn(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
        #region Proces
        public async Task LogIn()
        {
            await Navigation.PushModalAsync(new Login());
        }
        public async Task GoToMain()
        {
            await Navigation.PushModalAsync(new TiempoReal());
        }
        #endregion
        #region Commands
        public ICommand LoginCommand => new Command(async () => await LogIn());
        public ICommand GoMainCommand => new Command(async () => await GoToMain());
        #endregion
    }
}
