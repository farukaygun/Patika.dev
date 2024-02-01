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
                    Surname = "Aygün",
                    Birthday = new DateTime(1997, 09, 22)
                },
                 new Author
                 {
                     Name = "Ayfer",
                     Surname = "Yýldýz",
                     Birthday = new DateTime(1969, 07, 03)
                 },
                 new Author
                 {
                     Name = "Zeynep",
                     Surname = "Kýnýk",
                     Birthday = new DateTime(1999, 10, 03)
                 }
            );
    }
}
