using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BSport
{
    public partial class MainPage : ContentPage
    {
        private bool isValid = false;
        public MainPage()
        {
            InitializeComponent();
        }
        async void OnEnterClicked(object sender, EventArgs args)
        {
            if (name.Text != null && name.Text.Trim() != "" && pass.Text != null && pass.Text.Trim() != "")
            {
                nombre.Text = "Válido";
                contraseña.Text = "Válida";
                isValid = true;
            }
            else
            {
                nombre.Text = "No válido";
                contraseña.Text = "No válida";
            }
            if (isValid)
            {
                await Navigation.PushAsync(new Menu(name.Text));
            }
        }
    }
}
