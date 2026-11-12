using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ShopList.Maui.Models;
using ShopList.Maui.Views;
using System.Collections.ObjectModel;

namespace ShopList.Maui.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {

        [ObservableProperty]
        private ObservableCollection<ShopListItem> _items;

        public MainViewModel()
        {
            Items = new ObservableCollection<ShopListItem>();
            LoadData();
        }
        public void LoadData()
        {
            Items.Add
                (new ShopListItem
                {
                    Nombre = "Leche",
                    Cantidad = 2,
                    Comprado = false
                }
                );

            Items.Add
                (new ShopListItem
                {
                    Nombre = "pan",
                    Cantidad = 14,
                    Comprado = true
                }
                );

            Items.Add
                (new ShopListItem
                {
                    Nombre = "Mantequilla",
                    Cantidad = 1,
                    Comprado = false
                }
                );


        }

        [RelayCommand]
        private async Task ShowNewFormAsync()
        {
            await Shell.Current.GoToAsync(nameof(EditItemPage));
        }

    }

}
