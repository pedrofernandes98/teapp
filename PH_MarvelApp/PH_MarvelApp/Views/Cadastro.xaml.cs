using PH_MarvelApp.Models;
using PH_MarvelApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PH_MarvelApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Cadastro : ContentPage
	{
        private UserService _service;
		public Cadastro ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string email = txtEmail.Text;
            string senha = txtSenha.Text;
            string confirmarSenha = txtConfirmarSenha.Text;

            string nomeCrianca = txtNomeCrianca.Text;
            string data = txtDataNascCrianca.Text;
            //string sexo = pckSexo.GetValue().ToString() ;

            User myUser = new User()
            {
                nomeResponsavel = nome,
                email = email,
                senha = senha,
                nomeCrianca = nomeCrianca,
                DataNascimento = Convert.ToDateTime(data),
                sexoCriaca = 0
            };

            //ResponseService responseService = await _service.AddUserAsync(myUser);


        }

        private void RedirectToLogin(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}