using System;
using RPG.src.Enum;
namespace RPG.src.Entities 
{
    public class Mago:Heroi
    {
        public Mago(){
        }
        public Mago(int level,string nome,Classe classe){
            this.Level = level;
            this.Nome = nome;
            this.Classe = classe;
        }
        public override void Ataque(Heroi inimigo){
            Console.WriteLine($" - {this.Nome} lancou magia!");

            base.Ataque(inimigo);
        }
    }
}