# MyPortfolio

MyPortfolio is an MVC-based web application that allows users to manage their portfolio projects. The application implements the **Repository Pattern** and **Unit of Work** to manage data access and transactions. It supports **CRUD operations** for adding, editing, and deleting portfolio projects.

## Features

- **Add Project**: Users can add a new project to their portfolio.
- **Edit Project**: Users can update existing project details.
- **Delete Project**: Users can remove projects from their portfolio.
- **View Projects**: View a list of all the projects in the portfolio.

## Architecture

This application follows the **MVC (Model-View-Controller)** design pattern:
- **Model**: Represents the data structure (projects) and interacts with the database.
- **View**: Displays the user interface and allows users to interact with the application.
- **Controller**: Handles user requests, processes data via the model, and returns the result to the view.

The project uses:
- **Repository Pattern**: A way to access data from the database, abstracting the data layer and providing a collection-like interface.
- **Unit of Work**: Manages transactions, ensuring all database operations within a transaction are committed or rolled back together.

## Technologies Used

- **ASP.NET Core MVC**
- **Entity Framework Core**
- **SQL Server**
- **C#**
- **HTML, CSS, JavaScript, bootstrap** (for the front-end)
