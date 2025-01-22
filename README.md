# LibraryManagementSystem

Library Management System
Introduction
This is a simple Library Management System built using Object-Oriented Programming (OOP) principles, SOLID design principles, and basic design patterns in C#. The system is designed to manage books and eBooks, with features like adding, removing, searching, and listing books in the library. The implementation also demonstrates the use of the Singleton and Factory design patterns.

Features
Add a new book or eBook: The system allows users to add books and eBooks to the library.
Remove a book by ISBN: Books can be removed from the library using their ISBN.
Search for books by title: Users can search for books by their title.
List all available books: The system can display all books currently available in the library.
Display download size for eBooks: For eBooks, the download size (in MB) is shown.

SOLID Principles Applied
Single Responsibility Principle (SRP):
The LibraryManager class has only one responsibility, which is to manage the library’s operations. Other functionalities like book creation and listing are handled by separate classes.
Open/Closed Principle (OCP):
The system is open for extension but closed for modification. For example, the Book class can be extended by the EBook subclass without modifying the existing Book class.
Liskov Substitution Principle (LSP):
The EBook class, as a subclass of Book, can be used interchangeably wherever a Book object is expected, ensuring correctness with both books and eBooks.
Interface Segregation Principle (ISP):
The system uses specific interfaces for operations related to books, avoiding unnecessary methods in unrelated classes.
Dependency Inversion Principle (DIP):
The system relies on abstractions (interfaces) instead of concrete implementations, ensuring flexibility and easier testing.

Design Patterns Applied
Singleton Pattern:
The LibraryManager class ensures that only one instance of the library manager exists throughout the application.
Factory Pattern:
The BookFactory class dynamically creates instances of Book or EBook based on input parameters, simplifying the creation process.

Part 1: Basic Library Management System
Created the Book class with attributes like title, author, ISBN, and availability status.
Implemented the Library class to manage a list of books with methods to add, remove, search, and list books.
Part 2: Enhancing with OOP Principles and Inheritance
Extended the Book class to create an EBook subclass with an additional attribute for file size.
Implemented the LibraryManager class to follow the Single Responsibility Principle and manage library operations.
Part 3: Applying SOLID Principles and Design Patterns
Refactored the LibraryManager class to implement the Singleton pattern.
Created a BookFactory class to implement the Factory pattern and dynamically create instances of books and eBooks.
Screenshots

![lib management system2](https://github.com/user-attachments/assets/d7de4dc9-4952-495a-bad9-227319866d94)
![lib management system1](https://github.com/user-attachments/assets/67293abe-13e5-4229-acf1-30edc422fbf7)


Conclusion
This project demonstrates how to apply Object-Oriented Programming (OOP) concepts, SOLID principles, and design patterns like Singleton and Factory to create a robust, scalable library management system in C#. The system provides a functional library management interface that can be extended with additional features in the future.

