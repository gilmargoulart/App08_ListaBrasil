using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App08_ListaBrasil.Modelo;

namespace App08_ListaBrasil
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Estados : ContentPage
	{
		public Estados ()
		{
			InitializeComponent ();
            listaEstados.ItemsSource = Servico.Servico.GetEstados();
		}

        private void ListaEstados_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Estado estado = (Estado)e.SelectedItem;
            Navigation.PushAsync(new Municipios(estado));
        }
    }
}