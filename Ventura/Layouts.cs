using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ventura
{
    public class Layouts
    {
        private static Layouts instancia;

        private Layouts() { }

        public static Layouts Instance => instancia ??= new Layouts();


        public string escolha = Console.ReadLine();
        public void LayoutInicial()
        {
            Console.Clear();

            Console.WriteLine($"""
            #########################################
                            Lyonei

                        insira seu nome:
                       

            #########################################

            1 - CERTO, AQUI ESTÁ  
            2 - NEM QUERO, SÓ VAI LOGO
            3 - NÃO, EU NÃO QUERO

            """);
            string nome = Console.ReadLine();
            Console.Clear();

            Console.WriteLine($"""
            #########################################
                                

                            Olá {nome}

                       Precisamos da sua idade
            para oferecer melhor experiencia de uso do Lyonei
                
                            

            #########################################

            1 - SIM ACEITO
            2 - NÃO SEI, TANTO FAZ
            3 - NÃO, EU NÃO QUERO

            """);
            escolha = Console.ReadLine();
            Console.Clear();

            Console.WriteLine($"""
            #########################################
                                

                            Olá {nome}

                Precisamos do seu ano de nascimento
            por conta dos nossos termos de uso do Lyonei
                e das nossas políticas de privacidade 
                
                             

            #########################################

            1 - CERTO, AQUI ESTÁ  
            2 - NEM QUERO, SÓ VAI LOGO
            3 - NÃO, EU NÃO QUERO

            """);
            escolha = Console.ReadLine();
            Console.Clear();

        }
    }
}
