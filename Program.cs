using System;
using System.Collections.Generic;
using Aprendizagem.Exemplos;

namespace Aprendizagem
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Baskara();
            double delta;
            
            Console.WriteLine("Resolvendo Baskara!!!");
            Console.WriteLine("Digite A, B, C");
            Double a = Convert.ToDouble(Console.ReadLine());
            Double b = Convert.ToDouble(Console.ReadLine());
            Double c = Convert.ToDouble(Console.ReadLine());
            delta = s.CalculaDelta(a, b, c);
            List<double> resultadoList = new List<double>();
            resultadoList = s.CalculaBaskara(delta, a, b);
            Console.WriteLine("Raizes:");
            resultadoList.ForEach(Console.WriteLine);
            




            







        }
    }
}
