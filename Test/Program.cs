using Model.Lib;
using Model.Lib.DataModels;

Console.WriteLine("Start test");
Console.WriteLine("------------------");
Console.WriteLine();


Client restClient = new();
Console.WriteLine("Поиск по запросу");
Console.WriteLine("------------------");
Console.WriteLine();
/*
restClient.SendRequest("https://api.spoonacular.com/recipes/autocomplete?number=10&query=chick");
List<QuickSearch> searchableValue = restClient.GetResponseList<QuickSearch>();*/

/*foreach (var search in searchableValue)
{
    restClient.SendRequest($"https://api.spoonacular.com/recipes/{search.Id}/information?includeNutrition=false");
    FullRecipeInformation recipeInformation = restClient.GetResponseSingle<FullRecipeInformation>();

    restClient.SendRequest($"https://api.spoonacular.com/recipes/{search.Id}/similar?number=4");
    List<SimilarRecipes> similarRecipes = restClient.GetResponseList<SimilarRecipes>();

    Console.WriteLine($"Title:{recipeInformation.Title}\nId:{recipeInformation.Id}\nSim:");
    Console.WriteLine(similarRecipes.Count);
    Console.WriteLine();
}
*/
Console.WriteLine("поиск по категории ");
Console.WriteLine("------------------");
Console.WriteLine();

restClient.SendRequest("https://api.spoonacular.com/recipes/random?number=2&tags=vegetarian");
RandomRecipes VeganRec = restClient.GetResponseSingle<RandomRecipes>();
foreach (var veg in VeganRec.Recipes)
    Console.WriteLine($"id:{veg.Title}\nname");


restClient.SendRequest("https://api.spoonacular.com/recipes/random?number=2&tags=dessert");
RandomRecipes SweetRec = restClient.GetResponseSingle<RandomRecipes>();
foreach (var sweet in SweetRec.Recipes)
    Console.WriteLine($"id:{sweet.Title}\nname");


//https://api.spoonacular.com/recipes/autocomplete?query=chick/information?includeNutrition=false&apiKey=70fd301d6a5d4114a0b84b27a0854b18

//https://api.spoonacular.com/recipes/autocomplete?query=chick&information&includeNutrition=false&apiKey=70fd301d6a5d4114a0b84b27a0854b18