using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intesa_SanFabbro_22F
{
    internal class Banca
    {
        List<Conto> lista = new List<Conto>();


        // ricerca

       public int Ricerca(string nome)
       {
            int pos = -1;

            for (int i = 0; i < lista.Count; i++) 
            {
                if (lista[i].Nome == nome)
                {
                    pos = i;
                    break;
                }
                if (lista[i].Nome == null)
                {
                    pos = i;
                    break;
                }
            }

            return pos;
       }

        // aprire il conto
       public void apriconto(string nome, double saldo)
       {
            lista.Add(new Conto());
            lista[Ricerca(nome)].Nome = nome;
            lista[Ricerca(nome)].Saldo = saldo;
            lista[Ricerca(nome)].Chiuso = false;
            Console.Clear();
            Console.WriteLine($"Conto aperto correttamente");
            Console.ReadLine();
        }

       // azzerare il conto
        public void azzeraconto(string nome)
        {
            Console.Clear();
            lista.RemoveAt(Ricerca(nome));
            Console.WriteLine($"Conto chiuso correttamente");
            Console.ReadLine();
        }

        public void Deposita (string nome, double deposito) 
        {
            
            if (lista[Ricerca(nome)].Chiuso == false)
            {
                lista[Ricerca(nome)].Saldo += deposito;
                Console.Clear();
                Console.WriteLine("Deposito avvenuto con successo");
                Console.WriteLine($"Il signor {lista[Ricerca(nome)].Nome} possiede {lista[Ricerca(nome)].Saldo} euro");
                Console.ReadLine();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Conto chiuso. Impossibile Proseguire");
                Console.ReadLine();
            }
        }

        public void Preleva (string nome, double preleva)
        {
            if (lista[Ricerca(nome)].Chiuso == false)
            {
                if (lista[Ricerca(nome)].Saldo < preleva) // non ci sono soldi
                {
                    Console.Clear();
                    Console.WriteLine("Non ci sono abbastanza soldi nel conto da prelevare. Riprovare con un importo minore");
                    Console.ReadLine();
                }
                else // no problem
                {
                    lista[Ricerca(nome)].Saldo -= preleva;
                    Console.Clear();
                    Console.WriteLine($"Importo prelevato con successo!\nSaldo residuo: {lista[Ricerca(nome)].Saldo} euro");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Conto chiuso. Impossibile Proseguire");
                Console.ReadLine();
            }
            
        }

        public void VisualizzaSaldo(string nome)
        {
            if (lista[Ricerca(nome)].Chiuso == false)
            {
                Console.Clear();
                Console.WriteLine($"Il signor {lista[Ricerca(nome)].Nome} possiede {lista[Ricerca(nome)].Saldo} euro");
                Console.ReadLine();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Conto chiuso. Impossibile Proseguire");
                Console.ReadLine();
            }
        }

        public void VisualizzaInfo(string nome)
        {
            Console.Clear();
            string stato = "";

            if(lista[Ricerca(nome)].Chiuso== true)
            {
                stato = "CHIUSO";
            }
            else
            {
                stato = "APERTO";
            }

            Console.WriteLine($"Proprietario: {lista[Ricerca(nome)].Nome}\nSaldo:{lista[Ricerca(nome)].Saldo} euro\nStato: {stato}");
            Console.ReadLine();
        }
    }

    
}
