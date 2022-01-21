using System;
using RPG.src.Enum;
namespace RPG.src.Entities 
{
    public class Arqueiro:Heroi
    {
        public Arqueiro(){
        }
        public Arqueiro(int level,string nome,Classe classe){
            this.Level = level;
            this.Nome = nome;
            this.Classe = classe;
        }
        public override void Ataque(Heroi inimigo){
            Console.WriteLine($" - {this.Nome} disparou uma flecha!");

            base.Ataque(inimigo);
        }
    }
}