# Tutorial Example of Getting Started with ASP.NET MVC

This is an example tutorial done for the purpose of understanding working with Entity Framework 6 using MVC 5. 

The code illustrates the following topics:

- Creating a data model using data annotations attributes, and fluent API for database mapping.
- Performing basic CRUD operations.
- Filtering, ordering, and grouping data.
- Working with related data.
- Implementing connection resiliency
- Using command interception
- Writing async code
- Handling concurrency.
- Implementing table-per-hierarchy inheritance.
- Performing raw SQL queries.
- Performing no-tracking queries.
- Working with proxy classes.
- Disabling automatic detection of changes.
- Disabling validation when saving changes.

The OhioUniversity folder includes the following folders and files

- App_Data folder - Holds the SQL Server Compact database file.
- Content - Holds CSS files.
- Controllers - Holds controller classes.
- DAL folder - The data access layer.  Holds the context, initializer, repository, and unit of work classes.
- Logging folder - Holds code that does logging.
- Migrations folder - Holds EF Code First migrations code, including the Seed method.
- Models folder - Holds model classes.
- Properties or MyProject folder - Project properties.
- Scripts folder - Script files.
- ViewModels folder - Holds view model classes. 
- Views folder - Holds view classes.
- Visual Studio project file (.csproj or .vbproj).
- packages.config - Specifies NuGet packages included in the project.
- Global.asax file - Includes database initializer code.
- Web.config file - Includes the connection string to the database.

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
    - For many-to-many relationships, the Entity Framework doesn't expose the join table directly, so added and removed entities to and from the appropriate navigation properties.
- Async and Stored Procedures
    - added async department controller and accompanying classes, converted db to use stored procedures for insert, update, and delete operations on an entity.
- Handling Concurrency

- Implementing Inheritance

- Advanced Entity Framework Scenarios



**Note:** 
It's a common practice to implement the repository pattern in order to create an abstraction layer between your controller and the data access layer. To keep these tutorials simple and focused on teaching how to use the Entity Framework itself, repositories are not used. 

source: https://docs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/
