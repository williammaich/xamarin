using System;
using Xamarin.Forms;

namespace App2
{

   public class Veiculo{
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public string PrecoFormatado
        {
            get { return string.Format("R$ {0}", Preco); }
        }
    }

    public partial class MainPage : ContentPage
	{
        public System.Collections.Generic.List<Veiculo> Veiculos { get; set; }


        public MainPage()
		{
			InitializeComponent();

            this.Veiculos = new System.Collections.Generic.List<Veiculo>
            {
                new Veiculo {Nome = "Azera V6", Preco = 60000},
                new Veiculo {Nome = "Fiesta 2.0", Preco = 50000},
                new Veiculo {Nome = "HB20 S", Preco = 40000}
            };

            this.BindingContext = this;
            
		}

        private void listViewVeiculos_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            //esse metodo foi criado no xaml para um evento de toque.


            var veiculo = (Veiculo )e.Item;
            // coloca a variavel () e tambem converte o objeto para veiculo colocando entre parenteses.
            //e. é o objeto que ja vem instanciado.

            DisplayAlert("Test Drive", string.Format("você tocou no modelo '{0}', que custa {1}", veiculo.Nome, veiculo.PrecoFormatado), "ok");
            //aqui faz o alerta e tras a mensagem quando clicar {0} é o marcador do list tras o nome   {1} tras o preco
        }
    }

   
}
