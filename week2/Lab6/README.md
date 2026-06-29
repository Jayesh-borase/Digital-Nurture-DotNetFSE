# Lab 6: Updating and Deleting Records Using Entity Framework Core

## Scenario

The Retail Inventory Management System stores product information in a SQL Server database. The store manager needs to update product prices and remove discontinued products from the inventory.

Entity Framework Core provides methods to modify and remove records directly through C# code without writing SQL queries manually.

---

## Objective

The objective of this lab is to update existing records and delete records from the database using Entity Framework Core.

---

## Implementation Steps

### Step 1: Update Program.cs

The existing **Program.cs** file was modified to perform update and delete operations using Entity Framework Core.

The program performs the following operations:

* Retrieve a product before updating.
* Update the product price.
* Retrieve the updated product.
* Retrieve a product before deletion.
* Delete the product.
* Verify that the product has been deleted.

---

### Step 2: Update a Product

The following code retrieves the **Laptop** product and updates its price.

```csharp
var product = await context.Products
    .FirstOrDefaultAsync(p => p.Name == "Laptop");

if (product != null)
{
    product.Price = 70000;
    await context.SaveChangesAsync();
}
```

**Explanation**

* `FirstOrDefaultAsync()` retrieves the product whose name is **Laptop**.
* The product price is updated.
* `SaveChangesAsync()` saves the updated value to the database.

---

### Step 3: Delete a Product

The following code retrieves the **Laptop** product and removes it from the database.

```csharp
var product = await context.Products
    .FirstOrDefaultAsync(p => p.Name == "Laptop");

if (product != null)
{
    context.Products.Remove(product);
    await context.SaveChangesAsync();
}
```

**Explanation**

* `FirstOrDefaultAsync()` retrieves the required product.
* `Remove()` marks the entity for deletion.
* `SaveChangesAsync()` permanently removes the record from the database.

---

### Step 4: Execute the Application

Run the application using:

```bash
dotnet run
```

The application displays:

* Product details before update.
* Product details after update.
* Product details before deletion.
* Confirmation of successful deletion.
* Verification that the product no longer exists in the database.

---


## Output

Look at the screenshots below:
<img width="1919" height="1079" alt="UpdateProduct" src="https://github.com/user-attachments/assets/9e4e461c-e21e-4ef5-82e8-5a0cb12f59d5" />
<img width="1919" height="1079" alt="DeleteProduct" src="https://github.com/user-attachments/assets/392623bf-6087-4493-ac2c-63769a0da85c" />


## Result

Thus, the product was successfully updated and deleted from the Retail Inventory database using Entity Framework Core. The update and delete operations were verified successfully, demonstrating how Entity Framework Core manages modifications and deletions of database records.
