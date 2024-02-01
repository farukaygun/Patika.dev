using System;
using WebApi.DBOperations;
using WebApi.Entities;

namespace WebApi.UnitTests.TestsSetup;

public static class Books
{
    public static void AddBooks(this BookStoreDbContext dbContext)
    {
        dbContext.Books.AddRange(
                new Book
                {
                    Title = "86 Eighty Six",
                    GenreId = 1,
                    AuthorId = 1,
                    PageCount = 200,
                    PublishDate = new DateTime(2001, 06, 12)
                },
                new Book
                {
                    Title = "Otome Game Sekai",
                    GenreId = 2,
                    AuthorId = 2,
                    PageCount = 250,
                    PublishDate = new DateTime(2010, 05, 23)
                },
                new Book
                {
                    Title = "The Irregular Magic Highschool",
                    GenreId = 2,
                    AuthorId = 3,
                    PageCount = 540,
                    PublishDate = new DateTime(2002, 12, 21)
                }
            );
    }
}
