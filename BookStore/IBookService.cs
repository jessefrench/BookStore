namespace BookStore
{
    // This is the interface for the BookService class
    // An interface is a contract that defines the methods that a class must implement
    // In this case, the IBookService interface defines a single method, GetBookById
    // In a repository pattern, the service class is dependent on the repository interface
    // The service methods call the repository methods to get the data
    public interface IBookService
    {
        Book GetBookById(int id);
    }
}
