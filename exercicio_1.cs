using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        class Exercicio
        {

           public int maior (int[] array_nums)
            {
               int maior = int.MaxValue*(-1);


                for (int i = 0; i < array_nums.Length; i++)
                {
                    //12 4 9 5 7
                    if (array_nums[i]>maior)
                    {
                        maior = array_nums[i];
                    }
                }
              
               
               return maior;
            }

           public static double media(int num1, int num2, int num3, int num4, int num5)
            {
                double media = 0;

                media = (num1 + num2 + num3 + num4 + num5) /5.0;

                return media;
            }

            public static string repete(int[] nums)
           {
               bool repete = false;
                // 2 2 3 4 5
               for (int i = 0; i < nums.Length; i++)
               {
                   for (int j = 0; j < nums.Length; j++)
                   {
                       if (nums[i] == nums[j] && i != j)
                       {
                           repete = true;
                           break;
                       }
                   }
                   if (repete)
                   {
                       return "tem numeros repetidos!";
                   }
               }

               return "nao tem numeros repetidos!";
           }
            
        }
        
        static void Main(string[] args)
        {
            int num1=0, num2=0, num3=0, num4=0, num5=0;
            Exercicio ex = new Exercicio();
            int[] nums= new int[5];


            Console.WriteLine("Digite o primeiro numero:");
            num1=int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero:");
            num2=int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro numero:");
            num3=int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o quarto numero:");
            num4=int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o quinto numero:");
            num5=int.Parse(Console.ReadLine());

            nums[0] = num1;
            nums[1] = num2;
            nums[2] = num3;
            nums[3] = num4;
            nums[4] = num5;

            //chamando o metodo da instancia
            Console.WriteLine("O maior valor dos numeros digitados é:" + ex.maior(nums));

            
            //chamando metodo estatico
            Console.WriteLine("A media dos numeros inseridos é: "+ Exercicio.media(num1, num2, num3, num4, num5));

            //chamando metodo estatico
            Console.WriteLine(Exercicio.repete(nums));

            Console.ReadKey();

        }
    }
}
