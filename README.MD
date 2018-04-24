# Tutorial Example of Getting Started with ASP.NET MVC

This is an example tutorial done for the purpose of understanding working with Entity Framework 6 using MVC 5. 

Each major commit will entail completion of each subunit listed below. 


Getting Started with EF 6 using MVC 5
--------------------------------------

- Creating an Entity Framework Data Model
    - created an MVC application that stores and displays data using the Entity Framework and SQL Server LocalDB.
- Implementing Basic CRUD Functionality
    - reviewed and customized the CRUD (create, read, update, delete) code that the MVC scaffolding automatically creates. 
- Sorting, Filtering, and Paging
    - implemented sorting, filtering and paging. Also, created a page that does simple grouping.
- Connection Resiliency and Command Interception
    - enabled connection resiliency and log SQL commands that Entity Framework composes and sends to the database.
- Code First Migrations and Deployment
    - enabled Code First Migrations, skipped deploy to Azure.
- Creating a More Complex Data Model
    - added more entities and relationships, customized the data model by specifying formatting, validation, and database mapping rules. 
- Reading Related Data
    - used all three ways (lazy, eager, and explicit) to load related data into navigation properties. 
- Updating Related Data

- Async and Stored Procedures

- Handling Concurrency

- Implementing Inheritance

- Advanced Entity Framework Scenarios



**Note:** 
It's a common practice to implement the repository pattern in order to create an abstraction layer between your controller and the data access layer. To keep these tutorials simple and focused on teaching how to use the Entity Framework itself, repositories are not used. 

source: https://docs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/
