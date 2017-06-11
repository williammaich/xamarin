﻿using System;
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

        public AgendamentoView (Veiculo veiculo)
		{
           

			InitializeComponent ();
            this.Veiculo = veiculo;
            this.BindingContext = this;
		}
	}
}