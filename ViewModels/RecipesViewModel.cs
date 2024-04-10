namespace _6002CEM_BohdanYermakov.ViewModels;
using _6002CEM_BohdanYermakov.Models;

public class RecipesViewModel
{
    public ObservableCollection<Recipe> Recipes { get; set; }

    public RecipesViewModel()
    {
        Recipes = new ObservableCollection<Recipe>
            {
                new Recipe
                {
                    ImageSource = "chicken_tikka_masala.png"
                },
                new Recipe
                {
                    ImageSource = "borscht.png"
                },
                new Recipe
                {
                    ImageSource = "burger.png"
                },
                new Recipe
                {
                    ImageSource = "greek_salad.png"
                },
                new Recipe
                {
                    ImageSource = "pizza.png"
                }

            };
    }
}