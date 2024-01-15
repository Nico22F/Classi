using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi
{
    public class Persona
    {
        private string _nome;

        public string Nome 
        { 
            get { return _nome; }
            set 
            { 
                _nome = value;
                if (_nome.Length <= 2)
                {
                    _nome = "Sconosciuto";
                }
            }
        }

    }

    public class Conto : Persona
    {
        private double saldo;
        private bool chiuso = false;

        // apriconto

        public void Apriconto()
        {
            chiuso = false;
            Console.Clear();
            Console.WriteLine("Inserisci il cognome del proprietario");
            Nome = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Inserisci il saldo");
            saldo = Convert.ToDouble(Console.ReadLine());
        }
        // chiudere un conto

        public void ChiudiConto()
        {
            if (chiuso == true) // conto chiuso
            {
                Console.Clear();
                Console.WriteLine("Il conto è già stato chiuso");
                Console.ReadLine();
            }
            else // conto non chiuso
            {
                Console.Clear();
                saldo = 0;
                chiuso = true;
                Console.WriteLine("Conto chiuso correttamente!");
                Console.ReadLine();
            }
        }

        // depositare sul conto

        public void Deposita()
        {
            if (chiuso == true) // conto chiuso
            {
                Console.Clear();
                Console.WriteLine("Conto chiuso. Impossibile proseguire");
                Console.ReadLine();
            }
            else // conto non chiuso
            {
                Console.Clear();
                Console.WriteLine("Inserisci il saldo da depositare");
                double saldo_da_depositare = 0;
                if (!double.TryParse(Console.ReadLine(), out saldo_da_depositare))
                {
                    // input errato
                    Console.Clear();
                    Console.WriteLine("Input Errato");
                }
                else // input corretto
                {
                    Console.Clear();
                    saldo += saldo_da_depositare;
                    Console.WriteLine("Saldo depositato correttamente");
                    Console.ReadLine();
                }
            }
        }

        // vedere saldo del conto

        public void VisualizzaSaldo()
        {
           if(chiuso == true) // conto chiuso
           {
                Console.Clear();
                Console.WriteLine($"Conto chiuso. Impossibile Proseguire");
                Console.ReadLine();
           }
           else // conto aperto
           {
                Console.Clear();
                Console.WriteLine($"Il saldo del sig.{Nome} è di {saldo} euro");
                Console.ReadLine();
           }
        }

        // prelevare saldo dal conto

        public void Prelevare()
        {
           if(chiuso == true) // conto chiuso
           {
                Console.Clear();
                Console.WriteLine($"Conto chiuso. Impossibile Proseguire");
                Console.ReadLine();
            }
           else // conto aperto
           {
                Console.Clear();
                Console.WriteLine("Inserisci il saldo da prelevare dal conto");
                double saldo_da_prelevare;
                if (!double.TryParse(Console.ReadLine(), out saldo_da_prelevare))
                {
                    // input errato
                    Console.Clear();
                    Console.WriteLine("Input Errato");
                }
                else // input corretto
                {
                    if (saldo_da_prelevare > saldo)
                    {
                        // input errato
                        Console.Clear();
                        Console.WriteLine("L'importo da prelevare è maggiore rispetto al saldo da lei in possesso");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.Clear();
                        saldo -= saldo_da_prelevare;
                        Console.WriteLine("Importo prelevato correttamente!");
                        Console.ReadLine();
                    }
                }
           }
        }

        // stato del conto

        public void StatoConto()
        {
            Console.Clear();

            string stato = "";

            // controllo stato conto

            if (chiuso == true) // conto chiuso
            {
                stato = "CHIUSO";
            }
            else
            {
                stato = "APERTO";
            }

            Console.WriteLine($"STATO DEL CONTO: {stato}");
            Console.WriteLine($"PROPRIETARIO: {Nome}");
            Console.WriteLine($"SALDO: {saldo}");
            Console.ReadLine();
        }

    }

    // classe Banca

    class Banca
    {
        private Conto[] array = new Conto[100];

        public Banca() 
        { 
            for ( int i = 0; i < array.Length; i++ ) 
            {
                array[i] = new Conto();
            }
        }

        public void ApriConto(string a)
        {
            array[0].Apriconto();
            array[0].Nome = a;
        }

        // fricerca dicotomica del nome

        public bool RicercaDicotomica(string nome, ref int posizione)
        {
            int sinistra = 0;
            int destra = 100;

            while (sinistra <= destra)
            {
                int medio = sinistra + (destra - sinistra) / 2;

                // Controlla se l'elemento è presente al centro dell'array
                if (array[medio].Nome == nome)
                {
                    posizione = medio;
                    return quantita = true;
                }

                // Se l'elemento è maggiore, ignora la metà sinistra
                if (string.Compare(p[medio].nome, nome, StringComparison.Ordinal) == -1) // se è -1 allora la prima stringa è più piccolo della seconda
                {
                    sinistra = medio + 1;
                }
                else // Se l'elemento è minore, ignora la metà destra
                {
                    destra = medio - 1;
                }
            }


            return quantita = false;
        }


    }

    internal class Program
    {
        static void Main(string[] args)
        {
            bool uscita = false;
            while(uscita == false)
            {
                Console.Clear();
                Console.WriteLine("Benvenuto nell'Intesa San Fabbro");
                Console.WriteLine("Vuole lavorare su un singolo conto (1) o su più conti? (2) ");


                switch (Console.ReadLine())
                {
                    case "1": // singolo conto

                        Conto conto = new Conto();
                        bool uscita2 = false;

                        while (uscita2 == false)
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
                                case "1":
                                    conto.Apriconto();
                                    break;

                                case "2":
                                    conto.ChiudiConto();
                                    break;

                                case "3":
                                    conto.Deposita();
                                    break;

                                case "4":
                                    conto.Prelevare();
                                    break;

                                case "5":
                                    conto.VisualizzaSaldo();
                                    break;

                                case "6":
                                    conto.StatoConto();
                                    break;

                                case "0":
                                    uscita2 = true;
                                    break;
                            }
                        }

                        break;
                    case "2": // più conti
                        
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Input Errato. Reinserire l'input");
                        Console.ReadLine();
                        break;
                }

            }
        }
    }
}
