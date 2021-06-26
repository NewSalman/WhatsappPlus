using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WhatAppPlus.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public BaseViewModel()
        {

        }

        protected void OnPropertyChaged([CallerMemberName] string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        protected async Task PopAsync(bool ToRoot)
        {
            if(!ToRoot)
            {
                await App.Current.MainPage.Navigation.PopAsync();
            }

            await App.Current.MainPage.Navigation.PopToRootAsync();
        }
    }
}
