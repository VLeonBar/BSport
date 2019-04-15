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
        public async void OnEnterClicked(object sender, EventArgs args)
        {
            ConexionBD bd = new ConexionBD();
            if (bd.conectaBD())
            {
                name.Text = "CONECTADO";
                await Navigation.PushAsync(new Menu());
            }
        }
    }
}