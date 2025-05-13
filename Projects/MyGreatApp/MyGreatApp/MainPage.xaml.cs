using System;
using Microsoft.Maui.Controls;

namespace MyGreatApp

{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnRedClicked(object sender, EventArgs e)
        {
            this.BackgroundColor = Colors.Red;
        }

        private void OnGreenClicked(object sender, EventArgs e)
        {
            this.BackgroundColor = Colors.Green;
        }

        private void OnBlueClicked(object sender, EventArgs e)
        {
            this.BackgroundColor = Colors.Blue;
        }

        private void OnYellowClicked(object sender, EventArgs e)
        {
            this.BackgroundColor = Colors.Yellow;
        }
    }
}
