using System;
using System.Collections.Generic;
using System.Text;

namespace App01ConsultarCEP.Servico
{
    public class ViaCepServico
    {
        private static string EnderecoURL = "https://viacep.com.br/ws/{0}/json/";

        public static void BuscarEnderecoViaCep(string cep)
        {
            string NovoEnderecoURL = string.Format(EnderecoURL, cep);
        }
    }
}
