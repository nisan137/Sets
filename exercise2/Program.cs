using System;

namespace exercise2
{
    internal class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            Set set1 = new Set();
            Set set2 = new Set();
            Set set3 = new Set();

            //print the sets
            set1 = CreatNewSet();
            Console.WriteLine($"The set1 array:\n " + set1.ToString());
            set2 = CreatNewSet();
            Console.WriteLine($"The set2 array:\n {set2}");
           
            //Union set1 + set2
            set1.Union(set2);
            Console.WriteLine($"The set1 array after Union with set2:\n {set1}\n");

            //The two sets after regenration
            set1 = CreatNewSet();
            Console.WriteLine($"The set1 array after regenration:\n {set1}");
            set2 = CreatNewSet();
            Console.WriteLine($"The set2 array after regenration:\n {set2}\n");

            //Set1 after Intersection with set2
            set1.Intersect(set2);
            Console.WriteLine($"Set1 after intersection with set2, if there are similar numbers.if not, set1 will remain blank:\n {set1}\n");

            //The 2 sets after regenration
            set1 = CreatNewSet();
            Console.WriteLine($"The set1 array after regenration:\n {set1}");
            set2 = CreatNewSet();
            Console.WriteLine($"The set2 array after regenration:\n {set2}");

            //new set & cheking if set3 is Subset of set1
            set3 = CreatUserSet(3);
            Console.WriteLine($"The set3 array after regenration:\n {set3}");
            Console.WriteLine("Set3 is Subset of set1?"); ;
            Console.WriteLine(set1.Subset(set3));
            Console.WriteLine();

            //check if the input number IsMemeber in set1 or set2 
            Console.WriteLine("Please choose a number to check if he exists in set1 & set2:\n");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine($"Does the number {num} exist In set1?\n " + set1.IsMemeber(num));
            Console.WriteLine($"Does the number {num} exist In set 2?\n " + set2.IsMemeber(num));

            //Insert a new number to the array
            Console.WriteLine("Please choose a number, to add to set1 and to set2:");
            int num2 = int.Parse(Console.ReadLine());
            set1.Insert(num2);
            set2.Insert(num2);
            Console.WriteLine("Set 1 after adding the new number:\n " + set1);
            Console.WriteLine("Set 2 after adding the new number:\n " + set2);

            //Delete the choosen numbers from the sets
            Console.WriteLine("Please choose a number to delete from set1 & set2:");
            int num3 = int.Parse(Console.ReadLine());
            set1.Delete(num3);
            set2.Delete(num3);
            Console.WriteLine("Set 1 after deleting the new number:\n " + set1);
            Console.WriteLine("S2et 2 after deleting the new number:\n " + set2);

            Console.ReadLine();
        }

        static Set CreatNewSet(int length = 12) 
        {
            Set set = new Set();
            for (int i = 0; i < length; i++)
            {
                int rnd = random.Next(1000);
                if (set.IsMemeber(rnd))
                    i--;
                else
                    set.Insert(rnd);
            }
            return set;
        }

        public static Set CreatUserSet(int numOfUsersArray) 
        {
            Set set = new Set();
            Console.WriteLine($"Please enter {numOfUsersArray} numbers, press Enter between them:");
            for (int i = 0; i < numOfUsersArray; i++)
            {
                set.Insert(int.Parse(Console.ReadLine()));
            }
            return set;

        }
    }
}
