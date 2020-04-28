using AppProCiencia.Models;
using AppProCiencia.API;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Linq;
using System.Collections.ObjectModel;

namespace AppProCiencia.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConsultaOrientadores : ContentPage
    {
        public ObservableCollection<Area> ListaAreas { get; set; }

        public ConsultaOrientadores()
        {
            InitializeComponent();
            CarregarOrientadores();
        }

        public async void CarregarOrientadores()
        {
            ListaAreas = await ApiService.ObterAreas();

            ObservableCollection<SubArea> ListaSubAreas = await ApiService.ObterSubAreas();

            ObservableCollection<Instituicao> ListaInstituicoes = await ApiService.ObterInstituicoes();

            ObservableCollection<Projeto> ListaProjetos = await ApiService.ObterProjetos();

            //var orientador = new Orientador();
            //orientador.ListaAreas = ListaAreas;

            ListViewOrientadores.ItemsSource = ListaAreas.OrderBy(a => a.Nome);
        }
    }
}