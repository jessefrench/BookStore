namespace BookStore
{

    // This is the BookService class
    // The BookService class is responsible for getting the book data from the repository
    // The BookService class is dependent on the IBookRepository interface
    // The BookService class implements the IBookService interface
    // We are using dependency injection to inject the IBookRepository interface into the BookService class
    // Dependency injection is a design pattern that allows us to inject the dependencies of a class from the outside
    // This makes the class more modular and easier to test
    // We do not inject the BookRepository class directly into the BookService class because we want to be able to mock the repository in our unit tests
    // We also do not want the BookService class to be dependent on the BookRepository class
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public Book GetBookById(int id)
        {
            return _bookRepository.GetBookById(id);
        }
    }
}
