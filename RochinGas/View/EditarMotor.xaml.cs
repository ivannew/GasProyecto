using RochinGas.ViewModel.VMGas;
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
	public partial class EditarMotor : ContentPage
	{
		public EditarMotor ()
		{
			InitializeComponent ();
			BindingContext = new VMEditarMotor(Navigation);
		}
	}
}