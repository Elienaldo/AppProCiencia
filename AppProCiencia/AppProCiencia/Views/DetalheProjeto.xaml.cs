using AppProCiencia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppProCiencia.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetalheProjeto : ContentPage
    {
        public DetalheProjeto(Projeto projeto)
        {
            InitializeComponent();

            List<Projeto> ListaProjeto = new List<Projeto>();

            ListaProjeto.Add(projeto);

            DadosProjeto.ItemsSource = ListaProjeto;
        }
    }
}