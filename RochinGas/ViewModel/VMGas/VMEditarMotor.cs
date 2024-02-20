using RochinGas.View;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RochinGas.ViewModel.VMGas
{
    public class VMEditarMotor:BaseViewModel
    {
        #region Builder
        public VMEditarMotor(INavigation navigation) 
        {
            Navigation = navigation;
        }
        #endregion
        #region Process
        public async Task Editar()
        {
            await Navigation.PushModalAsync(new ListMotors());
        }
        public async Task Volver()
        {
            await Navigation.PushModalAsync(new ListMotors());
        }
        #endregion
        #region Commands
        public ICommand EditarCommand => new Command(async () => await Editar());
        public ICommand VolverCommand => new Command(async () => await Volver());
        #endregion
    }
}
