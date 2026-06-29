# Lab 5: Retrieving Data from the Database Using Entity Framework Core

## Scenario

The Retail Inventory Management System stores product information in a SQL Server database. The store manager wants to retrieve product details and display them on the dashboard.

Entity Framework Core provides various methods to fetch data from the database efficiently. In this lab, data retrieval operations were performed using asynchronous methods provided by Entity Framework Core.

---

## Objective

The objective of this lab is to retrieve data from the database using:

* `ToListAsync()`
* `FindAsync()`
* `FirstOrDefaultAsync()`

These methods help in fetching all records, retrieving a specific record by its primary key, and obtaining the first record that matches a given condition.

---

## Implementation Steps

### Step 1: Update Program.cs

The existing **Program.cs** file from the RetailInventory project was modified to retrieve product information from the database.

The program performs three different retrieval operations:

* Retrieve all products using `ToListAsync()`.
* Retrieve a specific product using `FindAsync()`.
* Retrieve the first product that satisfies a condition using `FirstOrDefaultAsync()`.

---

### Step 2: Create AppDbContext Object

The program first creates an instance of the database context.

```csharp
using var context = new AppDbContext();
```

This object establishes communication between the application and the database.

---

### Step 3: Retrieve All Products

The following code retrieves all records from the **Products** table.

```csharp
var products = await context.Products
    .Include(p => p.Category)
    .ToListAsync();
```

**Explanation**

* `Products` refers to the **Products** table.
* `Include()` loads the related **Category** information.
* `ToListAsync()` retrieves all records asynchronously and stores them in a list.
* The retrieved products are displayed using a `foreach` loop.

---

### Step 4: Retrieve a Product by ID

The following code retrieves a specific product using its primary key.

```csharp
var productById = await context.Products.FindAsync(productId);
```

**Explanation**

* `FindAsync()` searches for a record using the primary key.
* It returns the matching product if found.
* If no matching record exists, it returns `null`.

---

### Step 5: Retrieve the First Matching Product

The following code retrieves the first product whose price is greater than ₹50,000.

```csharp
var expensiveProduct = await context.Products
    .FirstOrDefaultAsync(p => p.Price > 50000);
```

**Explanation**

* `FirstOrDefaultAsync()` returns the first record that satisfies the condition.
* If no matching record exists, it returns `null`.
* In this case, it searches for products priced above ₹50,000.

---

### Step 6: Execute the Application

Run the application using:

```bash
dotnet run
```

The application displays:

* All products stored in the database.
* Product retrieved using its ID.
* First product matching the specified condition.

---

### Step 7: Verify the Database

The **Products** table was viewed using SQL Server Object Explorer to verify that the displayed records were present in the database.

---

## Output

<img width="1857" height="1057" alt="image" src="https://github.com/user-attachments/assets/02235257-23a3-469d-8229-4d7ba2ada1e1" />

---

## Result

Thus, the product data was successfully retrieved from the Retail Inventory database using Entity Framework Core. The records were fetched using **ToListAsync()**, **FindAsync()**, and **FirstOrDefaultAsync()**, demonstrating different techniques for retrieving data from the database.
