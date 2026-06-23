# Exercise 1: Write Testable Code with Moq

## Scenario:
You are developing a transaction-based application where email notifications must be sent to users after each operation. However, for testing purposes, you want to avoid sending real emails and instead verify that the email-sending functionality is called correctly. The goal is to unit test the MailSender class using NUnit and mocking to simulate external dependencies.

## Steps Taken:

### 1. Interface Design for Abstraction:
To support testability, an interface IEmailService was created to represent the email-sending behavior.

### 2. MailSender Implementation:
The MailSender class depends on IEmailService and calls it during operations.

### 3. Creating the Unit Test Project:
A test class was created using NUnit and Moq (a mocking library) to simulate the IEmailService dependency without sending real emails. Required NuGet packages were installed.

### 4. Writing Unit Tests:
Unit tests were written to verify that the email service method was invoked correctly. Moq was used to create mock objects and validate interactions.

### 5. Running the Tests:
Tests were executed using the Test Explorer in Visual Studio or the `dotnet test` command. All test cases passed successfully without sending actual emails.

## Output:

<img width="1914" height="1057" alt="MOQ" src="https://github.com/user-attachments/assets/34be2fa3-e81a-4cd9-acdc-2f8247954f1a" />


## Conclusion:
Using Moq with NUnit enabled isolated unit testing of the MailSender class by replacing external email dependencies with mock objects. This approach improved testability, reduced dependency on external services, and ensured reliable verification of email notification functionality without sending real emails.
