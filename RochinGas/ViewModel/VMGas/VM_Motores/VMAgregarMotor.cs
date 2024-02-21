using RochinGas.View.MotoresView;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RochinGas.ViewModel.VMGas.VM_Motores
{
    public class VMAgregarMotor:BaseViewModel
    {
        public VMAgregarMotor(INavigation navigation) 
        {
            Navigation = navigation;
        }
        #region Process
        public async Task Agregar()
        {
            await Navigation.PushModalAsync(new Motor());
        }
        public async Task Volver()
        {
            await Navigation.PushModalAsync(new Motor());
        }
        #endregion
        #region Commands
        public ICommand AgregarCommand => new Command(async () => await Agregar());
        public ICommand VolverCommand => new Command(async () => await Volver());
        #endregion
    }
}
