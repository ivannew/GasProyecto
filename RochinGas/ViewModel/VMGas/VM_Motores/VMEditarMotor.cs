using RochinGas.View.MotoresView;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RochinGas.ViewModel.VMGas.VM_Motores
{
    public class VMEditarMotor:BaseViewModel
    {
        public VMEditarMotor(INavigation navigation) 
        {
            Navigation = navigation;
        }
        #region Process
        public async Task Editar()
        {
            await Navigation.PushModalAsync(new Motor());
        }
        public async Task Volver()
        {
            await Navigation.PushModalAsync(new Motor());
        }
        #endregion
        #region Commands
        public ICommand EditarCommand => new Command(async () => await Editar());
        public ICommand VolverCommand => new Command(async () => await Volver());
        #endregion
    }
}
