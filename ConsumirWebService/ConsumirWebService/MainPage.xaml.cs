using ConsumirWebService.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ConsumirWebService
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            RestClient cliente = new RestClient();
            var resultado = await cliente.Get<ResponsePublico>("https://gorest.co.in/public/v1/users/123");

            string ValorEtiqueta="";

            if (resultado != null) {
                ValorEtiqueta = "Bienvenido : " + resultado.data.name + " tu correo es: " + resultado.data.email;
            }
            else {

                ValorEtiqueta = "No se pudieron cargar los datos";
            }


            Resultado.Text = ValorEtiqueta;

        }
    }
}
