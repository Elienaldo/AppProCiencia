using Plugin.Connectivity;
using System.ComponentModel;
using Xamarin.Forms;
using AppProCiencia.Views;
using System.Collections.ObjectModel;
using AppProCiencia.API;
using AppProCiencia.Models;
using System;

namespace AppProCiencia
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        private ObservableCollection<MasterPageItem> _listaMenu;

        public MainPage()
        {
            InitializeComponent();

            _listaMenu = ItemMenuService.GetMenuItens();
            NavigationList.ItemsSource = _listaMenu;

            // Verifica se o dispositivo está conectado à internet
            if (!CrossConnectivity.Current.IsConnected)
            {
                DisplayAlert("Erro de conexão", "Seu dispositivo não está conectado à internet.", "Cancelar");
            }
            else
            {
                //CarregarTelaPesquisa();

                // Cria uma instaância da minha página Home
                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Home)));
            }
        }

        //async void CarregarTelaPesquisa()
        //{
        //    await Navigation.PushAsync(new ConsultaOrientadores());
        //}

        private void NavigationList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (MasterPageItem)e.SelectedItem;

            // Obtém o tipo de objeto
            Type pagina = item.TargetType;

            // Cria uma instância da pagina selecionada no menu
            Detail = new NavigationPage((Page)Activator.CreateInstance(pagina));

            // Deixa de apresentar a tela de menu "MainPage"
            IsPresented = false;
        }
    }
}
