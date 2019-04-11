using BSport.ModeloParaVista;
using BSport.Modelos;
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

        PartidosParaPadel pp;
        public Padel()
        {
            InitializeComponent();
            pp = new PartidosParaPadel();
            BindingContext = pp;
        }
        public void OnListItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Console.WriteLine(((Partidos)e.SelectedItem).Hora);
        }
    }
}