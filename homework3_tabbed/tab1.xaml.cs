using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace homework3_tabbed
{
    public partial class tab1 : ContentPage
    {
        public tab1()
        {
            InitializeComponent();
        }

        void GoToWeb(Object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.akc.org/most-popular-breeds/2018-full-list/"));
        }
    }
}
