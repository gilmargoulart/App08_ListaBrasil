using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using App08_ListaBrasil.Modelo;
using Newtonsoft.Json;

namespace App08_ListaBrasil.Servico
{
    public class Servico
    {
        private static string URLEstado = "https://servicodados.ibge.gov.br/api/v1/localidades/estados";
        private static string URLMunicipio = "https://servicodados.ibge.gov.br/api/v1/localidades/estados/{0}/municipios";

        public static List<Estado> GetEstados()
        {
            WebClient client = new WebClient();
            string json = client.DownloadString(URLEstado);
            
            return JsonConvert.DeserializeObject<List<Estado>>(json); ;
        }
        public static List<Municipio> GetMunicipios(int estado)
        {
            WebClient client = new WebClient();
            string json = client.DownloadString(string.Format(URLMunicipio, estado));

            return JsonConvert.DeserializeObject<List<Municipio>>(json); ;
        }
    }
}
