using AppProCiencia.Models;
using AppProCiencia.Views;
using System.Collections.ObjectModel;

namespace AppProCiencia.API
{
    public class ItemMenuService
    {
        public static ObservableCollection<MasterPageItem> ListaMenu { get; set; }

        public static ObservableCollection<MasterPageItem> GetMenuItens()
        {
            ListaMenu = new ObservableCollection<MasterPageItem>();

            // Criando os ítens de menu das páginas de navegação
            ListaMenu.Add(new MasterPageItem() { Title = "Home", Icon = "Home.png", TargetType = typeof(Home) });
            ListaMenu.Add(new MasterPageItem() { Title = "Projetos", Icon = "Home.png", TargetType = typeof(CadastroProjetos) });
            ListaMenu.Add(new MasterPageItem() { Title = "Orientadores", Icon = "Home.png", TargetType = typeof(ConsultaOrientadores) });
            ListaMenu.Add(new MasterPageItem() { Title = "Sobre", Icon = "Home.png", TargetType = typeof(Sobre) });

            return ListaMenu;
        }
    }
}
