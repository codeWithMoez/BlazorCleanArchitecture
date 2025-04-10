# 🚀 Blazor Clean Architecture CRUD Application

A full-stack CRUD application built with **Blazor Server** following the **Clean Architecture** principles. This project demonstrates how to implement a product management system with create, read, update, and delete functionality using a layered architecture.

## 📋 Features

- ✅ **Product Management**: Add, edit, delete, and view products
- ✅ **Data Validation**: Form validation using DataAnnotations
- ✅ **Clean Architecture**: Separation of concerns with distinct layers
- ✅ **Entity Framework Core**: Database operations with SQL Server
- ✅ **Responsive UI**: Bootstrap-based UI components

## 🏗️ Project Structure

The project follows the Clean Architecture pattern, organized into four main layers:

1. **Presentation Layer** (`BlazorCleanArchitecture.Presentation`):
   - 📱 Blazor components and pages
   - 🔄 UI logic and navigation

2. **Application Layer** (`BlazorCleanArchitecture.Application`):
   - 📦 Application services and business logic
   - 🔄 Interfaces for repositories and external dependencies

3. **Domain Layer** (`BlazorCleanArchitecture.Domain`):
   - 📐 Domain models
   - 🔄 Business rules and validation

4. **Infrastructure Layer** (`BlazorCleanArchitecture.Infrastructure`):
   - 📊 Database context and repositories
   - 🔄 Implementation of interfaces defined in the Application layer

## 🚀 Getting Started

### 🛠️ Prerequisites

- .NET 8 SDK
- Visual Studio 2022 (17.8 or higher)
- SQL Server (LocalDB or full instance)

### 📥 Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/blazor-clean-architecture.git
   ```

2. Open the solution in Visual Studio 2022.

3. Update the connection string in `appsettings.json` to point to your SQL Server instance:
   ```json
   "ConnectionStrings": {
     "BlazorCleanArchitecture": "Data Source=YOUR_SERVER_NAME;Initial Catalog=BlazorCleanArchitecture;Integrated Security=True;Trust Server Certificate=True"
   }
   ```

4. Run the application:
   - Press `F5` to start the application in debug mode
   - Navigate to `https://localhost:PORT/products` to view the product management page

### 📦 Database Setup

The application uses Entity Framework Core migrations to create and update the database schema. To apply migrations:

1. Open the Package Manager Console in Visual Studio.
2. Run the following command:
   ```bash
   Update-Database
   ```

## 📖 Usage

### 🛠️ Product Management

- **View Products**: Navigate to `/products` to see the list of all products
- **Add Product**: Click "Add New Product" to create a new product
- **Edit Product**: Click the "Edit" button on any product to modify its details
- **Delete Product**: Click the "Delete" button to remove a product

### ✅ Form Validation

All forms include validation using DataAnnotations. The application will display error messages if required fields are missing or if the input format is invalid.

## 📦 Project Dependencies

- **Blazor Server**: For the UI framework
- **Entity Framework Core**: For database operations
- **Bootstrap**: For styling and responsive design

## 📄 License

This project is licensed under the MIT License - see the LICENSE file for details.