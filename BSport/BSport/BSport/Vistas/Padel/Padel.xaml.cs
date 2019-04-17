using BSport.ModeloParaVista;
using BSport.Modelos;
using BSport.Vistas;
using BSport.Vistas.Padel;
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
    public partial class Padel : ContentPage
    {
        Partidos p;
        PartidosParaPadel pp;
        public Padel()
        {
            InitializeComponent();
            // TODO
            // Este constructor inicializa su array interno, es ahí dónde debo pretender hacer la petición de datos al servidor y rellenar el array mediante la base de datos. (??????)
            pp = new PartidosParaPadel();
            BindingContext = pp;
        }
        public void OnListItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            p = (Partidos)e.SelectedItem;
        }
        async public void OnVerClicked(object sender, EventArgs e)
        {
            if (p != null)
            {
                await Navigation.PushAsync(new PadelPartido(p));
            }

        }
        async public void OnCrearPartidoClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CrearPartido());
        }
    }
}