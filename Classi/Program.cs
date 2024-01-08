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
                if (_nome.Length >= 2)
                {
                    _nome = "Sconosciuto";
                }
            }
        }
    }

    public class Conto : Persona
    {
        private double saldo;

        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            bool uscita = false;

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
                    case "1":
                        break;

                    case "2":
                        break;

                    case "3":
                        break;

                    case "4":
                        break;

                    case "5":
                        break;

                    case "6":
                        break;

                    case "0":
                        uscita = true;
                        break;
                }
            }
        }
    }
}
