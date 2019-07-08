using App01ConsultarCEP.Servico;
using App01ConsultarCEP.Servico.Modelo;
using System;
using Xamarin.Forms;

namespace App01ConsultarCEP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BOTAO.Clicked += BuscarCEP;
        }

        private void BuscarCEP(object sender, EventArgs args)
        {
            //TODO - Lógica do programa.

            //TODO - Validações.

            string cep = CEP.Text.Trim();
            Endereco end = ViaCEPServico.BuscarEnderecoViaCEP(cep);

            RESULTADO.Text = string.Format("Endereco: {2} de {3} {0}, {1}", end.localidade, end.uf, end.logradouro, end.bairro);
        }
    }
}
