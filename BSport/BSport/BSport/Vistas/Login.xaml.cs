using BSport.Funciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BSport.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }
        public async void OnEntrarClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Menu());
            //ConexionBD bd = new ConexionBD();
            //if (bd.ConectaBD())
            //{
            //    name.Text = "CONECTADO";
            //}
        }
        public async void OnRegistroClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Registro());
        }
    }
}