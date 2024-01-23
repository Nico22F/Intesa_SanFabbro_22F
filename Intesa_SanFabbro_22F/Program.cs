using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intesa_SanFabbro_22F
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // variabili e classi

            bool uscita = false;
            Banca banca = new Banca();
           
            // ciclo while

            while (uscita == false)
            {
                
                Console.Clear();
                Console.WriteLine("1) Apri il conto");
                Console.WriteLine("2) Azzera il conto");
                Console.WriteLine("3) Deposita sul conto");
                Console.WriteLine("4) Preleva dal conto");
                Console.WriteLine("5) Vedi saldo sul conto");
                Console.WriteLine("6) Visualizza info conto");
                Console.WriteLine("0) Esci");

                switch (Console.ReadLine())
                {
                    case "1": // aprire conto

                        Console.Clear();
                        Console.WriteLine("Inserisci il nome utente");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Inserisci i soldi da depositare");
                        double saldo = Convert.ToDouble(Console.ReadLine());
                        banca.apriconto(nome, saldo);

                    break;

                    case "2": // azzerare il conto
                        Console.Clear();
                        Console.WriteLine("Inserisci il nome utente");
                        banca.azzeraconto(Console.ReadLine());
                        break;

                    case "3": // depositare sul conto

                        Console.Clear();
                        Console.WriteLine("Inserisci il nome utente");
                        nome = Console.ReadLine();
                        Console.WriteLine("Inserisci i soldi da depositare");
                        saldo = Convert.ToDouble(Console.ReadLine());
                        banca.Deposita(nome, saldo);

                        break;

                    case "4": // prelevare dal conto

                        Console.Clear();
                        Console.WriteLine("Inserisci il nome utente");
                        nome = Console.ReadLine();
                        Console.WriteLine("Inserisci i soldi da prelevare");
                        saldo = Convert.ToDouble(Console.ReadLine());
                        banca.Preleva(nome, saldo);

                        break;

                    case "5": // vedere saldo sul conto

                        Console.Clear();
                        Console.WriteLine("Inserisci il nome utente");
                        banca.VisualizzaSaldo(Console.ReadLine());

                        break;

                    case "6": // visualizza info sul conto

                        Console.Clear();
                        Console.WriteLine("Inserisci il nome utente");
                        banca.VisualizzaInfo(Console.ReadLine());

                        break;

                    default: // uscire dal programma
                        uscita = true;
                    break;
                }
            }
        }
    }
}
