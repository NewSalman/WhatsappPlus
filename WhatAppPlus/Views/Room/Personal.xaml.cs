using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhatAppPlus.Models;
using WhatAppPlus.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WhatAppPlus.Views.Room
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Personal : ContentPage
    {
        public Personal()
        {
            InitializeComponent();
            this.BindingContext = new HomeViewModel();
            
        }
    }
}