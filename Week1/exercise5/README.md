# Exercise 7: Financial Forecasting

## Objective

The objective of this exercise is to implement a recursive algorithm for financial forecasting. The exercise demonstrates how recursion can be used to predict future values based on a given growth rate and time period.

## Scenario

A financial forecasting tool needs to estimate future values using historical growth information. The prediction is based on a fixed annual growth rate applied over a specified number of years.

Recursion is used to repeatedly apply the growth rate until the desired forecasting period is reached.

## Steps Taken

### 1. Understanding Recursive Algorithms

Recursion is a programming technique in which a method calls itself to solve a problem. A recursive solution consists of:

* Base Case: Stops the recursion.
* Recursive Case: Calls the same method with a smaller subproblem.

Recursion simplifies problems that can be divided into smaller, similar tasks.

### 2. Financial Forecast Setup

A forecasting method was created to calculate future values using:

* Current Value
* Growth Rate
* Number of Years

These inputs are used to estimate the future financial value.

### 3. Implementing the Recursive Algorithm

A recursive method was developed to calculate future values by repeatedly applying the growth rate for each year.

The algorithm continues calling itself until the number of years becomes zero, which serves as the base case.

### 4. Performance Analysis

The recursive algorithm performs one recursive call for each year.

Time Complexity:

```text
O(n)
```

where **n** represents the number of years.

Space Complexity:

```text
O(n)
```

because each recursive call is stored in the call stack until execution completes.

### 5. Optimization

The recursive solution can be optimized using:

* Memoization
* Dynamic Programming
* Direct Mathematical Formula

These approaches reduce unnecessary computations and improve efficiency for large forecasting periods.

## Output

<img width="1727" height="1079" alt="image" src="https://github.com/user-attachments/assets/035bff47-ab4a-442d-8ad7-5577b34e12ff" />


## Conclusion

The Financial Forecasting application was successfully implemented using recursion. The recursive approach simplified the forecasting logic by repeatedly applying the growth rate until the specified time period was reached. The exercise demonstrated the practical use of recursion and highlighted important considerations regarding time complexity and optimization techniques.
