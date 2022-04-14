using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace lab04
{
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();

            btnClose.Clicked += async (sender, e) =>
            {
                await Navigation.PopAsync();
            };
        }

        async void OnNextPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }
    }
}
