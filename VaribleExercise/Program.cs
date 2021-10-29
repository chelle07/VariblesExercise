using System;

namespace VaribleExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string catName = "Beth";
            int catAge = 2;
            char nickName = 'B';
            bool isFunny = true;
            double catToys = 12;
            decimal catWeight = 17.4m;
            {
                Console.WriteLine($"My cats name is {catName} and she is {catAge} " +
                    $"years old. Sometimes we call her by her nickname {nickName} and it's {isFunny} that " +
                    $"she is funny. She has {catToys} cat toys that she plays with that keeps her at her weight of {catWeight} pounds.");
            }


        }
    }
}
