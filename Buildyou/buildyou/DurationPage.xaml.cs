using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Buildyou
{
    public partial class DurationPage : ContentPage
    {
        public DurationPage()
        {
            InitializeComponent();

        }

        private async void Done_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new To_Do());
        }

        async void Back_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopModalAsync();
           
 
        }

    }
}

