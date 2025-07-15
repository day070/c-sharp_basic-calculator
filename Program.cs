using System;

namespace anjay
{
    class programram
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Select operations");
            string operations = Console.ReadLine();


            Console.WriteLine("Enter a Number ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (operations == "+") {
                Console.WriteLine(num1 + num2);
            }if (operations == "*"){
                Console.WriteLine(num1 * num2);                
            }if (operations == "/")
            {
                Console.WriteLine(num1 / num2);
            }
            else
            {
                Console.WriteLine("Maaf format operasi anda tidak benar");
            }
        }
    }
}