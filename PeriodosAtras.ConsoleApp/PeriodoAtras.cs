using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodosAtras.ConsoleApp
{
    internal class PeriodoAtras
    {

        public DateTime data;

        public TimeSpan VerificarPeriodo()
        {
            TimeSpan intervalo = DateTime.Now - this.data;
            int qtdDeDias, qtdDeSemanas, qtdDeMeses,qtdDeAnos;

            qtdDeAnos = intervalo.Days / 365;
            qtdDeMeses = qtdDeAnos / 28;
            qtdDeSemanas =  qtdDeMeses % 7;
            qtdDeDias = intervalo.Days;

            if (intervalo.Days == 1)
            {
                Console.WriteLine($"{qtdDeDias} dia atrás");


            }
            else if (intervalo.Days > 1 && intervalo.Days < 7)
            {
                Console.WriteLine($"{qtdDeDias} dias atrás");
            }
            else if (intervalo.Days >= 7 && intervalo.Days < 28)
            {
                if (intervalo.Days >= 7 && intervalo.Days < 14)
                {
                    if (intervalo.Days == 7)
                    {
                        Console.WriteLine($"{qtdDeSemanas} semana atras");
                    }
                    Console.WriteLine($"{qtdDeSemanas} semanas e {qtdDeDias} dias atras");

                }


            }
            //Mes:
            if (intervalo.Days == 28)
            {
                Console.WriteLine($"{qtdDeMeses} Mes atras");
            }
            if (intervalo.Days > 28)
            {
                
            }
            //semana:

            //dias: 

            //horas

            //minutos

            //segundos:


            return intervalo;





        }
    }
}
