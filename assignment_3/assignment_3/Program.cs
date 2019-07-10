
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var tp = new TextProcessing();
            tp.Run();
            

        }
    }
    class TextProcessing
        
    {
        Queue<string> names = new Queue<string>();
        public void Run()
        {

            // Open the names file and access the data
            using (StreamReader file = new StreamReader("U:/Users/735225/ass_3/assignment_3/assignment_3/TextFile1.txt"))
            {
                int counter = 0;
                string ln;

                while ((ln = file.ReadLine()) != null)
                {
                    names.Enqueue(ln);
                    Console.WriteLine(ln
);
                    counter++;
                }
                file.Close();
                Console.WriteLine($"File has {counter} lines.");
                PlayingWithStacks.Run(names);
            }
        }
    }
     class PlayingWithStacks
    {
        public  static void Run( Queue<string> tangerine)
        {
            Stack<string> names = new Stack<string>();

            foreach (var item in tangerine)
            {
                names.Push(tangerine.Dequeue());
            }

        }

    }
     class Workbench
    {

    }

    class Red
    {
        public  static string FavoriteFood = "carroits";
    }

    class Blue
    {
        public void SayFavoriteFood(string FavFood)
        {
            Console.WriteLine(Red.FavoriteFood);
        }
    }




}
