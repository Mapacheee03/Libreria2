using Libreria2.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Libreria2.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                //posible error en algun futuro
                if (!context.Books.Any())
                {
                    context.Books.AddRange(
                        new Book()
                        {
                            Titulo = "1st Book Title",
                            Descripcion = "1st Book Description",
                            IsRead = true,
                            DataRead = DateTime.Now.AddDays(-10),
                            Rate = 4,
                            Genero = "Biograpgy",
                            CoverUrl = "https...",
                            DateAdded = DateTime.Now
                        },
                        new Book()
                        {
                            Titulo = "2nd Book Title",
                            Descripcion = "2nd Book Description",
                            IsRead = true,
                            Genero = "Biograpgy",
                            CoverUrl = "https...",
                            DateAdded = DateTime.Now
                        });
                    context.SaveChanges();
                }
            }
        }
    }
}