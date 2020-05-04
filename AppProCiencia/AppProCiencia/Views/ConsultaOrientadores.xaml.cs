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
        public ObservableCollection<Projeto> ListaProjetos { get; set; }

        public ConsultaOrientadores()
        {
            InitializeComponent();
            CarregarOrientadores();
        }

        public async void CarregarOrientadores()
        {
            //ObservableCollection<Area> ListaAreas = await ApiService.ObterAreas();

            //ObservableCollection<SubArea> ListaSubAreas = await ApiService.ObterSubAreas();

            //ObservableCollection<Instituicao> ListaInstituicoes = await ApiService.ObterInstituicoes();

            ListaProjetos = await ApiService.ObterProjetos();
            ListViewOrientadores.ItemsSource = ListaProjetos.OrderBy(a => a.Autor);
        }

        private void ListViewOrientadores_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var projetoSelecionado = (Projeto)e.SelectedItem;

            Navigation.PushAsync(new DetalheProjeto(projetoSelecionado));
        }
    }
}