namespace lista
{
    public class Bebidas : Produto
    {
        
        public double TeorAlcoolico{ get; set; }
        public string Sabor{ get; set; }

        public Bebidas()
        {
            
        }

        public Bebidas(int Id, string Nome, double Preco, double TeorAlcoolico, string Sabor)
        {
            base.Id = Id;
            base.Nome = Nome;
            base.Preco = Preco;
            this.TeorAlcoolico = TeorAlcoolico;
            this.Sabor = Sabor;
        }
    }
}