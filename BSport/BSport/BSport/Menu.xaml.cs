using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BSport
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPage
    {
        public Menu(string nombre)
        {
            InitializeComponent();
        }
        async void OnBtnMenuClicked(object sender, EventArgs args)
        {
            switch (((Button)sender).Text)
            {
                case "Pádel":
                    await Navigation.PushAsync(new Padel());
                    break;
                case "Fútbol":
                    Console.WriteLine("POS VA A SER FURBO");
                    break;
                default:
                    break;
            }
        }
    }
}