using WebApi.DBOperations;
using WebApi.Entities;

namespace WebApi.UnitTests.TestsSetup;

public static class Authors
{
    public static void AddAuthors(this BookStoreDbContext context)
    {
        context.Authors.AddRange(
                new Author
                {
                    Name = "Faruk",
                    Surname = "Ayg�n",
                    Birthday = new DateTime(1997, 09, 22)
                },
                 new Author
                 {
                     Name = "Ayfer",
                     Surname = "Y�ld�z",
                     Birthday = new DateTime(1969, 07, 03)
                 },
                 new Author
                 {
                     Name = "Zeynep",
                     Surname = "K�n�k",
                     Birthday = new DateTime(1999, 10, 03)
                 }
            );
    }
}
