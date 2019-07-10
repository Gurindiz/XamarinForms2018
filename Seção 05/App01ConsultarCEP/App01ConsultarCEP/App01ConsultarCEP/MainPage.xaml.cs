﻿using App01ConsultarCEP.Servico;
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
            string cep = CEP.Text.Trim();

            if (IsValidCEP(cep))
            {
                try
                {
                    Endereco end = ViaCEPServico.BuscarEnderecoViaCEP(cep);

                    if (end != null)
                        RESULTADO.Text = string.Format("Endereco: {0}, {1}, {2}/{3}", end.logradouro, end.bairro, end.localidade, end.uf);
                    else
                        DisplayAlert("ERRO", "O endereço não foi encontrado para o CEP informado: " + cep, "OK");
                }
                catch (Exception e)
                {
                    DisplayAlert("ERRO CRÍTICO", e.Message, "OK");
                }
            }
        }

        private bool IsValidCEP(string cep)
        {
            bool Valido = true;

            if (cep.Length != 8)
            {
                DisplayAlert("ERRO", "CEP inválido! O CEP deve conter 8 caracteres", "OK");
                Valido = false;
            }

            int NovoCEP = 0;
            if(!int.TryParse(cep, out NovoCEP))
            {
                DisplayAlert("ERRO", "CEP inválido! O CEP deve ser composto apenas por números.", "OK");
                Valido = false;
            }

            return Valido;
        }
    }
}
