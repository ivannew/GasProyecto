using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using RochinGas.ViewModel;


namespace RochinGas.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TiempoReal : ContentPage
    {
        public TiempoReal()
        {
            InitializeComponent();
            BindingContext = new VMtimporeal(Navigation);
        }
    }

}
