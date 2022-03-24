using System;

namespace PeriodosAtras.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            PeriodoAtras periodo1 = new PeriodoAtras();

            periodo1.data =Convert.ToDateTime("23/03/2022");
            periodo1.VerificarPeriodo();

            periodo1.data = Convert.ToDateTime("22/03/2022");
            periodo1.VerificarPeriodo();

            periodo1.data = Convert.ToDateTime("17/03/2022");
            periodo1.VerificarPeriodo();

            periodo1.data = Convert.ToDateTime("17/01/2022");
            periodo1.VerificarPeriodo();

            periodo1.data = Convert.ToDateTime("21/01/2022");
            periodo1.VerificarPeriodo();

            periodo1.data = Convert.ToDateTime("24/03/2011");
            periodo1.VerificarPeriodo();

            Console.ReadLine();

        }
    }
}
