using System;

namespace RecipeApp // Change to New Repo as per Instructions of Lecturer After submitting 
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
                recipe.AddStep(step);
            }

            // Display the full recipe
            Console.WriteLine("\nFull Recipe:");                           //Display full recipe (Ingredients + Steps)                                     
            recipe.DisplayRecipe();


            // Scaling the recipe
            Console.WriteLine("\nDo you want to scale the recipe? Enter factor (0.5, 2, or 3), or type 'reset' to reset quantities, or 'clear' to enter a new recipe:");
            string scaleInput = Console.ReadLine();                              //Case statement used to scale recipe based on user requirements with 3 options, else error thrown


            switch (scaleInput)
            {
                case "0.5":
                    recipe.ScaleRecipe(0.5);
                    break;
                case "2":
                    recipe.ScaleRecipe(2);
                    break;
                case "3":
                    recipe.ScaleRecipe(3);
                    break;
                case "reset":
                    recipe.ResetQuantities();
                    break;
                case "clear":
                    recipe.ClearRecipe();
                    Main(args);                                                  // Restart the application for a new recipe
                    return;
                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }

            Console.ReadLine();
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

        public void ScaleRecipe(double factor)          //Method to scale recipe 
        {
            for (int i = 0; i < ingredients.Length; i++)            //Loop through ingredients
            {
                string[] parts = ingredients[i].Split(' ');
                double quantity = double.Parse(parts[0]);
                quantity *= factor;
                ingredients[i] = $"{quantity} {parts[1]} of {string.Join(" ", parts, 3, parts.Length - 3)}";
            }
            Console.WriteLine($"\nRecipe scaled by factor {factor}.");
            DisplayRecipe();                                                    //Display Scaled Recipe
        }

        public void ResetQuantities()   //Method to reset qty of recipe
        {
            Console.WriteLine("\nQuantities reset to original values.");
            DisplayRecipe();
        }

        public void ClearRecipe() //Method to clear recipe
        {
            ingredients = new string[0];
            steps = new string[0];
            Console.WriteLine("\nRecipe cleared.");
        }




    }
}




   
