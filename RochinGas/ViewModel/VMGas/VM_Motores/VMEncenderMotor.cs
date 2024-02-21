using RochinGas.View;
using RochinGas.View.MotoresView;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RochinGas.ViewModel.VMGas
{
    public class VMEncenderMotor:BaseViewModel
    {
        #region Builder
        public VMEncenderMotor(INavigation navigation) 
        {
            Navigation = navigation;
        }
        #endregion
        #region Process
        public async Task DetallesMotores()
        {
            await Navigation.PushModalAsync(new Motor());
        }
        public async Task Volver()
        {
            await Navigation.PushModalAsync(new TiempoReal());
        }
        #endregion
        #region Commands
        public ICommand MotoresCommand => new Command(async () => await DetallesMotores());
        public ICommand VolverCommand => new Command(async () => await Volver());
        #endregion
    }
}
