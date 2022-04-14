using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace lab04
{
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }
        async void OnPreviousPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
