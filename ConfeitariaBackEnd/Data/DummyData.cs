using System;
using System.Collections.Generic;
using System.Linq;
using ConfeitariaBackEnd.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace ConfeitariaBackEnd.Data
{
    public class DummyData
    {
        public static void Initialize(IApplicationBuilder app)
        {
            using (var serviceApp = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceApp.ServiceProvider.GetService<ConfeitariaContext>();
                context.Database.EnsureCreated();
                var usuarios = DummyData.GetUsuarios().ToArray();
                if(context.Usuarios!=null && !context.Usuarios.Any())
                 context.Usuarios.AddRange(usuarios);

                var ingredientes = DummyData.GetIngredientes().ToArray();
                 if(context.Ingredientes!=null && !context.Ingredientes.Any())
                context.Ingredientes.AddRange(ingredientes);

                //  var produtos = DummyData.GetProdutos().ToArray();    
                // if(context.Produtos!=null &&! context.Produtos.Any())
                //  context.Produtos.AddRange(produtos);

                 context.SaveChanges();
            }
        }

        public static List<Usuario> GetUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>() {
                new Usuario {Nome  = "Luana", Username = "Luana", Password= "123", Email= "Luana@MaisLindaDesseMundo.com", Role="Confeiteira", DataInclusao = DateTime.Now},
                new Usuario {Nome  = "Guto", Username = "Guto", Password= "123", Email= "Guto@MaisLindoDesseMundo.com", Role="Vendas", DataInclusao = DateTime.Now}
            };

            return usuarios;
        }

        public static List<Ingrediente> GetIngredientes()
        {
            List<Ingrediente> ingredientes = new List<Ingrediente>(){
            new Ingrediente {Nome = "Farinha",Quantidade = 2,Validade = DateTime.Now.AddMonths(3),DataInclusao = DateTime.Now}


            };
            return ingredientes;
        }

        // public static List<Produto> GetProdutos()
        // {
        //     List<Produto> produtos = new List<Produto>(){

        //         new Produto {Nome ="Bolo",Descricao ="Bolo de fubá",preco =15.00,Validade = DateTime.Now.AddDays(3)}
        //     };
        //     return produtos;
        
        // }
        
    }
}