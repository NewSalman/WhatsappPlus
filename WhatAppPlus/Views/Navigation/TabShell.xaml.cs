using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WhatAppPlus.Views.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabShell : TabbedPage
    {
        public TabShell()
        {
            InitializeComponent();
            
        }
    }
}