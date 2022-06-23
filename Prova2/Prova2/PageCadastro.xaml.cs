using Prova2.Conn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Prova2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageCadastro : ContentPage
    {
        public PageCadastro()
        {
            InitializeComponent();
        }

        ClassBase classb = new ClassBase();

        string nome;
        string email;
        string senha;
        string confSenha;
        //public string emailCad;
        //public string senhaCad;
        //public string confSenhaCad;

        //----------------------------------------------------------------------------------
        //Disparo de Email
       
        //Disparo de Email
        //----------------------------------------------------------------------------------
        //Botao google imagem
        private async void ImageButton_Clicked_1(object sender, EventArgs e)
        {
            await DisplayAlert("Cadastrado com Google", "Registrado com sucesso", "Ok");
        }
        //Botao google imagem
        //----------------------------------------------------------------------------------
        //Botao github imagem
        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Cadastrado com GitHub", "Registrado com sucesso", "OK");
        }
        //Botao github imagem

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
           
            nome = etNome.Text;
            email = etEmail.Text;
            senha = etSenha.Text;
            confSenha = etConfSenha.Text;

            if (email != null && senha != null && confSenha != null && senha == confSenha)
            {
                
                try
                {
                    ClassBase entra = new ClassBase();
                    entra.Cadastro(nome,email,senha);

                    MailMessage mail = new MailMessage("xamarin.formes2022@hotmail.com", email);

                    mail.Subject = "ACTIVHOUSE";
                    mail.IsBodyHtml = true;
                    mail.Body = $"Olá {nome} Seja Bem-Vindo ao ActivHouse um aplicativo de rastreio de produtos";
                    mail.BodyEncoding = Encoding.GetEncoding("UTF-8");
                    mail.SubjectEncoding = Encoding.GetEncoding("UTF-8");

                    SmtpClient client = new SmtpClient("smtp.office365.com", 587);

                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential("xamarin.formes2022@hotmail.com", "9625gils.");

                    client.EnableSsl = true;

                    client.Send(mail);

                    await DisplayAlert("Registrado com sucesso", "Seja bem vindo ao ACTIVHOUSE", "Ok");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    await DisplayAlert("Erro", $"{ex.Message}", "Tente novamnte");
                }
            }
            else
            {
                await DisplayAlert("Erro", "Confirme seu email e sua senha para proceguir", "Tente novamnte");
            }

        }
        //----------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------





    }
}