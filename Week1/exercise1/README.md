# Exercise 1: Implementing the Singleton Pattern

## Objective

The objective of this exercise is to implement the **Singleton Design Pattern** in Java. The Singleton pattern ensures that only one instance of a class is created during the entire lifecycle of an application and provides a global point of access to that instance.

## Scenario

In many applications, a logging utility is required to record system events, errors, and debugging information. Creating multiple logger objects can lead to inconsistent logging behavior and unnecessary memory usage. To avoid this, the Logger class is implemented as a Singleton, ensuring that only one logger instance exists throughout the application.

## Steps Performed

### 1. Create a New Java Project

A new Java project named **SingletonPatternExample** was created to demonstrate the Singleton Design Pattern.

### 2. Define the Singleton Class

A class named **Logger** was created with the following characteristics:

* A private static instance of the Logger class.
* A private constructor to prevent object creation from outside the class.
* A public static method to return the single instance of the Logger class.

### 3. Implement the Singleton Pattern

The Singleton pattern was implemented by:

* Declaring a private static Logger object.
* Restricting object creation using a private constructor.
* Providing a static method `getInstance()` that creates the object only once and returns the same instance whenever requested.

### 4. Test the Singleton Implementation

A test class was created to verify the implementation by:

* Calling the `getInstance()` method multiple times.
* Comparing the returned references.
* Confirming that all references point to the same Logger object.

## Expected Output

When the program is executed, both Logger references should have the same memory address or return `true` when compared, proving that only one instance of the Logger class exists.

## Conclusion

The Singleton Design Pattern was successfully implemented using the Logger class. The implementation ensures that only one Logger object is created and shared throughout the application, providing consistent logging behavior and efficient resource utilization.

## Output
![The Logger class implements the Singleton Design Pattern. It contains a private static instance variable to store the single object of the class, a private constructor to prevent external object creation, and a public static getInstance() method that provides global access to the single Logger instance. The log() method is used to display log messages.](image-1.png)