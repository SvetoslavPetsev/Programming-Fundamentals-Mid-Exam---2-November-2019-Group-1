using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Wizard_Poker
{
    class Program
    {
        static void Main()
        {
            List<string> arsenalCards = Console.ReadLine().Split(":").ToList();
            List<string> fightDeck = new List<string>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Ready")
                {
                    break;
                }

                List<string> command = input.Split(" ").ToList();
                if (command[0] == "Add")
                {
                    string cardName = command[1];
                    if (arsenalCards.Contains(cardName))
                    {
                        fightDeck.Add(cardName);
                    }
                    else
                    {
                        Console.WriteLine("Card not found.");
                    }
                }
                else if (command[0] == "Insert")
                {
                    string cardName = command[1];
                    int index = int.Parse(command[2]);

                    if (arsenalCards.Contains(cardName) && index >= 0 && index <= fightDeck.Count - 1)
                    {
                        fightDeck.Insert(index, cardName);
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                }
                else if (command[0] == "Remove")
                {
                    string cardName = command[1];
                    if (fightDeck.Contains(cardName))
                    {
                        fightDeck.Remove(cardName);
                    }
                    else
                    {
                        Console.WriteLine("Card not found.");
                    }
                }
                else if (command[0] == "Swap")
                {
                    string cardName1 = command[1];
                    string cardName2 = command[2];
                    int indexCard1 = 0;
                    int indexCard2 = 0;
                    for (int i = 0; i < fightDeck.Count; i++)
                    {
                        string currCard = fightDeck[i];
                        if (currCard == cardName1)
                        {
                            indexCard1 = i;
                        }
                        else if (currCard == cardName2)
                        {
                            indexCard2 = i;
                        }
                    }
                    fightDeck.Insert(indexCard1, cardName2);
                    fightDeck.RemoveAt(indexCard2 + 1);
                    fightDeck.Insert(indexCard2, cardName1);
                    fightDeck.RemoveAt(indexCard1 + 1);
                }
                else if (command[0] == "Shuffle" && command[1] == "deck")
                {
                    fightDeck.Reverse();
                }
            }
            Console.WriteLine(string.Join(" ", fightDeck));
        }
    }
}
