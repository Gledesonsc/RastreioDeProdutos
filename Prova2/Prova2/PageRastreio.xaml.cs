using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Correios.NET;

namespace Prova2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageRastreio : ContentPage
    {
        public PageRastreio()
        {
            InitializeComponent();
        }

        private async void btn_Clicked(object sender, EventArgs e)
        {
            try
            {
                var rastreio = await new CorreiosService().GetPackageTrackingAsync(entRastreio.Text);
                
                string lastStatus = rastreio.LastStatus.ToString();

                string localEncomenda = lastStatus.Substring(20);

                string dataPostagem = lastStatus.Substring(0, 16);

                string i = lastStatus.Substring(20).Replace('(', ' ').Replace(')', ' ').Replace('-', ' ').Replace('>', ' ');
                lblRastreio.Text = "";
                lblRastreio.Text = $"{i}";

                string[] status = lastStatus.Split('-');
                foreach (var item in status)
                {
                    lblCidade.Text = "";
                    lblCidade.Text = $"{item}";
                }


                lblEstado.Text = "";
                lblEstado.Text = $"Ultima atualização {dataPostagem}";
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Código incorreto - Erro: {ex.Message}");
                await DisplayAlert("Erro", "Pacote não encontrado", "Tente novamente");
            }
        }
    }
}