
# Exercise 1: Ranking and Window Functions

## Scenario

You are tasked with retrieving the top 3 most expensive products in each category from a Products table. The challenge involves handling possible price ties and ensuring the most accurate ranking per category.

## Steps Taken

### Understanding the Dataset

The Products table contains columns such as ProductID, ProductName, Category, and Price. The goal is to group data by Category and rank products by Price in descending order.

### Using ROW_NUMBER() for Unique Ranking

A subquery was written using the ROW_NUMBER() window function partitioned by Category and ordered by Price DESC. This assigns a unique row number to each product in a category.

### Using RANK() for Tied Ranking

The RANK() function was similarly applied to handle ties. If two or more products share the same price, they get the same rank, and subsequent ranks are skipped.

### Using DENSE_RANK() for Consecutive Ranking with Ties

To assign consecutive ranks even when there are ties, the DENSE_RANK() function was used. It behaves like RANK(), but does not skip rank numbers.

## Output

### USING ROW_NUMBER()

<img width="1702" height="915" alt="exp1" src="https://github.com/user-attachments/assets/5e7afb85-76c3-4008-9e3a-a99c17b4b312" />


### USING RANK()

<img width="1727" height="993" alt="exp2" src="https://github.com/user-attachments/assets/f81153c9-88b5-4af8-a6a3-9e1ea0cca425" />


### USING DENSE_RANK()

<img width="1912" height="1079" alt="exp3" src="https://github.com/user-attachments/assets/9211dfb5-3cd9-49d4-a8d3-7e35cc2290af" />


## Conclusion

The implementation demonstrated how different SQL ranking functions handle ordering and ties. These approaches offer flexible solutions to common "Top-N per group" problems in analytics and reporting.
