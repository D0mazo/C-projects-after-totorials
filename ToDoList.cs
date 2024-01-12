using System;
using System.Collections.Generic;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the To Do List program");
            List<string> taskList = new List<string>();
            string option = "";

            while (option != "e")
            {
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("Enter 1 to add a new task to the list");
                Console.WriteLine("Enter 2 to remove a task from the list");
                Console.WriteLine("Enter 3 to view the list");
                Console.WriteLine("Enter e to exit the program");

                option = Console.ReadLine();

                if (option == "1")
                {
                    Console.WriteLine("Please enter a task");
                    string task = Console.ReadLine();
                    taskList.Add(task);
                    Console.WriteLine("Task added");
                }
                else if (option == "2")
                {
                    for (int i = 0; i < taskList.Count; i++)
                    {
                        Console.WriteLine(i + ": " + taskList[i]);
                    }

                    Console.WriteLine("Please enter the number of the task to remove");
                    int taskNumber;
                    if (int.TryParse(Console.ReadLine(), out taskNumber) && taskNumber >= 0 && taskNumber < taskList.Count)
                    {
                        taskList.RemoveAt(taskNumber);
                    }
                    else
                    {
                        Console.WriteLine("Invalid task number");
                    }
                }
                else if (option == "3")
                {
                    Console.WriteLine("Current list");

                    for (int i = 0; i < taskList.Count; i++)
                    {
                        Console.WriteLine(taskList[i]);
                    }
                }
                else if (option == "e")
                {
                    Console.WriteLine("Exiting Program");
                }
                else
                {
                    Console.WriteLine("Invalid option");
                }
            }

            Console.WriteLine("Thanks for using the program");
        }
    }
}
