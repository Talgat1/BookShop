using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookShop.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BookShop.TabbedPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HousePage : ContentPage
    {
        public HousePage()
        {
            InitializeComponent();
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddBookPage());
        }
        private async void GoodsLstViw_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            //var d = (Book)e.Item;
            //var a = new BookPage(d);
            //a.BindingContext = d;
            await Navigation.PushAsync(new BookPage());
        }
    }
}