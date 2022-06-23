using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace Prova2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //
        public string Usuario = "elias";
        public string Senha = "03012000";


        //public string usuLog;
        //public string senhaLog;
        //PageCadastro pc = new PageCadastro();



        //Pagina de Login
        //Back-end         Back-end          Back-end        Back-end        Back-end
        //----------------------------------------------------------------------------------
        private async void btnEntrar_Clicked(object sender, EventArgs e)
        {
            //
            //Botao Entrar de Login
            if (etEmail.Text != null && etSenha.Text != null)
            {

                if (etEmail.Text == Usuario && etSenha.Text == Senha)
                {
                    await DisplayAlert("Sucesso", "Senha Valida", "Ok");
                    await Navigation.PushAsync(new PageRastreio());
                }
                //  
            }
            else
            {
                await DisplayAlert("Erro", "Senha Invalida", "Tente Novamente");
            }


        }
        //Botao Entrar de Login
        //----------------------------------------------------------------------------------
        //Botao google imagem
        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Login com Google", "Acesso liberado", "OK");
        }
        //Botao google imagem
        //----------------------------------------------------------------------------------
        //Botao github imagem
        private async void ImageButton_Clicked_1(object sender, EventArgs e)
        {
            await DisplayAlert("Login com GitHub", "Acesso liberado", "OK");
        }
        //Botao github imagem
        //----------------------------------------------------------------------------------
        private async void btnCadastrar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageCadastro());
        }
        //----------------------------------------------------------------------------------
        //Back-end         Back-end          Back-end        Back-end        Back-end
        //Pagina de Login
    }
}
