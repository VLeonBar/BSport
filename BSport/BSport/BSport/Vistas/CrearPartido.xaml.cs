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
    public partial class CrearPartido : ContentPage
    {
        public CrearPartido()
        {
            InitializeComponent();
            stackStepper.BindingContext = stepperJugadores;
        }

        private void StepperJugadores_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            /*En el caso de dejar a empresas crear partidos vacíos para que la gente se una, se dejaría crear un partido vacío, 
            por el momento sólo se podrán crear partidos con 1 jugador mínimo.*/

            switch (e.NewValue)
            {
                case 1:
                    stackJ2.IsVisible = true;
                    stackJ3.IsVisible = true;
                    break;

                case 2:
                    stackJ2.IsVisible = true;
                    stackJ3.IsVisible = false;
                    break;

                case 3:
                    stackJ2.IsVisible = false;
                    stackJ3.IsVisible = false;
                    break;

                //case 4:
                //    stackJ1.IsVisible = false;
                //    stackJ2.IsVisible = false;
                //    stackJ3.IsVisible = false;
                //    break;
            }
        }
    }
}