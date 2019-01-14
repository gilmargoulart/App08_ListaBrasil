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
	public partial class Municipios : ContentPage
	{
        private List<Municipio> ListaMunicipios { get; set; }
        private List<Municipio> ListaMunicipiosFiltrada { get; set; }

        public Municipios (Estado estado)
		{
			InitializeComponent ();

            ListaMunicipios = Servico.Servico.GetMunicipios(estado.id);
            lvListaMunicipios.ItemsSource = ListaMunicipios;
		}

        private void ListaMunicipios_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //
        }

        private void TxtMunicipio_TextChanged(object sender, TextChangedEventArgs e)
        {
            FiltrarMunicipio(e.NewTextValue);
        }

        private void TxtMunicipio_SearchButtonPressed(object sender, EventArgs e)
        {
            FiltrarMunicipio(txtMunicipio.Text);
        }

        private void FiltrarMunicipio(string filtro)
        {
            ListaMunicipiosFiltrada = ListaMunicipios.Where(m => m.nome.ToLower().Contains(filtro.ToLower())).ToList();
            lvListaMunicipios.ItemsSource = ListaMunicipiosFiltrada;
        }

    }
}