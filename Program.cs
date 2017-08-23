using System;

namespace Lista21082017ex06
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            decimal fahrenheit, celsius;

            Console.WriteLine("Digite a temperatuda em Fahrenheit: ");
            fahrenheit = Convert.ToDecimal(Console.ReadLine());
            celsius = ((fahrenheit - 32) * 5) / 9;
            Console.WriteLine("A temperatura em celsius é {0:###,##0.00}", celsius);
        }
    }
}
