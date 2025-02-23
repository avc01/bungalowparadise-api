# Bungalow Paradise .NET 8 API Project 🚀

## Overview 🏨

Welcome to the backend of my hotel reservation system! This project is a **.NET 8 Core API** built using **Visual Studio Community Edition**. It utilizes **Pomelo Entity Framework Core for MySQL** to manage database operations and is designed to work with **MySQL version 8.4.4 LTS**.

This API follows best practices for RESTful services and includes a dedicated **Migrations** folder to help build and manage the database schema efficiently.

---

## Requirements ✅

Before running this project, ensure you have the following installed:

- **.NET 8 SDK** → [Download .NET 8](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- **Visual Studio Community Edition** → [Download Visual Studio](https://visualstudio.microsoft.com/)
- **MySQL Server 8.4.4 LTS** → [Download MySQL](https://dev.mysql.com/downloads/)
- **Pomelo.EntityFrameworkCore.MySql** → Installed via NuGet (included in the project dependencies)

---

## Setup and Configuration ⚙️

### 1. Clone the Repository 📂

First, clone the repository to your local machine:

```sh
git clone https://github.com/yourusername/your-repo.git
cd your-repo
```

### 2. Configure Environment Variables 🔧

Create an `.env` or `appsettings.json` file to store your database connection string and other configurations. Example:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=hotel_db;User=root;Password=yourpassword;"
  }
}
```

### 3. Restore Dependencies 📦

Run the following command to restore NuGet packages:

```sh
dotnet restore
```

### 4. Apply Migrations 🏗️

Ensure your database is set up properly by running Entity Framework Core migrations:

```sh
dotnet ef database update
```

> **Note:** If you need to create a new migration, use:
>
> ```sh
> dotnet ef migrations add InitialCreate
> ```

### 5. Run the Application ▶️

Start the API using:

```sh
dotnet run
```

By default, the application will run on `http://localhost:5000` (or `https://localhost:5001` for HTTPS).

---

## API Documentation 📜

This API follows RESTful conventions. To explore available endpoints, use tools like **Swagger**, **Postman**, or **cURL**.

If Swagger is enabled, visit:

```
http://localhost:5000/swagger
```

---

Happy coding! 🎉
