using System;

namespace BM_Calkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            

            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            int age = Int32.Parse(Console.ReadLine());

            if(age<= 20)
            {
                Console.WriteLine("You are too young to use the calculator");
            }else if (age >= 60)
            {
                Console.WriteLine("You are too old to use the calculator");
            }else 
            {
                
                double height;
                Console.WriteLine("Enter your hight: ");
                height = Double.Parse(Console.ReadLine());
                Console.WriteLine($"Your hight is {height} meter.");
                double weight;
                Console.WriteLine("Enter your weight:");
                weight = Double.Parse(Console.ReadLine());
                Console.WriteLine($"Your weight is {weight} meter.");

                double height2 = height * height;
                double BMI = weight / height2;

                if (BMI < 19)
                {
                    Console.WriteLine($"Your BIM scale is {BMI},you are underweight.");
                }else if (BMI <= 24.9)
                {
                    Console.WriteLine($"Your BIM scale is {BMI},you have an average body weight. ");
                }else if (BMI<= 29.9)
                {
                    Console.WriteLine($"Your BIM scale is {BMI}, you are overweight.");
                }else
                {
                    Console.WriteLine($"Your BIM scale is {BMI}, you are obese");
                }
            }
            

            

        }
    }
}
