using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;

namespace TaskManager
{
    internal class Program
    {
        static void printList(List<string> list)
        {
            Console.WriteLine("\n");
            Console.WriteLine("task list:");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(i + 1 + "-" + list[i]);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome");
            string option = "";

            List<string> list = new List<string>();
            Console.WriteLine("please type start to begin.");
            while (true)
            {
                option = Console.ReadLine();
                Console.WriteLine("\n");
                if (option.ToLower() == "start" || option.ToLower() == "continue")
                {
                    Console.WriteLine("Enter 1 to Add a Task.");
                    Console.WriteLine("Enter 2 to View The Task List.");
                    Console.WriteLine("Enter 3 to Remove a Task.");
                    Console.WriteLine("Enter 4 to Edit a Task.");
                    Console.WriteLine("\n\n");
                    Console.WriteLine("Please Enter a Number.");
                    option = Console.ReadLine();
                }
                if (option == "1")
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Please Enter The Task.");
                    string newtask = Console.ReadLine();
                    list.Add(newtask);
                }
                else if (option == "2")
                {
                    printList(list);
                }
                else if (option == "3")
                {
                    printList(list);
                    Console.WriteLine("\n");
                    Console.WriteLine("Please Enter The Task You Want to Remove.");
                    int tasknumber = Convert.ToInt32(Console.ReadLine()) - 1;
                    list.RemoveAt(tasknumber);

                }
                else if (option == "4")
                {
                    printList(list);
                    Console.WriteLine("\n");
                    Console.WriteLine("Please Enter The Task You Want to Edit.");
                    int tasknmber = Convert.ToInt32(Console.ReadLine()) - 1;
                    Console.WriteLine("Please Enter The New Task");
                    string newtask = Console.ReadLine();
                    list[tasknmber] = newtask;
                }
                else if (option.ToLower() == "exit")
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Exiting the program");
                    break;
                }
                else
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Command Invalid!\n Please Try Again");
                }
                Console.WriteLine("\n");
                Console.WriteLine("Please type 'continue' to access the command center or 'exit' to leave the program.");
            }
            Console.WriteLine("Have a Nice Day");
        }
    }
}
