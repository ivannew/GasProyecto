﻿using RochinGas.View;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RochinGas.ViewModel.VMGas
{
    public class VMDetails:BaseViewModel
    {
        #region Constructor
        public VMDetails(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
        #region Process
        public async Task Volver()
        {
            await Navigation.PushModalAsync(new User());
        }
        #endregion
        #region Commands
        public ICommand VolverCommand => new Command(async () => await Volver());
        #endregion
    }
}