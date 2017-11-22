using System;

namespace lista
{
    public class HigienePessoal : Produto
    {
        public string NumeroMs{ get; set; }
        public string Marca{ get; set; }
        
        public HigienePessoal()
        {
            
        }

        public HigienePessoal(int Id, string Nome, double Preco, string NumeroMs, string Marca)
        {
            base.Id = Id;
            base.Nome = Nome;
            base.Preco = Preco;
            this.NumeroMs = NumeroMs;
            this.Marca = Marca;
        }

    }
}