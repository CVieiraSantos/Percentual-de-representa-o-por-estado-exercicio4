using System;
using System.Globalization;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            

            var sp = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            var rj = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            var mg = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);            
            var es = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            var outros = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            

            var total = Total(sp,rj,mg,es,outros);

            var estsp =((sp/Total(sp,rj,mg,es,outros)*100));
            var estrj = ((rj/Total(sp,rj,mg,es,outros)*100));
            var estmg = ((mg/Total(sp,rj,mg,es,outros)*100));
            var estes = ((es/Total(sp,rj,mg,es,outros)*100));
            var esoutros = ((outros/Total(sp,rj,mg,es,outros)*100));

            Console.WriteLine
            ("O percentual de representação que estado de SP teve dentro do valor total mensal da distribuidora foi de: " + estsp.ToString("F14", CultureInfo.InvariantCulture));
            Console.WriteLine();

             Console.WriteLine
            ("O percentual de representação que estado de SP teve dentro do valor total mensal da distribuidora foi de: " + estrj.ToString("F14", CultureInfo.InvariantCulture));
            Console.WriteLine();

             Console.WriteLine
            ("O percentual de representação que estado de SP teve dentro do valor total mensal da distribuidora foi de: " + estmg.ToString("F14", CultureInfo.InvariantCulture));
            Console.WriteLine();

             Console.WriteLine
            ("O percentual de representação que estado de SP teve dentro do valor total mensal da distribuidora foi de: " + estes.ToString("F14", CultureInfo.InvariantCulture));
            Console.WriteLine();

             Console.WriteLine
            ("O percentual de representação que estado de SP teve dentro do valor total mensal da distribuidora foi de: " + esoutros.ToString("F14", CultureInfo.InvariantCulture));
            Console.WriteLine();
            
        }           

        public static double Total(double sp, double rj, double mg, double es, double outros)
        {            
            var total =  (sp + rj + mg + es + outros);
            return total;                       
        }      

       
    }
}
