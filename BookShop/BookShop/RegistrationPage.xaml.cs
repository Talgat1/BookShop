using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BookShop
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private async void Back_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AuthorizationPage());
        }

        private async void RegisBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new HomePage()));
        }
    }
}