using App2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2.Views
{

   

    public partial class ListagemView : ContentPage
    {
        public List<Veiculo> Veiculos { get; set; }


        public ListagemView()
        {
            InitializeComponent();


          

            this.Veiculos = new ListagemVeiculos().Veiculos;

            this.BindingContext = this;

        }

        private void listViewVeiculos_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            //esse metodo foi criado no xaml para um evento de toque.


            var veiculo = (Veiculo)e.Item;
            // coloca a variavel () e tambem converte o objeto para veiculo colocando entre parenteses.
            //e. � o objeto que ja vem instanciado.

            Navigation.PushAsync(new DetalheView(veiculo));
        }
    }


}