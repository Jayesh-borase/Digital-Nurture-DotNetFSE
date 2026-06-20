# Exercise 3: Implementing the MVC Pattern

## Objective

The objective of this exercise is to implement the Model-View-Controller (MVC) Design Pattern. The MVC Pattern separates an application into three components: Model, View, and Controller, making the application easier to develop, maintain, and extend.

## Scenario

A student management system needs to store and display student information. The MVC Pattern is used to separate the student data, user interface, and control logic into different components.

This approach improves code organization, maintainability, and scalability of the application.

## Steps Performed

### 1. Create a New Project

A project named **MVCPatternExample** was created.

### 2. Define Model Class

A class named **Student** was created to represent student information.

The class contains the following attributes:

* Student ID
* Student Name
* Student Grade

### 3. Define View Class

A class named **StudentView** was created.

The View is responsible for displaying student information to the user through the `displayStudentDetails()` method.

### 4. Define Controller Class

A class named **StudentController** was created.

The Controller acts as an intermediary between the Model and the View. It updates student information and controls the display of data through the View.

### 5. Test the Implementation

A main class was developed to demonstrate:

* Creating a Student object.
* Creating a StudentView object.
* Creating a StudentController object.
* Displaying student details.
* Updating student information using the Controller.
* Displaying the updated information through the View.

## Benefits of MVC Pattern

* Separates data, presentation, and business logic.
* Improves code maintainability.
* Enhances code reusability.
* Simplifies testing and debugging.
* Makes applications easier to modify and extend.

## Conclusion

The MVC Pattern was successfully implemented using a Student Management System example. The Student class served as the Model, StudentView acted as the View, and StudentController functioned as the Controller. This implementation demonstrated how MVC separates data management, user interface, and application logic, resulting in a more organized and maintainable application structure.

## output
<img width="1901" height="1058" alt="image" src="https://github.com/user-attachments/assets/22ed327e-e44d-472e-ab16-6b5f78e95f99" />
