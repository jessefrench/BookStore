namespace BookStore
{
    // This is the interface for the BookService class
    // An interface is a contract that defines the methods that a class must implement
    // In this case, the IBookService interface defines a single method, GetBookById
    // In a repository pattern, the service class is dependent on the repository interface
    // The service methods call the repository methods to get the data
    public interface IBookService
    {
        // Create a method to get all books
        // The method should return a list of Book objects

        Book GetBookById(int id);

        // Create a method to add a book
        // The method should take a Book object as a parameter and return the ID of the newly added book

        // Create a method to update a book
        // The method should take a Book object as a parameter and return a boolean value indicating whether the update was successful

        // Create a method to delete a book
        // The method should take an ID as a parameter and return a boolean value indicating whether the delete was successful
    }
}
