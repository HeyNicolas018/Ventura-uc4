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

        private bool rodando;
        int tenta = 0;
        int dados = 0;
        public void Start()
        {
            rodando = true;
            tenta = 0;
            dados = 0;
            pre1();
        }

        public void pre1()
        {
            
            while (rodando)
            {
                Console.Clear();

                Console.WriteLine($"""
                #########################################
                                Lyonei

                            insira seu nome:
                       

                #########################################

                1 - CERTO, AQUI ESTÁ  
                2 - NÃO, EU NÃO QUERO

                """);
                string escolha = Console.ReadLine();
                Console.Clear();

                if (escolha == "1")
                {
                    dados++;
                    pre2();
                }
                
                if (escolha == "2")
                {
                    aviso1();
                }



            }
        }


        public void aviso1()
        {
            Console.WriteLine($"""
            #########################################
                            Lyonei

               precisamos do seu nome para garantir
                melhor experência de uso do Lyonei
                       

            #########################################

            1 - CERTO, AQUI ESTÁ  
            2 - NÃO, EU NÃO QUERO

            """);
            string escolha = Console.ReadLine();
            Console.Clear();

            if (escolha == "1")
            {
                dados++;
                pre2();
            }
            else if (escolha == "2")
            {
                pre2();
            }
        }

        public void aviso2()
        {
            Console.WriteLine($"""
            #########################################
                            Lyonei

               Precisamos da sua idade para garantir
               melhor experência de uso do Lyonei e
            por conta dos nossos termos de uso do Lyonei
               e das nossas políticas de privacidade 
                       

            #########################################

            1 - CERTO, AQUI ESTÁ  
            2 - NÃO, EU NÃO QUERO

            """);
            string escolha = Console.ReadLine();
            Console.Clear();

            if (escolha == "1")
            {
                dados++;
                pre2();
            }
            else if (escolha == "2")
            {
                pre3();
            }
        }

        public void aviso3()
        {
            Console.WriteLine("""
            #########################################
                                

                              Lyonei

                Precisamos do seu ano de nascimento 
              para oferecer melhor experiencia de uso
              por conta dos nossos termos de uso e das 
                  nossas políticas de privacidade 
                            

            #########################################

            1 - SIM, ACEITO
            2 - NÃO, EU NÃO QUERO

            """);
            string escolha = Console.ReadLine();
            Console.Clear();

            if (escolha == "1")
            {
                dados++;
                init();
            }
            else if (escolha == "2")
            {
                avisoCrit();
            }
        }

        public void avisoCrit()
        {
            Console.WriteLine($"""
            #########################################
                                

                                Lyonei

                Precisamos dos seus dados para podermos
             continuar com a sua entrada no Lyonei, e melhor
             garantirmos sua experiência dentro do nosso app
                
                             

            #########################################

            1 - CERTO, DAREI OS DADOS  
            2 - NÃO, EU NÃO QUERO   

            """);
            string escolha = Console.ReadLine();
            Console.Clear();

            if (escolha == "1")
            {
                pre1();
            }
            if (escolha == "2")
            {
                if (tenta > 1)
                {
                    Console.WriteLine("""
                    #########################################
                                      FIM

                        VOCE CONSEGUIU VENCER O SISTEMA, 
                        E NÃO DEU SEUS DADOS FACILMENTE.

                                    PARABÉNS
                    #########################################
                    """);
                    rodando = false;
                    return;
                }
                else
                {
                    tenta++;
                    Console.Clear();
                    pre1();
                }



            }
        }

        public void pre2()
        {
            Console.WriteLine("""
            #########################################
                                

                            Lyonei

                       Insira sua idade:
                
                            

            #########################################

            1 - CERTO, AQUI ESTÁ 
            3 - NÃO, EU NÃO QUERO

            """);
            string escolha = Console.ReadLine();
            Console.Clear();

            if (escolha == "1")
            {
                dados++;
                pre3();
            }
            if (escolha == "2")
            {
                aviso2();
            }
        }

        public void pre3()
        {
            Console.WriteLine("""
            #########################################
                                

                            Lyonei

                   Insira seu ano de nascimento: 
                            

            #########################################

            1 - SIM, ACEITO
            2 - NÃO, EU NÃO QUERO

            """);
            string escolha = Console.ReadLine();
            Console.Clear();

            if (escolha == "1")
            {
                dados++;
                init();
            }
            else if (escolha == "2")
            {
                aviso3();
            }
        }

        public void init()
        {
            Console.WriteLine($"""
            #########################################
                                
             
                    Olá, Bem-Vindo ao Lyonei

               Podemos mandar notificações de novas
               mensagens ou posts, cometários, likes
             diretamente para você só digitar seu email
                
                             

            #########################################

            1 - CERTO, AQUI ESTÁ  
            2 - NÃO, EU NÃO QUERO

            """);
            string escolha = Console.ReadLine();
            Console.Clear();

            if (escolha == "1")
            {
                dados++;
                init2();
            }
            else if (escolha == "2")
            {
                init2();
            }
        }

        public void init2()
        {
            Console.WriteLine($"""
            #########################################
                                
             
                    Olá, Bem-Vindo ao Lyonei

               Podemos vincular seus amigos de outros 
                apps, para poder conversar com eles
                  deseja vincular suas contatos?
                
                             

            #########################################

            1 - CERTO, AQUI ESTÁ  
            2 - NÃO, EU NÃO QUERO

            """);
            string escolha = Console.ReadLine();
            Console.Clear();

            if (escolha == "1")
            {
                dados++;
                init2();
            }
            else if (escolha == "2")
            {
                init3();
            }
        }

        public void init3()
        {
            Console.WriteLine($"""
            #########################################
                                
             
                    Olá, Bem-Vindo ao Lyonei

               Podemos vincular seus amigos de outros 
                apps, para poder conversar com eles.
                  Deseja vincular suas contatos?
                
                             

            #########################################

            1 - CERTO, AQUI ESTÁ  
            2 - NÃO, EU NÃO QUERO

            """);
            string escolha = Console.ReadLine();
            Console.Clear();

            if (escolha == "1")
            {
                dados++;
                init2();
            }
            else if (escolha == "2")
            {
                init3();
            }
        }
    }
}
