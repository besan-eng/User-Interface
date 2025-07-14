# User-Interface
C# User Interface Project with Microsoft SQL server Database
This is a desktop application developed in C# using Windows Forms. The application connects to a Microsoft SQL Server database and allows users to perform standard CRUD operations (Create, Read, Update, Delete) through an intuitive graphical user interface.

##  Features

- User-friendly Windows Forms interface
- Connects to a Microsoft SQL Server database
- Add, edit, delete, and display records
- Input validation and error handling
- Organized and modular code structure

##  Technologies Used

- Programming Language: C#
- Framework: .NET (Windows Forms)
- Database: Microsoft SQL Server
- Data Access: ADO.NET
- IDE: Visual Studio

##  How to Run the Project

1. Open the solution in Visual Studio.
2. Make sure SQL Server is running on your machine.
3. if SQL Doesn't work make sure to Update your windows
4. Check and update the connection string in App.config or directly in the code file (e.g., `Database.cs`) to match your SQL Server settings:
   ```csharp
   string connectionString = "Data Source=YOUR_SERVER_NAME;Initial Catalog=YOUR_DATABASE_NAME;Integrated Security=True;";
