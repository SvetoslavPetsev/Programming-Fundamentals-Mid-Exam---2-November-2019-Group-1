using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Weaponsmith
{
    class Program
    {
        static void PrintEven(List<string> name)
        {
            for (int i = 0; i < name.Count; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(name[i] + " ");
                }
            }
            Console.WriteLine();
        }
        static void PrintOdd(List<string> name)
        {
            for (int i = 0; i < name.Count; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(name[i] + " ");
                }
            }
            Console.WriteLine();
        }
        static void Main()
        {
            List<string> mixedName = Console.ReadLine().Split("|").ToList();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Done")
                {
                    break;
                }

                List<string> inputInfo = input.Split().ToList();
                if (inputInfo[0] == "Move")
                {
                    string direction = inputInfo[1];
                    int index = int.Parse(inputInfo[2]);

                    if (index >= 0 && index < mixedName.Count)
                    {
                        if (direction == "Left" && index > 0)
                        {
                            string temp = mixedName[index - 1];
                            mixedName[index - 1] = mixedName[index];
                            mixedName[index] = temp;
                        }
                        else if (direction == "Right" && index < mixedName.Count - 1)
                        {
                            string temp = mixedName[index + 1];
                            mixedName[index + 1] = mixedName[index];
                            mixedName[index] = temp;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                if (inputInfo[0] == "Check")
                {
                    string evenOrOdd = inputInfo[1];
                    if (evenOrOdd == "Even")
                    {
                        PrintEven(mixedName);
                    }
                    else
                    {
                        PrintOdd(mixedName);
                    }
                }
            }
            Console.WriteLine($"You crafted {string.Join("", mixedName)}!");
        }
    }
}
