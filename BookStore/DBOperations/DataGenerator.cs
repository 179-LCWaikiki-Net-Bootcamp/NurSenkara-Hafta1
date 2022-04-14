using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace BookStore.DBOperations
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BookStoreDbContext(serviceProvider.GetRequiredService<DbContextOptions<BookStoreDbContext>>()))
            {
                if (context.Books.Any())
                {
                    return;
                }

                context.Books.AddRange(
                new Book
                {
                    Title = "Me Before You",
                    GenreId = 1,//Love
                    PageCount = 500,
                    PublishedDate = new DateTime(2014, 03, 04)
                },new Book
                {
                    Title = "Harry Potter",
                    GenreId = 2,//Adventure
                    PageCount = 250,
                    PublishedDate = new DateTime(2000, 01, 05)
                },new Book
                {
                    Title = "Lord of The Rings",
                    GenreId = 2,//Adventure
                    PageCount = 1200,
                    PublishedDate = new DateTime(2003, 07, 25)
                }
                );
                context.SaveChanges();
            }
        }
    }
}
