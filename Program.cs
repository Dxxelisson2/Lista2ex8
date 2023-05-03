using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_2_ex_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Digite o lado A: ");
            a = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Digite o lado B: ");
            b = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Digite o lado C: ");
            c = Convert.ToInt16(Console.ReadLine());

            //dados ( a² + b² = c² ) 
            if (a*a==b*b+c*c||b*b==a*a+c*c||c*c==a*a+b*b)
            {
                Console.WriteLine("É um triângulo Retangulo!");
            }

            else
            {
                Console.WriteLine("Não é um triângulo Retangulo!");
            }

            Console.ReadKey();

        }
    }
}
