using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Quadrante do Ponto XY 
            //Verifique em que quadrante do referencial cartesiano se encontra um ponto com as corrdenas (x,y) introduzidas pelo utilizador

            Console.WriteLine("Insira a coordenada X");

            double X = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira a coordenada Y");

            double Y = Convert.ToDouble(Console.ReadLine());

            if (X > 0 && Y > 0)
                Console.WriteLine("O ponto esta no primeiro quadrante");
            else
                if (X < 0 && Y > 0)
                Console.WriteLine("O ponto esta no segundo quadrante");
                else
                    if (X < 0 && Y < 0)
                        Console.WriteLine("O ponto esta no terceiro quadrante");
                    else
                        if (X > 0 && Y < 0)
                            Console.WriteLine("O ponto esta no quarto quadrante");
            
            
            Console.ReadLine();
        }
    }
}
