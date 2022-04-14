using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace lab04
{
    public partial class CarouselPage1 : CarouselPage
    {
        public CarouselPage1()
        {
            InitializeComponent();
            btnClose.Clicked += async (sender, e) =>
            {
                await Navigation.PopAsync();
            };

        }
    }
}
