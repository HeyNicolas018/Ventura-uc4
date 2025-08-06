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
                if (tenta > 0)
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
            2 - NÃO, EU NÃO QUERO

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
                init3();
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

               Podemos usar a localização do dispositivo 
                em caso de ser usado por crianças com 
                        controle parental. 
                    Deseja usar geolocalização?
                
                             

            #########################################

            1 - CERTO, AQUI ESTÁ  
            2 - NÃO, EU NÃO QUERO

            """);
            string escolha = Console.ReadLine();
            Console.Clear();

            if (escolha == "1")
            {
                dados++;
                init4();
            }
            if (escolha == "2")
            {
                init4();
            }
        }

        public void init4()
        {
            Console.WriteLine($"""
            #########################################
                                
             
                    Olá, Bem-Vindo ao Lyonei

                Podemos saber em qual lugar você está 
             para poder melhorar os conteúdos preferidos
                por você ou pessoas que você segue
                  podemos saber sua localização?
                
                             

            #########################################

            1 - CERTO, AQUI ESTÁ  
            2 - NÃO, EU NÃO QUERO

            """);
            string escolha = Console.ReadLine();
            Console.Clear();

            if (escolha == "1")
            {
                dados++;
                init5();
            }
            else if (escolha == "2")
            {
                init5();
            }
        }

        public void init5()
        {
            Console.WriteLine($"""
            #########################################
                                
             
                    Olá, Bem-Vindo ao Lyonei

                Nós usamos cookies de terceiros  
             para poder melhorar os conteúdos e oferecer 
                produtos de forma personalizada
                com base no seu gosto e curtida
               aceita nossa política de cookies?
                
                             

            #########################################

            1 - CERTO, AQUI ESTÁ  
            2 - NÃO, EU NÃO QUERO

            """);
            string escolha = Console.ReadLine();
            Console.Clear();

            if (escolha == "1")
            {
                dados++;
                init6();
            }
            else if (escolha == "2")
            {
                init6();
            }
        }

        public void init6()
        {
            Console.WriteLine($"""
            #########################################
                                
             
                    Olá, Bem-Vindo ao Lyonei

                Podemos usar o microfone do seu dispositivo 
             para melhor ajudar você a buscar os seus assuntos
                e seu intereses favoritos e seus ídolos
                  por você ou pessoas que você segue
                   podemos usar seu microfone?
                
                             

            #########################################

            1 - CERTO, AQUI ESTÁ  
            2 - NÃO, EU NÃO QUERO

            """);
            string escolha = Console.ReadLine();
            Console.Clear();

            if (escolha == "1")
            {
                dados++;
                init7();
            }
            else if (escolha == "2")
            {
                init7();
            }
        }

        public void init7()
        {
            Console.WriteLine($"""
            #########################################
                                
             
                    Olá, Bem-Vindo ao Lyonei

                Podemos acessar suas fotos e mídia 
               e poder criar um perfil personalizado
              e posts feitos com IA, para uma primeira
             experiência com o aplicativo e intereações
                podemos acessar suas fotos e mídia?
                
                             

            #########################################

            1 - CERTO, AQUI ESTÁ  
            2 - NÃO, EU NÃO QUERO

            """);
            string escolha = Console.ReadLine();
            Console.Clear();

            if (escolha == "1")
            {
                dados++;
                initFinal();
            }
            else if (escolha == "2")
            {
                initFinal();
            }
        }

        public void initFinal()
        {
            Console.WriteLine($"""
            #########################################
                                
             
                    TUDO CERTO, VAMOS COMEÇAR?
                
                             

            #########################################

            1 - SIM

            """);
            string escolha = Console.ReadLine();
            Console.Clear();

            if (escolha == "1")
            {
                if (dados == 10)
                {
                    Console.WriteLine($"""
                    #########################################
                                
             
                            VOCÊ DEU TODOS OS SEUS DADOS
                            
                     Você nos deu tudo. Agora, você é o produto
                
                             

                    #########################################
                    """);
                    string final = Console.ReadLine();
                    rodando = false;
                    return;
                }
                if (dados >= 5 || dados <= 5)
                {
                    Console.WriteLine($"""
                    #########################################
                                
             
                         VOCÊ DEU PARCIALMENTE OS SEUS DADOS
                            
                     Você hesitou, mas ainda assim entregou muito
                
                             

                    #########################################
                    """);
                    string final = Console.ReadLine();
                    rodando = false;
                    return;
                }
                if (dados <= 3)
                {
                    Console.WriteLine($"""
                    #########################################
                                
             
                              VOCÊ DEU POUCOS DADOS
                            
                     Você fez o que muitos não fazem: disse não
                
                             

                    #########################################
                    """);
                    string final = Console.ReadLine();
                    rodando = false;
                    return;
                }
            }
            
        }
    }
}

