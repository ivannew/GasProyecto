using RochinGas.View;
using RochinGas.View.MotoresView;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RochinGas.ViewModel
{
    public class VMtimporeal : BaseViewModel
    {
        private readonly INavigation _navigation;

        public VMtimporeal(INavigation navigation)
        {
            _navigation = navigation;
            MotorButtonCommand = new Command(async () => await OnMotorButtonClicked());
            SensorButtonCommand = new Command(async () => await OnSensorButtonClicked());
            ProfileButtonCommand = new Command(async () => await OnProfileButtonClicked());
            EncenderSensorCommand = new Command(async () => await OnEncenderSensor());
            EncenderMotorCommand = new Command(async () => await OnEncenderMotor());
         

            VolverCommand = new Command(async () => await Volver());

        }
        public ICommand VolverCommand { get; }
        public ICommand MotorButtonCommand { get; }
        public ICommand SensorButtonCommand { get; }
        public ICommand ProfileButtonCommand { get; }
        public ICommand EncenderSensorCommand { get; }

      
        public ICommand EncenderMotorCommand { get; }
        private async Task OnEncenderSensor()
        {
            // Navegar a la página de sensores
            await _navigation.PushModalAsync(new EncenderSensor());
        }
        private async Task OnEncenderMotor()
        {
            // Navegar a la página de motores
            await _navigation.PushModalAsync(new EncenderMotor());
        }

        private async Task OnMotorButtonClicked()
        {
            // Navigate to the motor-related view
            await _navigation.PushModalAsync(new Motor());
        }

        private async Task OnSensorButtonClicked()
        {
            // Navigate to the sensorPushModalAsyncrelated view
            await _navigation.PushModalAsync(new MainPage());
        }

        private async Task OnProfileButtonClicked()
        {
            // Navigate to the profile view
            await _navigation.PushModalAsync(new User());
        }
        public async Task Volver()
        {
            await Navigation.PushModalAsync(new TiempoReal());
        }
    }
}
