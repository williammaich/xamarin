using System;
using Xamarin.Forms;

namespace App2
{

   public class Veiculo{
        public string Nome { get; set; }
        public decimal Preco { get; set; }
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
	}

   
}
