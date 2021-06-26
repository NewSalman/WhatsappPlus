﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhatAppPlus.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WhatAppPlus.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CallsPage : ContentPage
    {
        public CallsPage()
        {
            InitializeComponent();
            this.BindingContext = new HomeViewModel();
        }
    }
}