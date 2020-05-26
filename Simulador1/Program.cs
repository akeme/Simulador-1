using System;
using System.Timers;


namespace Simulador1
{
    class Program
    {
        int IdSim, Leitura;
        bool StatusSim;
        public static void Main()
        {
            int opcao, valorLeitura;
            bool Status;

            Console.WriteLine("\nPress the Enter key to exit the application...\n");
            Console.WriteLine("\nTestando...\n");
            Console.WriteLine("digite 1 ou 2");

            
            opcao = Convert.ToInt32(Console.ReadLine());
            Status = Simulador.OpcaoConv(opcao);
            

            //opcao = 1;


            // Status = opcao != 1;

            //Status = true;
            valorLeitura = Simulador.Leitura(Status);
            DateTime date = Simulador.StatusSet(Status);

            Console.WriteLine("o valor da leitura é {0}", valorLeitura);
            Console.WriteLine("o valor inicial é {0}", date);


            /*
            Console.WriteLine("\nPress the Enter key to exit the application...\n");
            Console.WriteLine("The application started at {0:HH:mm:ss.fff}", DateTime.Now);
            Console.ReadLine();
            aTimer.Stop();
            aTimer.Dispose();

            Console.WriteLine("Terminating the application...");
    */
        }

       

    }

 
}


