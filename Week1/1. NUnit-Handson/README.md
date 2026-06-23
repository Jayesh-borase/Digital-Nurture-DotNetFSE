# Exercise 5: Unit Testing a Calculator Library Using NUnit

## Scenario:
You are working on a core utility called CalcLibrary that performs basic arithmetic operations such as addition, subtraction, multiplication, and division. To ensure the reliability and correctness of this utility, unit tests are implemented using the NUnit framework.

## Steps Taken:

### 1. Project Initialization:
A C# solution was created with two projects:

- CalcLibrary: Contains methods for arithmetic operations.
- CalcLibrary.Tests: A test project using NUnit to validate the functionality of CalcLibrary.

### 2. Creating the Calculator Class (CalcLibrary):
A class named Calculator was defined with the following methods:

- Add()
- Subtract()
- Multiply()
- Divide()

### 3. Writing Unit Tests in NUnit (CalcLibrary.Tests):
A test class CalculatorTests was created to test each method in isolation using [TestCase] attributes for multiple input values.

### 4. Running the Tests:
Tests were executed using the Test Explorer in Visual Studio. All test cases passed, including handling of exceptions.

## Output:
<img width="1749" height="1054" alt="NUnit" src="https://github.com/user-attachments/assets/5574b6bf-ffb5-4c09-9969-db332418f64c" />


## Conclusion:
The use of NUnit enabled automated and isolated testing of CalcLibrary. This ensures that individual methods work as expected and allows for regression-free development in future updates. The structure also promotes test-driven development (TDD) practices in the project.
