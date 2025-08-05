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

        public static List<(string p, string r1, string r2, string r3)> questoes = new List<(string, string, string, string)>
        {
            ("Lyonei", "insira seu nome:", "idade:", "sua profissão:"),
            ("Lyonei", "insira seu nome:", "idade:", "sua profissão:"),
            ("Lyonei", "insira seu nome:", "idade:", "sua profissão:"),
            ("Lyonei", "insira seu nome:", "idade:", "sua profissão:"),
            ("Lyonei", "insira seu nome:", "idade:", "sua profissão:"),
            ("Lyonei", "insira seu nome:", "idade:", "sua profissão:"),
            ("Lyonei", "insira seu nome:", "idade:", "sua profissão:"),
        };

    /*
        static string nome = Console.ReadLine();
        static int idade = int.Parse(Console.ReadLine());
        static string profissao = Console.ReadLine();
    */
        //layout do programa
        public void Layout()
        {
            Console.Clear();
            int index = 0;
            var q = questoes[index];

            Console.WriteLine($"""
            #########################################
                            {q.p}

                            {q.r1}
                            {q.r2}
                            {q.r3}

            #########################################
            """);

        }
 
    }
}
