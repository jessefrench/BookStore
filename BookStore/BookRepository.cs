using System.Collections.Generic;

namespace BookStore
{
    // This is the BookRepository class
    // The BookRepository class is responsible for getting the book data from the data store
    // In this case, the data store is an in-memory dictionary
    // The data store could be a database, a web service, or any other source of data
    public class BookRepository : IBookRepository
    {
        private readonly Dictionary<int, Book> books = new()
        {
            { 1, new Book { Id = 1, Title = "1999", Author = "George Orwell" } },
            { 2, new Book { Id = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee" } },
            { 3, new Book { Id = 3, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald" } },
            { 4, new Book { Id = 4, Title = "Lord of the Flies", Author = "William Golding" } },
            { 5, new Book { Id = 5, Title = "Pride and Prejudice", Author = "Jane Austen" } }
        };

        public Book GetBookById(int id)
        {
            books.TryGetValue(id, out var book);
            return book;
        }
    }
}
