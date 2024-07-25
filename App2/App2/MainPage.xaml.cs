using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace App2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

           
        }

        private void btnVerPinterest_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://pin.it/6DIvImN2y", BrowserLaunchMode.SystemPreferred);

        }

        private void btnVerLinkedin_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://www.linkedin.com/in/nailea-pinales-529ab72ba?utm_source=share&utm_campaign=share_via&utm_content=profile&utm_medium=ios_app", BrowserLaunchMode.SystemPreferred);
        }

        private void btnVerFacebook_Clicked(object sender, EventArgs e)
        {
            
        }

        private void btnVerInstagram_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://www.instagram.com/nailea_p12?igsh=YXp1bTE1c2hpOTV5&utm_source=qr", BrowserLaunchMode.SystemPreferred);
        }
    }


}
