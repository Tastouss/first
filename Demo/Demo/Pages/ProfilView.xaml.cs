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
	public partial class ProfilView : ContentView
	{
		public ProfilView ()
		{
			InitializeComponent ();
		}

	    private async void Button_OnClicked(object sender, EventArgs e)
	    {
	       // var answer = await DisplayAlert("Question?", "Would you like to play a game", "Yes", "No");

        }
    }
}