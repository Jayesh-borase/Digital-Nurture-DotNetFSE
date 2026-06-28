# Lab 1: Understanding ORM with a Retail Inventory System

## Scenario

The retail store required a data access layer that simplifies database operations using C# objects. Object-Relational Mapping (ORM) enables developers to work with databases using familiar object-oriented syntax.

## Objective

* Understand the concept of ORM.
* Learn how EF Core maps C# classes to relational database tables.
* Set up a new .NET console project and prepare it to use EF Core.

## Procedure

### Step 1: What is ORM?

ORM (Object-Relational Mapping) translates C# classes into relational tables.

**Benefits include:**

* Higher productivity
* Easier maintenance
* Less need for raw SQL queries

### Step 2: EF Core vs EF Framework

* **EF Core:** Cross-platform, lightweight, modern (supports LINQ, async queries).
* **EF 6 (Framework):** Windows-only, more mature, but less flexible.

### Step 3: EF Core 8.0 Features

* JSON column mapping
* Better performance with compiled models
* Support for interceptors and optimized bulk operations

### Step 4: Create .NET Console App

```bash
dotnet new console -n RetailInventory
cd RetailInventory
code .
```

### Step 5: Install EF Core Packages

```bash
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Design
```
### output


