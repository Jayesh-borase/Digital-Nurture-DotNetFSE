# Lab 4: Inserting Initial Data into the Database

## 1. Scenario

The store manager wants to seed the Retail Inventory Management System with categories and initial products so that the application contains sample data for testing and operations.

Instead of manually entering records into the database, Entity Framework Core can be used to insert data directly through C# code. This approach makes data management easier and reduces manual database operations.

---

## 2. Objective

Use Entity Framework Core to insert data into the database using **AddRangeAsync()** and **SaveChangesAsync()**. Ensure that the database is populated with sample categories and products.

---

## 3. Understanding Data Insertion in Entity Framework Core

Entity Framework Core provides methods for adding records to database tables through entity objects.

In this lab, I inserted sample categories and products into the database using Entity Framework Core.

The following methods were used:

* AddRangeAsync()
* SaveChangesAsync()

---

## 4. Purpose of AddRangeAsync()

The **AddRangeAsync()** method is used to add multiple records at the same time.

**Example:**

* Electronics
* Groceries

can be added together instead of inserting each record separately.

---

## 5. Purpose of SaveChangesAsync()

The **SaveChangesAsync()** method saves all pending changes to the database.

Without calling **SaveChangesAsync()**, the records will not be stored in the database.

---

## 6. Project Structure

This lab was implemented using the same **Retail Inventory** project created in **Lab 3**.

The complete project structure, entity classes, database context, migrations, and database configuration were already created in Lab 3.

For this lab, only the **Program.cs** file was updated to insert initial data into the database.

Refer to **Lab 3** for the complete project structure.

---

## 7. Procedure

### Step 1: Update Program.cs

The existing **Program.cs** file from Lab 3 was modified to insert categories and products into the database using Entity Framework Core.

The program creates category objects, product objects, establishes relationships between them, and saves the records to the database using **SaveChangesAsync()**.

---

### Step 2: Run the Application

Execute the application using:

```bash
dotnet run
```

After successful execution, the following message is displayed:

```text
Data inserted successfully.
```

---

### Step 3: Verify Data in SQL Server

The **Categories** and **Products** tables were opened in SQL Server Object Explorer to verify that the records were inserted successfully. The inserted products were also verified to be associated with their respective categories.

---

## 8. Output

Look at the screenshots below:

<img width="1905" height="1069" alt="Screenshot 2026-06-28 232821" src="https://github.com/user-attachments/assets/d3cbbff4-0be2-4d5d-aecd-fca61aeedf9c" />

This screenshot shows the successful execution of the application and confirms that the insertion operation completed successfully.

<img width="1642" height="1077" alt="Screenshot 2026-06-28 233017" src="https://github.com/user-attachments/assets/21aaaf6a-407c-491c-a298-1c73dec7fc96" />
<img width="1679" height="1035" alt="Screenshot 2026-06-28 233031" src="https://github.com/user-attachments/assets/04d9ede2-40f2-4031-bf87-fda075d3035e" />


This screenshot shows the records stored in the **Categories** and **Products** tables and verifies that Entity Framework Core successfully inserted the data into the database.

---

## 9. Analysis

Entity Framework Core allows developers to work with database records using C# objects instead of writing SQL insert statements manually.

**AddRangeAsync()** is used to add multiple records efficiently, while **SaveChangesAsync()** commits all pending changes to the database.

This approach improves code readability, simplifies database operations, and automatically manages relationships between entities.

---

## 10. Result

Thus, the initial categories and products were successfully inserted into the **Retail Inventory** database using Entity Framework Core. The inserted data was verified in SQL Server, confirming successful data persistence and relationship mapping.
