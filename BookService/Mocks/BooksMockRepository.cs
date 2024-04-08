using BookService.Models;

namespace BookService.Mocks
{
    public class BooksMockRepository
    {
        public BookModel[] Books { get; } = new BookModel[]
        {
             new BookModel()
                {
                    Id = 0,
                    Title = "T1",
                    Author = "A1",
                    Description = "D1",
                    ReleaseYear = 2020
                },
                new BookModel()
                {
                    Id = 1,
                    Title = "T2",
                    Author = "A2",
                    Description = "D2",
                    ReleaseYear = 2010
                },
                new BookModel()
                {
                    Id = 2,
                    Title = "T3",
                    Author = "A3",
                    Description = "D3",
                    ReleaseYear = 2000
                }
        };
    }
}
