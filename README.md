# BookStore Project - CRUD Operations and Unit Testing

## Overview

This project will guide you through implementing CRUD (Create, Read, Update, Delete) operations for the BookStore repository. You will also learn how to write unit tests for these operations using xUnit and Moq.

## Definitions

### Dependency Injection
Dependency Injection (DI) is a design pattern used to implement IoC (**Inversion of Control**). It allows the creation of dependent objects outside of a class and provides those objects to a class in different ways. The main aim of DI is to decouple the instantiation of objects from the class that uses them.
- Understanding Dependency Injection [Medium Article](https://medium.com/@avinash.dhumal/understanding-dependency-injection-a-practical-guide-with-c-examples-aee44eacee32)

### Interfaces
An interface defines a contract that classes can implement. It contains method signatures without implementations. Classes that implement the interface **must** provide concrete implementations for all its methods. Interfaces help in achieving **abstraction** and are used extensively in dependency injection and mocking.

### Repository Pattern
The Repository Pattern is a design pattern that mediates data from and to the domain and data access layers. Repositories provide a way to manage and access data while separating the business logic from the data access code. This promotes a clean architecture and makes the code easier to maintain and test.
- Understanding the Repository Pattern [Medium Article](https://medium.com/@chandrashekharsingh25/understanding-the-repository-pattern-in-c-net-with-examples-51f02c4074ba)

## Instructions

### Project Setup

1. **Clone the Repository:**
   - Clone the repository from [GitHub](https://github.com/your-repo/BookStore) to your local machine.

### Implementing CRUD Operations

2. **Create the CRUD Methods:**
   - Navigate to the `BookStore` project.
   - Implement the following CRUD functions in the existing `BookService` and `BookRepository` classes.

#### BookRepository - CRUD Methods

- **GetAllBooks Method:**
  - Implement a method to retrieve all books

- **GetBookById Method:**
  - Implement a method to retrieve a book by its ID
    
- **AddBook Method:**
  - Implement a method to add a new book

- **UpdateBook Method:**
  - Implement a method to update an existing book

- **DeleteBook Method:**
  - Implement a method to delete a book by its ID

#### BookService - CRUD Methods

- **GetAllBooks Method:**
  - Implement a method to retrieve all books using the injected repository

- **GetBookById Method:**
  - Implement a method to retrieve a book by its ID using the injected repository
    
- **AddBook Method:**
  - Implement a method to add a new book using the injected repository

- **UpdateBook Method:**
  - Implement a method to update an existing book using the injected repository

- **DeleteBook Method:**
  - Implement a method to delete a book by its ID using the injected repository

**Make sure you create the methods in the corresponding interfaces for the BookService and BookRepository first before implementing them in the actual classes**

### Writing Unit Tests

3. **Create Unit Tests for CRUD Operations:**
   - Navigate to the `BookStore.Tests` project.
   - Create unit tests for each CRUD operation in the `BookRepository` class.

### Running Unit Tests
- In Visual Studio, right-click on the test file and select "Run Tests"
- To run just one test in your test file, right-click on the test method itself and select "Run Tests"

4. **Stretch Goals (During & After NSS)**
   - Add a Minimal API project to your solution that injects the IBookService as a dependency to use it
   - Add Entity Framework Core to your project to do all these actions to your database (outside of unit testing)
   - Add Front-End to your application
