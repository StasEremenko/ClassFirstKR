using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFirstKR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input please something like this: Kharkiv=1431000,350;Kiev=2804000,839( maybe more cities)");
            string inpt = Console.ReadLine();
            
            string[] parts = inpt.Split(';');
            foreach (var i in parts)
            {
                Console.WriteLine(i);                
            }
            Console.ReadKey();


            List<string> town = new List<string>();
            for (int i = 0; i < parts.Length; i++)
            {
                string[] partsOfParts = parts[i].Split('=');
                town.Add(partsOfParts[0]);
            }
            string longestName = town.OrderByDescending(n => n.Length).First();
            Console.WriteLine("The longest city is: " + longestName);
            


            List<int> populated = new List<int>();
            List<int> area = new List<int>();
            for (int i = 0; i < parts.Length; i++)
            {
                string[] partsOfparts1 = parts[i].Split('=',',');
                populated.Add(int.Parse(partsOfparts1[1]));
                area.Add(int.Parse(partsOfparts1[2]));

                float density = float.Parse(partsOfparts1[1]) / float.Parse(partsOfparts1[2]);
                Console.WriteLine("Densyti of {0} is {1}",partsOfparts1[0],density);
            }
            int mostPeople = populated.Max();
            Console.WriteLine("The most populated city is: " + mostPeople);            
            Console.ReadKey();
        }
    }
}
