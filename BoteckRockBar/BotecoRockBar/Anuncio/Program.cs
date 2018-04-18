using System;

namespace Anuncio
{
    class Program
    {
        static Banda banda = new Banda();
        static void Main(string[] args)
        {
            Console.WriteLine("Diga o nome da banda:");
            banda.Nome = Console.ReadLine();

            Console.WriteLine("Digite 'Adicionar' para adicionar um músico.");
            Console.WriteLine("Digite 'Anunciar' para anunciar a banda.");
            Console.WriteLine("Digite 'Sair' para sair da aplicação.");

            while (true)
            {
                Console.WriteLine("Adicionar, Anunciar ou Sair?");
                string[] argumentos = Console.ReadLine().Split(' ');

                string acao = argumentos[0].ToLower();

                if (acao == "sair")
                    break;

                if (acao == "adicionar")
                {
                    AdicionarMusico(argumentos);
                    continue;
                }

            }
        }
        static void AdicionarMusico(string[] args)
        {
              string nomeMenbro = "";
              string funcao = "";
              int caseSwitch = args.Length;

            
            switch (caseSwitch)
                    {
                   // Adicionar 1 parametro#     
                case 1:
                    banda.AdicionarMusico();
                        break;
                    //Adicionar 3 parametros    
                case 3:
                    if(args[1] == "-m"){
                        nomeMenbro = args[2];
                        banda.AdicionarMusico(nomeMenbro);
                    }
                    else if (args[1] == "-i")
                        Console.WriteLine("Favor informar primeiro o nome -M");
                    break;
                    // Adicionar 5 parametros#
                case 5:
                    if(args[1] == "-m"){
                        nomeMenbro = args[2];
                        funcao = args [4];
                        }
                    else if(args[1] == "-i"){
                        funcao = args[2];
                        nomeMenbro = args[4];}
                            banda.AdicionarMusico(nomeMenbro,funcao);
                            break;
        }
    }
 }
}