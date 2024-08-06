namespace BookStore
{
    // This is the interface for the BookRepository class
    // An interface is a contract that defines the methods that a class must implement
    // In this case, the IBookRepository interface defines a single method, GetBookById
    // Interfaces are good for testing because they allow us to create mock objects that simulate the behavior of real objects
    // Mock objects are used in unit testing to isolate the code under test
    public interface IBookRepository
    {
        Book GetBookById(int id);
    }
}
