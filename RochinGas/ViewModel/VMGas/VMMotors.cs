using RochinGas.View;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RochinGas.ViewModel.VMGas
{
    public class VMMotors:BaseViewModel
    {
        #region Builder
        public VMMotors(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
        #region Process
        public async Task Volver()
        {
            await Navigation.PushModalAsync(new MainPage());
        }
        public async Task Crear()
        {
            await Navigation.PushModalAsync(new CrearMotor());
        }
        public async Task Editar()
        {
            await Navigation.PushModalAsync(new EditarMotor());
        }
        #endregion
        #region Commands
        public ICommand VolverCommand => new Command(async () => await Volver());
        public ICommand CrearCommand => new Command(async () => await Crear());
        public ICommand EditarCommand => new Command(async () => await Editar());
        #endregion
    }
}
