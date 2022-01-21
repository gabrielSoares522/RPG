using System;
using RPG.src.Enum;
namespace RPG.src.Entities 
{
    public abstract class Heroi
    {
        public int Level {get;set;}
        public string Nome {get;set;}
        public Classe Classe {get;set;}
        public int Dano{get;private set;}
        public int Vida{get;private set;}

        public Heroi(){
        }
        public Heroi(int level,string nome,Classe classe){
            this.Level = level;
            this.Nome = nome;
            this.Classe = classe;
        }

        public override string ToString(){
            return $" - Heroi - \n - Nome: {this.Nome}\n - Level: {this.Level}\n - Classe: {this.Classe}";
        }

        public void Apanhar(int dano){
            if(this.Vida<= dano){
                this.Vida=0;
            } else{
                this.Vida-=dano;
            }
        }
        public virtual void Ataque(Heroi inimigo){
            int bonus = (new Random()).Next(30);
            if(this.Vida<= (this.Dano+bonus)){
                Console.WriteLine($"- {inimigo.Nome} morreu!");
            } else{
                
                Console.WriteLine($"- {inimigo.Nome} recebeu {(this.Dano+bonus).ToString()} de dano e ficou com {inimigo.Vida} de vida!");
            }            
            inimigo.Apanhar(this.Dano+bonus);

        }
    }
}
