using System;
using System.Collections.Generic;

namespace lista
{
    class Program
    {
        static void Main(string[] args)
        {
            /*List<Usuarios> user = new List<Usuarios>();
            Usuarios lucas = new Usuarios(){Id=35,Login="Lucas",Senha="12345"};
            Usuarios tuanny = new Usuarios(){Id=10,Login="Tuanny",Senha="12"};
            user.Add(lucas);
            user.Add(tuanny);
            foreach(var us in user) {
                System.Console.WriteLine("id: {0}",us.Id);
                System.Console.WriteLine("Login: {0}", us.Login);
                System.Console.WriteLine("Senha: {0}", us.Senha);
            }*/

            List<Produto> sacola = new List<Produto>();
            Bebidas cerveja = new Bebidas(10, "Skol", 5.99, 10.50, "Pilsen");
            HigienePessoal sabonete = new HigienePessoal(10, "Dove", 7.99, "123", "Unilever");
            sacola.Add(sabonete);
            sacola.Add(cerveja);


            /*foreach (var item in sacola)
            {
                string classe = item.GetType().ToString();
                switch (classe)
                {
                    case "lista.HigienePessoal":
                        HigienePessoal higiene = (HigienePessoal)item;
                        System.Console.WriteLine("Higiene Pessoal: \n {0} \n {1} \n {2} \n {3} \n {4}", higiene.Id, higiene.Nome, higiene.Preco, higiene.NumeroMs, higiene.Marca);
                        System.Console.WriteLine();
                        break;
                    case "lista.Bebidas":
                        Bebidas bebidas = (Bebidas)item;
                        System.Console.WriteLine("bebidas: \n {0} \n {1} \n {2} \n {3} \n {4}", bebidas.Id, bebidas.Nome, bebidas.Preco, bebidas.TeorAlcoolico, bebidas.Sabor);
                        System.Console.WriteLine();
                        break;
                }
            }*/


        }
    }
}
