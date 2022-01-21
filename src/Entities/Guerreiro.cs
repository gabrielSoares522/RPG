using System;
using RPG.src.Enum;
namespace RPG.src.Entities 
{
    public class Guerreiro:Heroi
    {
        public Guerreiro(){
        }
        public Guerreiro(int level,string nome,Classe classe){
            this.Level = level;
            this.Nome = nome;
            this.Classe = classe;
        }
        public override void Ataque(Heroi inimigo){
            Console.WriteLine($" - {this.Nome} atacou com sua espada!");

            base.Ataque(inimigo);
        }
    }
}