using System;
using RPG.src.Entities;
using RPG.src.Enum;
using System.Collections.Generic;
namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Heroi> Herois = new List<Heroi>(){
                new Guerreiro(15,"Arus",Classe.Guerreiro),
                new Arqueiro(24,"Daniel",Classe.Arqueirio),
                new Arqueiro(36,"Jennica",Classe.Mago)    
            };
            List<Vilao> viloes = new List<Vilao>(){
                new Vilao(12,"Demonio",Classe.Guerreiro),
                new Vilao(9,"Esqueleto",Classe.Arqueirio),
                new Vilao(22,"Fantasma",Classe.Mago)    
            };
            Console.Clear();
            Console.WriteLine("Bem vindo jogador");
            Console.ReadKey();
            int opc = 0;
            do{
                Console.Clear();
                Console.WriteLine("1 - Mostrar os status dos herois");
                Console.WriteLine("2 - Mostrar os status dos vilões");
                Console.WriteLine("3 - Atacar");
                Console.WriteLine("4 - Sair");
                Console.Write("Escolha uma opção: ");
                string resposta = Console.ReadLine();
                try{
                    opc = int.Parse(resposta);
                }catch (Exception ex){
                    opc=0;
                }
                Console.Clear();
                switch(opc){
                    case 1:
                        foreach(Heroi heroi in Herois){
                            Console.WriteLine(heroi.ToString()+"\n");
                        }
                        break;
                    case 2:
                        foreach(Vilao vilao in viloes){
                            Console.WriteLine(vilao.ToString()+"\n");
                        }
                        break;
                    case 3:
                        int numHeroi = -1;
                        int numVilao = -1;
                        bool continuar = true;
                        do{
                            Console.Clear();
                            for(int i=0;i<Herois.Count;i++){
                                Console.WriteLine(i.ToString()+" - "+Herois[i].Nome);
                            }
                            
                            Console.Write("Selecione o numero de um heroi: ");
                            resposta = Console.ReadLine();

                            try{
                                numHeroi = int.Parse(resposta);
                            }catch (Exception ex){
                                numHeroi=-1;
                            }

                            Console.Clear();
                            if (numHeroi < 0 || numHeroi >= Herois.Count) {
                                Console.WriteLine("Heroi invalido!");
                                Console.ReadKey();
                                continuar = false;
                            } else {
                                continuar = true;
                            }
                        }while(!continuar);
                        do{
                            Console.Clear();
                            for(int i = 0;i < viloes.Count;i++){
                                Console.WriteLine(i.ToString()+" - "+viloes[i].Nome);
                            }

                            Console.Write("Selecione o numero de um vilão: ");
                            resposta = Console.ReadLine();

                            try {
                                numVilao = int.Parse(resposta);
                            } catch (Exception ex) {
                                numVilao=-1;
                            }

                            Console.Clear();
                            if (numHeroi < 0 || numHeroi >= Herois.Count) {
                                Console.WriteLine("Vilão invalido!");
                                Console.ReadKey();
                                continuar = false;
                            } else {
                                continuar = true;
                            }
                        }while(!continuar);
                        Herois[numHeroi].Ataque(viloes[numVilao]);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Valor invalido!");
                        break;
                }
                if(opc != 4){
                    Console.ReadKey();
                } else{
                    Console.Clear();
                    break;
                }
            }while(true);

        }
    }
}
