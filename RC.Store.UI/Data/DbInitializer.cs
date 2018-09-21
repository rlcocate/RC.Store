using RC.Store.UI.Models;
using System.Collections.Generic;
using System.Data.Entity;

namespace RC.Store.UI.Data
{
    internal class DbInitializer : CreateDatabaseIfNotExists<RCStoreDataContext>
    {
        protected override void Seed(RCStoreDataContext context)
        {
            context.Produtos.AddRange(new List<Produto>()
            {
                new Produto() { Id = 1, Nome = "Picanha", Preco = 70.5M, Quantidade = 150,  Tipo = "Alimento" },
                new Produto() { Id = 2, Nome = "Pasta de dente", Preco = 6.48M, Quantidade = 250, Tipo = "Higiene" },
                new Produto() { Id = 3, Nome = "Detergente", Preco = 8.99M, Quantidade = 520, Tipo = "Limpeza" },
                new Produto() { Id = 4, Nome = "Cerveja", Preco = 12.5M, Quantidade = 85, Tipo = "Bebida" }
            });

            context.SaveChanges();
        }

    }
}