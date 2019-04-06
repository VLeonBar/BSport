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
        private string nombre;
        public Menu(string nombre)
        {
            InitializeComponent();
            this.nombre = nombre;
            test.Text = "Nombre de usuario actual " + nombre;
        }
        async void OnEnterClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Padel());
        }
    }
}