using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CookBook.ViewModels.Base;
using Model.Lib;
using Model.Lib.DataModels;
using System.Collections.Generic;
using System.Windows;

namespace CookBook.ViewModels
{

    public partial class SearchRecipeViewModel : BaseUserViewModel
    {


        Client _restClient;

        [ObservableProperty]
        List<FullRecipeInformation> _recipeList;


        [ObservableProperty]
        string _recipeName;

        public SearchRecipeViewModel()
        {
            _restClient = new();
            _recipeList = new();

        }


        [ICommand]
        async void SearchRecipe()
        {
            _restClient.SendRequest($"https://api.spoonacular.com/recipes/autocomplete?number=9&query={_recipeName}");
            var autocompleteRecipes = await _restClient.GetResponseList<QuickSearch>();

            if (autocompleteRecipes is not null && autocompleteRecipes.Count > 0)

                foreach (var search in autocompleteRecipes)
                {
                    _restClient.SendRequest($"https://api.spoonacular.com/recipes/{search.Id}/information?includeNutrition=false");
                    var recipe = await _restClient.GetResponseSingle<FullRecipeInformation>();
                    _recipeList.Add(recipe);
                }
            else
                MessageBox.Show("Nothing was found", ":(", MessageBoxButton.OK, MessageBoxImage.Warning);
            RecipeList = new(_recipeList);
        }


        private FullRecipeInformation _selItem;
        public FullRecipeInformation SelItem
        {
            get => _selItem;
            set
            {
                SetProperty(ref _selItem, value);
                _recipeLay.Recipe = _selItem;
                _recipeLay.Title = _selItem.Title;
                OnSelected(_selItem);
            }
        }


    }
}
