using System;

namespace DIO.Animes
{
    public class Anime : EntidadeBase{
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descrição { get; set; }
        private int Ano { get; set; }
        private bool Excluido {get; set;}

        public Anime(int id, Genero genero, string titulo, string descriçao, int ano){
           this.Id = id;
           this.Genero = genero;
           this.Titulo = titulo;
           this.Descrição = descriçao;
           this.Ano = ano;
           this.Excluido = false;
        }

        public override string ToString() {
            string retorno = "";
            retorno += "Genero: "+this.Genero+Environment.NewLine;
            retorno += "Titulo: "+this.Titulo+Environment.NewLine;
            retorno += "Descrição: "+this.Descrição+Environment.NewLine;
            retorno += "Ano: "+this.Ano+Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
            return retorno;
        }
    
        public string RetornaTitulo(){
            return this.Titulo;
        }

        public int RetornaId(){
            return this.Id;
        }

        public bool retornaExcluido(){
            return this.Excluido;
        }

        public void Excluir() {
            this.Excluido = true;
        }
    }   
}