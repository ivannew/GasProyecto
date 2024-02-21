using Xamarin.Forms;
using RochinGas.View;

namespace RochinGas
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Login());
        }
    }
}
