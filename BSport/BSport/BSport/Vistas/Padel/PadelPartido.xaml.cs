using BSport.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BSport.Vistas.Padel
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PadelPartido : ContentPage
	{
		public PadelPartido (object p)
		{
			InitializeComponent ();
            BindingContext = (Partidos)p;
		}
	}
}