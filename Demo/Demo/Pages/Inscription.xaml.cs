﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inscription : TabbedPage
    {
        public Inscription ()
        {
            InitializeComponent();
        }
    }
}