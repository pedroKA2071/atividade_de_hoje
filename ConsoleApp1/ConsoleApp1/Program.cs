using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menu;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\r\n             ,.-:~:-.                     ,.-~·-.,__,.-::^·- .,'   ‘        ',:'/¯/`:,         _ ,.,              ,.,  ' ‘\r\n           /':::::::::'`,                 /:::::::::::::::::::::::::/'; '       /:/_/::::/';'     '/:::::/`,           /:::/';  \r\n         /;:-·~·-:;':::',              /;:·–– :;:::::_ ;: – .,/::;i'‘      /:'     '`:/::;‘   /;: :;/:::\\         /;:;/:'i‘  \r\n       ,'´          '`:;::`,           /´          ¯¯           ';::/        ;         ';:';‘  ,´     `;::';       ,´   'i:'i   \r\n      /                `;::\\        ,:                          ,:/          |         'i::i   i        \\::',      ,:    'i:';  \r\n    ,'                   '`,::;      ';_,..–-.,_     _    _,.·´‘           ';        ;'::i   ;         ';::\\ .,_';     ';:'i' \r\n   i'       ,';´'`;         '\\:::', ‘           ,·´'    '`·;'i¯                  'i        'i::i'   ';         ';::/::::';     ;':;  \r\n ,'        ;' /´:`';         ';:::'i‘           i         'i:i'       ’            ;       'i::;'    \\          \\/::::;'      i:/'° \r\n ;        ;/:;::;:';         ',:::;           ';        ';:i'     ’              ';       i:/'      '\\          '`~'´     ,'/     \r\n'i        '´        `'         'i::'/            i        i:/'                     ';     ;/ °        \\                  /       \r\n¦       '/`' *^~-·'´\\         ';'/'‚             ;      i/    °                   ';   / °           '`,             ;'         \r\n'`., .·´              `·.,_,.·´  ‚              \\   '/'                           `'´       °          `·.,    ,.·´           \r\n                                                  ¯               °              ‘                        ¯         °      \r\n");

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("1-Numeros pares em intervalo\n2-fibocci\n3-primos no intervalo");
            menu = int.Parse(Console.ReadLine());
            Console.Clear();

            if (menu == 1) 
            {
                Console.ForegroundColor = ConsoleColor.Red;

                int valor1;
                int valor2;

                Console.WriteLine(" escreva o valor 1 ");
                valor1 = int.Parse(Console.ReadLine());
        
                Console.WriteLine(" escreva o valor 2 ");
                valor2 = int.Parse(Console.ReadLine());

                for (int contagem = valor1;contagem <= valor2; contagem++) 
                {
                    if (contagem % 2 == 0)
                     {
                        Console.WriteLine("Aqui estão seu Pares" + contagem);
                    }
                
                
                }

            }
            else if (menu == 2) 
            {
                Console.ForegroundColor = ConsoleColor.Green;

                Console.Write("COLOQUE SUA POSIÇÃO FIBONACCI ");
               int numero = int.Parse(Console.ReadLine());

                if (numero <0) 
                {
                    Console.WriteLine("Coloque um numero positivo ou a partir de 1");
                }
                Console.WriteLine("\n");
                Console.WriteLine("Aqui está sua sequencia Fibonacci até a posição desejada");


                if (numero >= 0)
                    Console.WriteLine("0");
                if (numero >= 1)
                    Console.WriteLine("1");

                double a = 0, b = 1;
                
                for (double contador = 3;contador <= numero +1 ; contador++) 
                {
                    double c = a + b;
                    Console.Write(c + "\n");
                    a = b;
                    b = c;
                }

            }
            else if (menu == 3) 
            {
                Console.ForegroundColor = ConsoleColor.Yellow;

                int valor1;
                int valor2;

                Console.WriteLine(" escreva o valor 1 ");
                valor1 = int.Parse(Console.ReadLine());

                Console.WriteLine(" escreva o valor 2 ");
                valor2 = int.Parse(Console.ReadLine());

                for (int contagem = valor1; contagem <= valor2; contagem++)
                {
                    if (contagem % 2 != 0)
                    {
                        Console.WriteLine("Aqui estão seu Impars" + contagem);
                    }


                }
            }






            Console.WriteLine("Press Enter To Finish");
            Console.ReadKey();
        }
    }
}
