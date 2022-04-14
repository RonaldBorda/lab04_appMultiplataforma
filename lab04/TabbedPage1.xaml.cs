using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace lab04
{
    public partial class TabbedPage1 : TabbedPage
    {
        public TabbedPage1()
        {
            InitializeComponent();
            btnClose.Clicked += async (sender, e) =>
            {
                await Navigation.PopAsync();
            };
        }
    }
}
