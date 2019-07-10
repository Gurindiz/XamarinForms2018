using App01ConsultarCEP.Servico.Modelo;
using Newtonsoft.Json;
using System.Net;

namespace App01ConsultarCEP.Servico
{
    public class ViaCEPServico
    {
        private static string EnderecoURL = "https://viacep.com.br/ws/{0}/json/";

        public static Endereco BuscarEnderecoViaCEP(string cep)
        {
            string NovoEnderecoURL = string.Format(EnderecoURL, cep);

            WebClient WC = new WebClient();
            string Conteudo = WC.DownloadString(NovoEnderecoURL);

            Endereco end = JsonConvert.DeserializeObject<Endereco>(Conteudo);

            if (end.cep == null)
                return null;

            return end;
        }
    }
}
