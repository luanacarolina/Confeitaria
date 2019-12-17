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

                if(context.Usuarios!=null && context.Usuarios.Any())
                return;

                if(context.Ingredientes!=null && context.Ingredientes.Any())
                return;

                var usuarios = DummyData.GetUsuarios().ToArray();
                context.Usuarios.AddRange(usuarios);

                var ingredientes = DummyData.GetIngredientes().ToArray();
                context.Ingredientes.AddRange(ingredientes);
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

        public static List<Ingrediente> ingredientes = new List<Ingrediente>(){

            new Ingrediente {Nome = "Farinha",Quantidade = 2,Validade = DateTime}
        };
        return ingredientes;
    }
}