using ShopList.Maui.Views;

namespace ShopList.Maui
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            //Registrar las rutas de las páginas de la aplicación

            Routing.RegisterRoute(nameof(EditItemPage), typeof(EditItemPage));
        }
    }
}
