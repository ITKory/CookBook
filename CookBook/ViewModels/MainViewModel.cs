using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CookBook.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        SearchRecipeViewModel recipeView;

        [ObservableProperty]
        HomeViewModel homeView;

        [ObservableProperty]
        SearchRecipeByInageModel recipeByInageView;

        [ObservableProperty]
        object currentView;

        public MainViewModel()
        {

            recipeView = new();
            homeView = new();
            recipeByInageView = new();
            currentView = homeView;

        }

        [ICommand]
        public void ChangeView(object sender) => CurrentView = sender;



    }
}
