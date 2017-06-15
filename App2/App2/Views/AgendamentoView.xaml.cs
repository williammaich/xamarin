using App2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2.Views
{

    public partial class AgendamentoView : ContentPage
    {
        public Veiculo Veiculo { get; set; }

        public string Nome { get; set; }
        public string Fone { get; set; }
        public string Email { get; set; }


        DateTime dataAgendamento = DateTime.Today;
        public DateTime DataAgendamento
        {
            get
            {
                return dataAgendamento;
            }
            set
            {
                dataAgendamento = value;
            }

        }


        TimeSpan horaAgendamento = TimeSpan.Zero;
        public TimeSpan HoraAgendamento
        {
            get
            {
                return horaAgendamento;
            }
            set
            {
                horaAgendamento = value;
            }
        }




        public AgendamentoView(Veiculo veiculo)
        {


            InitializeComponent();
            this.Veiculo = veiculo;
            this.BindingContext = this;
        }


        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Agendamento", string.Format(
                @"Nome: {0}
                  Forne: {1}
                   E-Mail: {2}
                    Data Agendamento: {3}
                     Hora Agendamento: {4}",Nome, Fone, Email, DataAgendamento.ToString("dd/MM/yyyy"),HoraAgendamento),
                     "OK");
        }
    }
}