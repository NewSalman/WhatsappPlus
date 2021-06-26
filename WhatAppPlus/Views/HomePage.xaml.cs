using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhatAppPlus.ViewModels;
using WhatAppPlus.Views.Room;
using Xamarin.Forms;
using Xamarin.Forms.StyleSheets;
using Xamarin.Forms.Xaml;

namespace WhatAppPlus.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            this.BindingContext = new HomeViewModel();
            
        }

        async void ItemSelectionChange(object sender, SelectionChangedEventArgs e)
        {
            await Navigation.PushAsync(new Personal());
        }
    }
}