using System;

namespace RecipeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Recipe recipe = new Recipe();   //init Recipe class

            // Prompt user to enter recipe details
            Console.WriteLine("Enter the details for the recipe:");
            Console.Write("Number of ingredients: ");
            int numIngredients = int.Parse(Console.ReadLine()); //Read & Write Data as per program instructions for end User

            for (int i = 0; i < numIngredients; i++)                        //Loop created to store muti data of ingredients to be used to capture in Array
            {
                Console.WriteLine($"Enter details for ingredient {i + 1}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Quantity: ");
                double quantity = double.Parse(Console.ReadLine());
                Console.Write("Unit of Measurement: ");
                string unit = Console.ReadLine();

                recipe.AddIngredient(name, quantity, unit);
            }

            Console.Write("Number of steps: ");                             //Loop created to store muti data of number if steps to be used to capture in Array
            int numSteps = int.Parse(Console.ReadLine());

            for (int i = 0; i < numSteps; i++)
            {
                Console.WriteLine($"Enter step {i + 1}:");
                string step = Console.ReadLine();
            }

            // Display the full recipe
            Console.WriteLine("\nFull Recipe:");                           //Display full recipe (Ingredients + Steps)                                     

        }

    }


    class Recipe                                        //Class Recipe to Store and Call data of the user data
    {
        private string[] ingredients;
        private string[] steps;

        public Recipe()
        {
            ingredients = new string[0];                //Ingredients Array Created to store Ingredients
            steps = new string[0];              //Number of Steps Array Created to store Ingredients
        }

        public void AddIngredient(string name, double quantity, string unit)                //Method created to store ingredients to Array Ingredients
        {
            Array.Resize(ref ingredients, ingredients.Length + 1);
            ingredients[ingredients.Length - 1] = $"{quantity} {unit} of {name}";
        }

        public void AddStep(string step)                //Method created to store steps to Array steps
        {
            Array.Resize(ref steps, steps.Length + 1);
            steps[steps.Length - 1] = step;
        }

        public void DisplayRecipe()                 //Method to display recipe
        {
            Console.WriteLine("Ingredients:");
            foreach (var ingredient in ingredients)
            {
                Console.WriteLine(ingredient);          //Print each Ingredient
            }

            Console.WriteLine("\nSteps:");
            for (int i = 0; i < steps.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {steps[i]}"); //Print each step
            }
        }


    }
}
