using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventura
{
    public class Gameplay
    {
        private static Gameplay instancia;

        private Gameplay() { }

        public static Gameplay Instance => instancia ??= new Gameplay();

        public string nome;

        public static List<(string p, string r1, string r2, string r3)> questoes = new List<(string, string, string, string)>
        {
            ("Lyonei", "insira seu nome:", "", ""),
            ("Lyonei", " \nprecisamos coletar seus dados\npara oferecer melhor experiencia de uso do Lyonei\n", "", ""),
            ("precisamos coletar seus dados\npara oferecer melhor experiencia de uso do Lyonei\n", "1 - SIM ACEITO", "2 - NÃO SEI, TANTO FAZ", "3 - NÃO, EU NÃO QUERO"),
            ("Lyonei", "insira seu nome:", "idade:", "sua profissão:"),
            ("Lyonei", "insira seu nome:", "idade:", "sua profissão:"),
            ("Lyonei", "insira seu nome:", "idade:", "sua profissão:"),
            ("Lyonei", "insira seu nome:", "idade:", "sua profissão:"),
        };

        //layout do programa
        public void LayoutInicial()
        {
            Console.Clear();
            int index = 0;
            var q = questoes[index];

           Console.WriteLine($"""
            #########################################
                            {q.p}

                            {q.r1}
                            

            #########################################
            """);
            nome = Console.ReadLine();

            Console.WriteLine($"""
            #########################################
                            {q.p}

                          Olá {nome}
                           {q.r2}
                            

            #########################################
            """);
        }
 
    }
}
