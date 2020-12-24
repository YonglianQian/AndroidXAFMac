using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AppCenter.Analytics;
using Xamarin.Forms;

namespace AndroidXAFMac
{
    public partial class MainPage : ContentPage
    {
        int counter = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Analytics.TrackEvent("Button is clicked at " + DateTime.Now.ToLongTimeString());

            counter++;
            MyButton.Text = $"You clicked {counter} times";
        }
    }
}
