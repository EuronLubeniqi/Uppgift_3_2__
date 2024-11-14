using System;

namespace Uppgift_3_2__
{
    class Program
    {

        static void Main(string[] args) 
            {
                Console.WriteLine("har du gått ut gymnasiet? (j/n):");
                string gymnasiesvar = Console.ReadLine();

                Console.WriteLine("Hur gammal är du");
                int ålder=int.Parse(Console.ReadLine());

                if (gymnasiesvar == "j" && ålder < 22)
                {
                    Console.WriteLine("Vi vill gärna anställa dig");

                }
                else
                {
                    Console.WriteLine("tyvärr vi letar efter en annan personl ");
                }
               
             
            }
    }
}