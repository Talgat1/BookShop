using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BookShop.TabbedPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchPage : ContentPage
    {
        public SearchPage()
        {
            InitializeComponent();
        }

        private async void GenreBtn_Clicked(object sender, EventArgs e)
        {
            
            string result = await DisplayActionSheet("Выберите жанр:", null, null, App.genre);

            switch (result)
            {
                case "Фэнтези":
                    
                    break;

                case "Детектив":
                    
                    break;

                case "Ужасы":
                    
                    break;

                case "Приключение":
                    
                    break;

            }

        }
    }
}