using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;


namespace Aprendizagem.Exemplos
{
    public class Baskara
    {
        double delta;
        
        List<double> resultadoList = new List<double>();  
        

        public double CalculaDelta(double a, double b, double c)
        {
            delta = (b*b)-(4*a*c);
            return delta;
        }

        public List<double> CalculaBaskara(double delta, double a, double b)
        {
            Console.WriteLine(delta);
            if(delta<0)
            {
                throw new InvalidOperationException("Delta negativo não possui raiz no conjunto dos reais!");
            }
            else if(delta==0)
            {
                resultadoList.Add((((b)+Math.Sqrt(delta))/(2*a))*(-1));
                return resultadoList;
            }
            else
            {
                resultadoList.Add((((b)+Math.Sqrt(delta))/(2*a))*(-1));
                resultadoList.Add((((b)-Math.Sqrt(delta))/(2*a))*(-1));
                return resultadoList;
            }
        
        }
    }
}