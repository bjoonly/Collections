using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ////1
                ArrayList arrayList = new ArrayList();
                List<int> resInt = new List<int>();
                List<bool> resBool = new List<bool>();
                List<double> resDouble = new List<double>();
                Random random = new Random();
                double num;
                for (int i = 0; i < 20; i++)
                {
                    num = random.Next(1, 4);
                    if (num == 1)
                    {
                        arrayList.Add(random.Next(-10, 11));
                    }
                    else if (num == 2)
                    {

                        arrayList.Add(Convert.ToBoolean(random.Next(0, 2)));

                    }
                    else
                    {
                        num = random.Next(-10, 11) + random.NextDouble();
                        arrayList.Add(num);
                    }
                    Console.Write(arrayList[i] + " ");
                }
                for (int i = 0; i < arrayList.Count; i++)
                {
                    if (arrayList[i].GetType() == typeof(Boolean))
                        resBool.Add((bool)arrayList[i]);
                    else if (arrayList[i].GetType() == typeof(int))
                        resInt.Add((int)arrayList[i]);
                    else if (arrayList[i].GetType() == typeof(double))
                        resDouble.Add((double)arrayList[i]);
                }
                Console.WriteLine("\n\nList bool: ");
                foreach (var item in resBool)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine("\nList int: ");
                foreach (var item in resInt)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine("\nList double: ");
                foreach (var item in resDouble)
                {
                    Console.Write(item + " ");
                }
                Console.ReadKey();
                Console.Clear();
                
                //2
                List<string> list = new List<string>() { "Tired", "Rand", "Drama","Line"  };
                int index = 0;
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Length > list[index].Length || list[i].Length == list[index].Length && list[i].ToLower().CompareTo(list[index].ToLower()) < 1)

                        index = i;
                }
                Console.WriteLine(list[index]);
                Console.ReadKey();
                Console.Clear();
                //3

                PhoneBook<string> pb = new PhoneBook<string>();
                Console.WriteLine("Fill phone book: ");
                pb.Add("Karyna", "380974562729");
                pb.Add("Olga", "380682456769");
                pb.Add("Nastya", "380672416765");
                pb.Show();
                Console.WriteLine("\nSearch: ");
                Console.WriteLine(pb.Search(("Olga")));
                Console.WriteLine("\nEdit: ");
                pb.Edit("Nastya", "380979797777");
                pb.Show();
                Console.WriteLine("\nRemove:");
                pb.Remove("Karyna");
                pb.Show();
                Console.ReadKey();
                Console.Clear();
                //4
                CardDeck cardDeck = new CardDeck();
                Console.WriteLine("Create and fill:");
                cardDeck.Show();
                Console.WriteLine("\nShuffle:");
                cardDeck.ShuffleDeck();
                cardDeck.Show();
                Console.WriteLine();
                cardDeck.TakeCard();
                Console.WriteLine();
                for(int i = 0; i < 6; i++)
                {
                    Console.WriteLine("\n");
                    cardDeck.Deal6Cards();
                    Console.WriteLine("\n");
                    cardDeck.Show();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
        }
    }
}
