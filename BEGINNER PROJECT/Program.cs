using System;                  // Import basic system functions (like Console)
using System.Collections.Generic; // Import List<T> so we can store TODOs

class Program                   // Define the Program class (entry point of app)
{
    static void Main()          // Main method: program starts here
    {
        List<string> todos = new List<string>(); // Create a list to store TODOs
        Console.WriteLine("Hello!");             // Print greeting

        while (true)            // Infinite loop until user chooses Exit
        {
            // Show menu options
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("[S]ee all TODOs");
            Console.WriteLine("[A]dd a TODO");
            Console.WriteLine("[R]emove a TODO");
            Console.WriteLine("[E]xit");

            string choice = Console.ReadLine()?.ToLower(); // Read user input, make lowercase

            if (choice == "s")   // If user chose "See all TODOs"
            {
                if (todos.Count == 0) // If list is empty
                {
                    Console.WriteLine("No TODOs have been added yet.");
                }
                else
                {
                    // Print each TODO with its index (starting from 1)
                    for (int i = 0; i < todos.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {todos[i]}");
                    }
                }
            }
            else if (choice == "a") // If user chose "Add a TODO"
            {
                Console.WriteLine("Enter the TODO description:");
                string description = Console.ReadLine(); // Read description

                if (string.IsNullOrWhiteSpace(description)) // Check if empty
                {
                    Console.WriteLine("The description cannot be empty.");
                }
                else if (todos.Contains(description)) // Check if duplicate
                {
                    Console.WriteLine("The description must be special.");
                }
                else
                {
                    todos.Add(description); // Add to list
                    Console.WriteLine($"TODO successfully added: {description}");
                }
            }
            else if (choice == "r") // If user chose "Remove a TODO"
            {
                if (todos.Count == 0) // If no TODOs exist
                {
                    Console.WriteLine("No TODOs have been added yet.");
                }
                else
                {
                    Console.WriteLine("Select the index of the TODO you want to remove:");
                    // Print list with indexes
                    for (int i = 0; i < todos.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {todos[i]}");
                    }

                    string input = Console.ReadLine(); // Read index
                    if (int.TryParse(input, out int index) && index >= 1 && index <= todos.Count)
                    {
                        string removed = todos[index - 1]; // Get description
                        todos.RemoveAt(index - 1);         // Remove from list
                        Console.WriteLine($"TODO removed: {removed}");
                    }
                    else
                    {
                        Console.WriteLine("The given index is not valid.");
                    }
                }
            }
            else if (choice == "e") // If user chose "Exit"
            {
                break; // Exit the loop = program ends
            }
            else
            {
                Console.WriteLine("Incorrect input"); // Handle invalid choice
            }
        }
    }
}
