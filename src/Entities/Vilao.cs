using System;
using RPG.src.Enum;
namespace RPG.src.Entities 
{
    public class Vilao:Heroi
    {
        
        public Vilao(){
        }
        public Vilao(int level,string nome,Classe classe){
            this.Level = level;
            this.Nome = nome;
            this.Classe = classe;
        }

        public override string ToString(){
            return $" - Vilao - \n - Nome: {this.Nome}\n - Level: {this.Level}\n - Classe: {this.Classe}";
        }
    }
}