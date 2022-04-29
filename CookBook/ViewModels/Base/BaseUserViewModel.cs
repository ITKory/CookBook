using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CookBook.Controls;
using CookBook.Services.Controls;

namespace CookBook.ViewModels.Base
{
    public partial class BaseUserViewModel : ObservableObject
    {


        [ObservableProperty]
        protected Layer _recipeLay;
        public BaseUserViewModel()
        {
            _recipeLay = new()
            {
                Content = new RecipeUser(),
                Visibility = System.Windows.Visibility.Hidden,
            };
            _recipeLay.CloseRequested += Lay_CloseRequested;
        }

        private void Lay_CloseRequested(object? sender, System.Windows.RoutedEventArgs e)
        => _recipeLay.Hide();


        [ICommand]
        protected void OnSelected(object sender) => _recipeLay.Show();
    }
}
