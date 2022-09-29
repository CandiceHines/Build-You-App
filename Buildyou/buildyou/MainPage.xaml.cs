using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Buildyou
{
    public partial class MainPage : ContentPage

    {
        public Boolean gratitude { get; set; }
        public Boolean happiness { get; set; }
        public Boolean exercise { get; set; }
        public Boolean sleep { get; set; }
        public Boolean organization { get; set; }
        public Boolean diet { get; set; }
        public Boolean relationships { get; set; }
        public Boolean next { get; set; }
        public MainPage()
        {
            InitializeComponent();
        }

        void Gratitude_Clicked(System.Object sender, System.EventArgs e)
        {
            this.gratitude = true;
        }

        async void Next_Clicked(System.Object sender, System.EventArgs e)
        {
            var rootPage = new NavigationPage(new MainPage());
            await Navigation.PushModalAsync(new DurationPage());
        }

        void Relationships_Clicked(System.Object sender, System.EventArgs e)
        {
            this.relationships = true;
        }

        void Diet_Clicked(System.Object sender, System.EventArgs e)
        {
            this.diet = true;
        }

        void Organization_Clicked(System.Object sender, System.EventArgs e)
        {
            this.organization = true;
        }

        void Sleep_Clicked(System.Object sender, System.EventArgs e)
        {
            this.sleep = true;
        }

        void Exercise_Clicked(System.Object sender, System.EventArgs e)
        {
            this.exercise = true;
        }

        void Happiness_Clicked(System.Object sender, System.EventArgs e)
        {
            this.happiness = true; 
        }
    }
}
