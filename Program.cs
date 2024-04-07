using System;

namespace RecipeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            

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

}
