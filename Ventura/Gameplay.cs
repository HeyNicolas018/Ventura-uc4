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
        public string idade;
        public string ano;

        public static List<(string r1, string r2, string r3)> questoes = new List<(string, string, string)>
        {
            ("insira seu nome:", "", ""),
            ("1 - CERTO, AQUI ESTÁ", "NEM QUERO, SÓ VAI LOGO", "NÃO, EU NÃO QUERO"),
            ("1 - SIM ACEITO", "2 - NÃO SEI, TANTO FAZ", "3 - NÃO, EU NÃO QUERO"),
            ("insira seu nome:", "idade:", "sua profissão:"),
            ("insira seu nome:", "idade:", "sua profissão:"),
            ("insira seu nome:", "idade:", "sua profissão:"),
            ("insira seu nome:", "idade:", "sua profissão:")
        };

        List<string> resposta = new List<string>();

        //layout do programa
        public void LayoutInicial()
        {
            Console.Clear();
            
            for (int i = 0; i < questoes.Count; i++)
            {
                var q = questoes[i];
                Console.WriteLine($"""
                #########################################
                                Lyonei

                                {q.r1}
                            

                #########################################
                """);
                nome = Console.ReadLine();
                Console.Clear();
                resposta.Add(nome);
                
                Console.WriteLine($"""
                #########################################
                                

                              Olá {nome}

                        Precisamos da sua idade
                para oferecer melhor experiencia de uso do Lyonei
                
                            

                #########################################
                """);
                idade = Console.ReadLine();
                Console.Clear();
                resposta.Add(idade);
                
                Console.WriteLine($"""
                #########################################
                                

                              Olá {nome}

                    Precisamos coletar seu ano de nascimento
                por conta dos nossos termos de uso do Lyonei
                
                               {q.r1}
                               {q.r2}
                               {q.r3}

                #########################################
                """);
                ano = Console.ReadLine();
                resposta.Add(ano);
                Console.Clear();
            }
        }
 
    }
}
