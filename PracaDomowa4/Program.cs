using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracaDomowa4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                Console.WriteLine("Wpisz liczbe: ");
                FizzBuzz fizzBuzz = new FizzBuzz();
                fizzBuzz.FizzBuzzMethod();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }

        }

    }
}
