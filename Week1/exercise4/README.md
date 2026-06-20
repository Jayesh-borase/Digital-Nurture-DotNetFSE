# Exercise 4: E-commerce Platform Search Function

## Objective

The objective of this exercise is to implement and analyze different searching algorithms used in an e-commerce platform. The exercise focuses on understanding the performance of Linear Search and Binary Search using Big O notation.

## Scenario

An e-commerce platform requires an efficient product search functionality to quickly locate products from a large inventory. Different search algorithms were evaluated to determine the most suitable approach for improving search performance.

## Steps Taken

### 1. Understanding Algorithm Analysis

Big O notation was studied to measure the efficiency of search algorithms. The best-case, average-case, and worst-case scenarios were analyzed to understand how algorithm performance changes with increasing data size.

### 2. Product Class Setup

A `Product` class was created with the following attributes:

* Product ID
* Product Name
* Category

Arrays were used to store product information for implementing search operations.

### 3. Implementing Search Methods

Two searching algorithms were implemented:

#### Linear Search

* Searches each product sequentially.
* Suitable for unsorted data.
* Time Complexity: **O(n)**

#### Binary Search

* Searches by repeatedly dividing the search space into halves.
* Requires the data to be sorted.
* Time Complexity: **O(log n)**

### 4. Comparative Analysis

The performance of both search algorithms was compared.

* Linear Search examines elements one by one until the desired product is found.
* Binary Search significantly reduces the number of comparisons by eliminating half of the search space at each step.

Binary Search was identified as the preferred choice for large product datasets because of its superior efficiency.

## Time Complexity Comparison

| Algorithm     | Best Case | Average Case | Worst Case |
| ------------- | --------- | ------------ | ---------- |
| Linear Search | O(1)      | O(n)         | O(n)       |
| Binary Search | O(1)      | O(log n)     | O(log n)   |

## conclusion
The E-commerce Platform Search Function was successfully implemented using Linear Search and Binary Search algorithms. After comparing their performance, Binary Search was found to be more suitable for large and sorted product datasets due to its logarithmic time complexity. This makes it an efficient choice for real-world e-commerce applications where fast product retrieval is essential.


## Output
<img width="1591" height="1076" alt="image" src="https://github.com/user-attachments/assets/f409cfd9-a46a-403c-9a34-720d2e8fc72a" />
