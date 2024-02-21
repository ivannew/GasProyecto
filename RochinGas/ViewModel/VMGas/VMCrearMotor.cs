using RochinGas.View;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RochinGas.ViewModel.VMGas
{
    public class VMCrearMotor:BaseViewModel
    {
        #region Builder
        public VMCrearMotor(INavigation navigation) 
        {
            Navigation = navigation;
        }
        #endregion
        #region Process
        public async Task Agregar()
        {
            await Navigation.PushModalAsync(new ListMotors());
        }
        public async Task Volver()
        {
            await Navigation.PushModalAsync(new ListMotors());
        }
        #endregion
        #region Commands
        public ICommand AgregarCommand => new Command(async () => await Agregar());
        public ICommand VolverCommand => new Command(async () => await Volver());
        #endregion
    }
}
