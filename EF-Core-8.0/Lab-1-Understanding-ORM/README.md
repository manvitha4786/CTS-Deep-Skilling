# Lab 1: Understanding ORM with a Retail Inventory System

## Objective

The objective of this lab is to understand the concept of Object Relational Mapping (ORM), learn the differences between Entity Framework and Entity Framework Core, explore the latest features of EF Core 8.0, and create a .NET Console Application with the required Entity Framework Core packages.

---

## What is ORM?

ORM (Object Relational Mapping) is a programming technique that maps C# classes to relational database tables. It allows developers to perform database operations using C# objects instead of writing SQL queries manually.

### Example

- Product class → Products table
- Category class → Categories table
- Stock class → Stock table

### Benefits

- Increased productivity
- Reduced SQL coding
- Better maintainability
- Easier database interaction
- Improved code readability

---

## Entity Framework Core vs Entity Framework

| Entity Framework Core | Entity Framework 6 |
|------------------------|--------------------|
| Cross-platform | Windows only |
| Lightweight | Heavier framework |
| Better performance | Moderate performance |
| Supports LINQ | Supports LINQ |
| Supports Async Queries | Limited async support |
| Supports modern .NET versions | Supports only .NET Framework |

---

## Features of EF Core 8.0

- JSON Column Mapping
- Compiled Models for improved startup performance
- Interceptors for custom database operations
- Better Bulk Operations
- Improved LINQ support
- Better performance and scalability

---

## Creating the Console Application

Create a new .NET Console Application.

```bash
dotnet new console -n RetailInventory
cd RetailInventory
```

---

## Installing EF Core Packages

Install SQL Server Provider

```bash
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
```

Install EF Core Design Package

```bash
dotnet add package Microsoft.EntityFrameworkCore.Design
```

---

## Verify Installed Packages

```bash
dotnet list package
```

Expected packages:

- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Design

---

## Build the Project

```bash
dotnet build
```

Expected Output

```
Build succeeded.
```

---

## Run the Application

```bash
dotnet run
```

Expected Output

```
Retail Inventory System using EF Core
```

---

## Advantages of EF Core

- Cross-platform support
- Easy database connectivity
- Reduces manual SQL coding
- Supports LINQ queries
- Supports asynchronous programming
- High performance
- Easy migration support
- Better maintainability

---

## Conclusion

Entity Framework Core is a modern Object Relational Mapper (ORM) developed by Microsoft. It simplifies database operations by mapping C# classes to database tables, reducing manual SQL coding and improving application maintainability. EF Core provides high performance, cross-platform support, and modern features that make database development easier and more efficient.

---

## Author

**Name:** Manvitha Gaddikoppula

**Course:** CTS Deep Skilling – EF Core 8.0

**Lab:** Lab 1 – Understanding ORM with a Retail Inventory System
