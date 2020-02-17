using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace homework3_tabbed
{
    public partial class tab3 : ContentPage
    {
        public tab3()
        {
            InitializeComponent();
        }

        void ContentPage_Appearing(System.Object sender, System.EventArgs e)
        {
            DisplayAlert("Notice", "You are currently viewing information for French Bulldogs.", "Ok");
        }
    }
}
