using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[0];
            int i = 0;
            while(true) 
            {
                Console.Write("Please enter a name:");
                string nameInput = Console.ReadLine();
                Array.Resize(ref names, names.Length + 1);
                names[i] = nameInput;
                Console.WriteLine(nameInput + " has been stored to the array.");
                i++;
                Console.Write("Do you want to add another name?");
                string choiseInput = Console.ReadLine();

                if (choiseInput == "Y" || choiseInput == "y")
                {
                    continue;
                }
                else if (choiseInput == "N" || choiseInput == "n")
                {
                    foreach (var name in names)
                    {
                        Console.WriteLine(name);
                    }
                    break;
                }
                else 
                {
                    while (true) 
                    {
                        Console.Write("Invalid input, please enter Y or N !!!");
                        string validationInput = Console.ReadLine();
                        if (validationInput == "Y" || validationInput == "y")
                        {
                            break;
                        }
                        else if (validationInput == "N" || validationInput == "n")
                        {
                            foreach (var name in names)
                            {
                                Console.WriteLine(name);
                            }
                            return;
                        }
                        else 
                        {
                            continue;
                        }
                    }
                }
            }


        }
    }
}
