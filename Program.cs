using System;

namespace anjay
{
    class programram
    {
        static void Main(string[] args)
        {
            try
            {


                Console.Write("Enter a Number ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Select operations");
                string operations = Console.ReadLine();


                Console.WriteLine("Enter a Number ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                switch (operations)
                {
                    case "+":
                        Console.WriteLine(num1 + num2);
                        break;
                    case "-":
                        Console.WriteLine(num1 - num2);
                        break;
                    case "*":
                        Console.WriteLine(num1 * num2);
                        break;
                    case "/":
                        if (num2 == 0) throw new DivideByZeroException("Tidak bisa dibagi dengan nol");
                        Console.WriteLine(num1 / num2);
                        break;
                    default:
                        Console.WriteLine("Operasi tidak dikenali");
                        return;
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Input Harus berupa angka");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            finally
            {
                Console.WriteLine("Terima kasih sudah menggunakan kalkulator");
            }
            }
    }
}
