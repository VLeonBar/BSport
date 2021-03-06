﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using BSport.Modelos;
using BSport.Vistas;

namespace BSport
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPage
    {
        public Usuario Usuario { get; set; }
        public Menu(Usuario usuario)
        {
            InitializeComponent();
            Usuario = usuario;
            NavigationPage.SetHasBackButton(this, false);
        }
        async void OnBtnMenuClicked(object sender, EventArgs args)
        {
            switch (((Button)sender).Text)
            {
                case "Pádel":
                    await Navigation.PushAsync(new PartidosPadel(Usuario));
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