# **MyPortfolio**

**MyPortfolio** is a web application built using **ASP.NET Core MVC** that allows users to manage their portfolio projects. It provides functionality for adding, editing, and deleting projects. The application follows **clean architecture principles** using the **Repository Pattern** and **Unit of Work** to ensure scalability, maintainability, and separation of concerns.

## **Features**

- **Project Management**: Users can easily add new projects to their portfolio, edit details of existing projects, or remove projects.
- **CRUD Operations**: Full **Create**, **Read**, **Update**, and **Delete** functionality for portfolio projects.
- **Repository & Unit of Work Patterns**: The application uses these design patterns for better data management, code organization, and scalability.
- **User Authentication**: Allows users to log in and manage their portfolio through a secure authentication system.
- **Responsive UI**: Built with modern web technologies, the user interface is designed to be intuitive and user-friendly.

## **Technologies Used**

- **ASP.NET Core MVC**: Used for building the web application with the Model-View-Controller pattern.
- **Entity Framework Core**: ORM for data access and interaction with the SQL Server database.
- **SQL Server**: Database management system to store project data.
- **HTML, CSS, JavaScript**: Frontend technologies to create an interactive user interface.
- **Bootstrap**: Used for responsive and mobile-first design.

## **Project Structure**

The project follows the **MVC (Model-View-Controller)** architecture with the following components:

- **Models**: Represent the data structure and interact with the database (e.g., `Project`, `User` models).
- **Views**: Handle the display of information to the user (e.g., project listing, details, and forms).
- **Controllers**: Manage the application's logic and coordinate between models and views.
- **Repositories**: The **Repository Pattern** is used for data access, providing a clean interface to interact with the database.
