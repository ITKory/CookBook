using CommunityToolkit.Mvvm.ComponentModel;
using CookBook.ViewModels.Base;
using Model.Lib;
using Model.Lib.DataModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CookBook.ViewModels
{

    public partial class HomeViewModel : BaseUserViewModel
    {

        Client _restClient;

        [ObservableProperty]
        List<FullRecipeInformation> _lunchRecipeList;

        [ObservableProperty]
        List<FullRecipeInformation> _veganRecipeList;

        [ObservableProperty]
        List<FullRecipeInformation> _dessertRecipeList;
        public HomeViewModel()
        {
            _veganRecipeList = new();
            _dessertRecipeList = new();
            _lunchRecipeList = new();
            _selItem = new();
            _restClient = new();
            FillLists();

        }

        private async void FillLists()
        {
            VeganRecipeList = await FillList("vegetarian");
            DessertRecipeList = await FillList("dessert");
            LunchRecipeList = await FillList("lunch");
        }
        private async Task<List<FullRecipeInformation>> FillList(string tag)
        {
            _restClient.SendRequest($"https://api.spoonacular.com/recipes/random?number=3&tags={tag}");
            var recipes = await _restClient.GetResponseSingle<RandomRecipes>();
            return recipes.Recipes;
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
