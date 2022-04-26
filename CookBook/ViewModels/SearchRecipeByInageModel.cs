using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CookBook.ViewModels.Base;
using Model.Lib;
using Model.Lib.DataModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows;

namespace CookBook.ViewModels
{
    public partial class SearchRecipeByInageModel : BaseUserViewModel
    {
        Client _restClient;
        public SearchRecipeByInageModel()
        {
            Trace.TraceWarning("SRBIM");
            _restClient = new();
            _recipeList = new();
        }


        [ObservableProperty]
        string _imageUrl;


        [ObservableProperty]
        List<FullRecipeInformation> _recipeList;



        [ICommand]
        async void SearchRecipe()
        {


            _restClient.SendRequest($"https://api.spoonacular.com/food/images/classify?imageUrl={_imageUrl}");
            try
            {
                var response = await _restClient.GetResponseSingle<ImageAnalyzer>();
                _restClient.SendRequest($"https://api.spoonacular.com/recipes/complexSearch?query={response.Category}&addRecipeInformation=true&number=4");
                var recipes = await _restClient.GetResponseSingle<RandomRecipes>();
                RecipeList = new(recipes.Results);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }


        private void TestLay_CloseRequested(object? sender, System.Windows.RoutedEventArgs e)
        => _recipeLay.Hide();
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
