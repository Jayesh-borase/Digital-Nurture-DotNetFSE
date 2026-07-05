# Exercise 2: ASP.NET Core Web API with Swagger and Postman

## Description

This exercise demonstrates the creation of an ASP.NET Core Web API application using .NET, integration of Swagger for API documentation and testing, implementation of GET and POST operations, testing API endpoints using Swagger UI and Postman, and customization of API routes using the `Route` attribute.

---

## Objectives

- Create an ASP.NET Core Web API application.
- Install and configure Swagger using Swashbuckle.AspNetCore.
- Implement GET and POST API endpoints.
- Use `ProducesResponseType` attributes.
- Test API endpoints using Swagger UI.
- Test API endpoints using Postman.
- Modify controller routing using the `Route` attribute.
- Verify API accessibility after route modification.

---

## Project Structure

```text
FirstWebApi
│
├── Connected Services
│
├── Dependencies
│
├── Properties
│   └── launchSettings.json
│
├── Controllers
│   ├── EmployeeController.cs
│   └── ValuesController.cs
│
├── Models
│   └── Employee.cs
│
├── appsettings.json
├── FirstWebApi.http
└── Program.cs
```

---

## Implementation Summary

- Created an ASP.NET Core Web API project.
- Installed and configured Swagger using Swashbuckle.AspNetCore.
- Created Employee model and EmployeeController.
- Implemented GET and POST endpoints.
- Added `ProducesResponseType` attributes for API documentation.
- Tested API endpoints using Swagger UI.
- Tested GET endpoint using Postman.
- Modified controller route from `api/Employee` to `api/Emp`.
- Verified successful API execution after route modification.

---

## Screenshots

Look at the screenshots below:

### Project Setup

<img width="1919" height="1079" alt="ProjectSetup" src="https://github.com/user-attachments/assets/319fdd93-2dbd-4348-aaf3-4fd44f1f960a" />


Shows:

- Project structure
- Employee model
- Employee controller implementation

---

### Swagger GET Request

<img width="1869" height="1007" alt="GetRequest" src="https://github.com/user-attachments/assets/d617a32e-b1ae-4305-97f7-9c5dc010f2ae" />


Shows:

- Swagger UI
- GET endpoint execution
- Employee list response

---

### Swagger POST Request

<img width="1918" height="1030" alt="Post_request" src="https://github.com/user-attachments/assets/09355aa1-858d-4d6d-be5e-5275ac9ff5d0" />


Shows:

- POST endpoint request body
- Employee data submission

---

### Swagger POST Response

<img width="1909" height="1033" alt="Post_Response" src="https://github.com/user-attachments/assets/515b55e4-3125-4bfb-b387-d1ed50a25797" />


Shows:

- Successful POST operation
- HTTP Status Code **201 Created**

---

### Postman GET Request

<img width="1919" height="1078" alt="Postman_getRequest" src="https://github.com/user-attachments/assets/f08cef01-dea2-45b5-82f6-e80e80d84756" />


Shows:

- GET request execution in Postman
- Employee list response
- HTTP Status Code 200 OK

## Result

Thus, an ASP.NET Core Web API application was successfully developed using .NET. Swagger was integrated for API documentation and testing, GET and POST endpoints were implemented and verified using Swagger UI and Postman, and the controller route was customized successfully using the `Route` attribute.
- Employee list response
- HTTP Status Code **200 OK**
