using RochinGas.ViewModel.VMGas.VM_Sensores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RochinGas.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EncenderSensor : ContentPage
	{
		public EncenderSensor ()
		{
			InitializeComponent ();
			BindingContext = new VMEncenderSensores(Navigation);
		}
	}
}