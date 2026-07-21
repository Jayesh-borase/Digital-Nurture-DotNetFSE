# Hands-On 8 – HTTP Client, API Integration, Observables & Interceptors
## Objective

The objective of this hands-on is to integrate the Student Course Portal with REST APIs using Angular HttpClient, replace hardcoded data with HTTP requests, perform CRUD operations, use RxJS operators, handle HTTP errors, and implement HTTP Interceptors for authentication, error handling, and loading indication.

---

# Project Structure (up to Hands-On 8)

```text
src
│
├── app
│
├── interceptors
│   ├── auth-interceptor.ts
│   ├── error-handler-interceptor.ts
│   └── loading-interceptor.ts
│
├── services
│   ├── course.ts
│   ├── enrollment.ts
│   ├── auth.ts
│   └── loading.ts
│
├── models
│   └── course.model.ts
│
├── pages
│   ├── course-list
│   ├── course-detail
│   ├── enrollment-form
│   ├── reactive-enrollment-form
│   ├── student-profile
│   └── ...
│
├── app.config.ts
│
└── ...
```

---

# Implementation

## Task 1 – Configure HttpClient

Configured Angular HttpClient using `provideHttpClient()` and registered the HTTP interceptors inside `app.config.ts`.

---

## Task 2 – Replace Hardcoded Data with API Calls

Modified `CourseService` to fetch course data from JSON Server using `HttpClient` instead of hardcoded arrays. Implemented `getCourses()` and `getCourseById()`.

---

## Task 3 – CRUD Operations

Implemented HTTP methods for creating, updating and deleting courses using POST, PUT and DELETE requests. Verified all operations using JSON Server and Postman.

---

## Task 4 – Component Subscription

Subscribed to the Observable returned by `CourseService` inside `CourseListComponent` and displayed the fetched course data. Also handled loading and error states.

---

## Task 5 – RxJS Operators

Applied RxJS operators:

- `map()` for filtering data
- `tap()` for logging
- `retry(2)` for retrying failed requests
- `catchError()` for handling HTTP errors

---

## Task 6 – switchMap

Implemented `switchMap()` to perform dependent HTTP requests. It automatically cancels previous requests whenever a new request is made.

---

## Task 7 – Authentication Interceptor

Created an Authentication Interceptor that automatically adds the Authorization token to every outgoing HTTP request.

---

## Task 8 – Global Error Interceptor

Created a Global Error Interceptor using `catchError()` to handle HTTP errors centrally.

---

## Task 9 – Loading Interceptor

Created a Loading Interceptor with `LoadingService` and `BehaviorSubject` to display a loading indicator while HTTP requests are in progress.

---

# Output

### Task 1 – JSON Server Running

<img width="1919" height="1079" alt="OP1" src="https://github.com/user-attachments/assets/12bec6bf-3207-4bf2-8ebd-ae14a82854d2" />

---



### Task 2 – POST Request



<img width="1919" height="1079" alt="OP2" src="https://github.com/user-attachments/assets/046d794f-2c7a-4bce-97ba-ef751d88292b" />

<img width="1918" height="1033" alt="OP3" src="https://github.com/user-attachments/assets/90a9874a-89d1-4b29-a5d2-73bedbe15c9c" />


---

### Task 3 – PUT Request

<img width="1913" height="1079" alt="OP4" src="https://github.com/user-attachments/assets/c900a22a-5a1c-40d2-ad06-7ab20bd3dccf" />

<img width="1784" height="1032" alt="OP5" src="https://github.com/user-attachments/assets/ac77b973-f49b-48f1-96f3-4a09f7414cdf" />


---

### Task 4 – DELETE Request

<img width="1918" height="1079" alt="OP6" src="https://github.com/user-attachments/assets/cb3bd1cd-6fb4-4de0-9c93-fd4246a1df29" />


---

### Task 5 – Error Handling

<img width="1505" height="803" alt="Error_Handling" src="https://github.com/user-attachments/assets/1e438377-7a49-47a1-89b5-811979514234" />


---

### Task 6 – RxJS tap() Logging

<img width="1919" height="1031" alt="Tap_method" src="https://github.com/user-attachments/assets/6155441d-8c22-4da9-b6d3-a13b53879523" />


---

### Task 7 – Retry Strategy

<img width="1917" height="1020" alt="retry_method" src="https://github.com/user-attachments/assets/f5dd0031-0be8-47d8-b6a7-d96d8010c311" />


---

### Task 8 – Authentication Interceptor


<img width="1915" height="1079" alt="Auth_Inceptors" src="https://github.com/user-attachments/assets/20994e3e-9f4b-49c1-aa76-4c3f9f49fd14" />

---

### Task 10 – Loading Interceptor


<img width="1550" height="891" alt="LoadingInceptors" src="https://github.com/user-attachments/assets/ef4e2c03-3257-4a73-a828-d1813f93f565" />

---

# Conclusion

Through this hands-on, I learned how to integrate Angular applications with REST APIs using HttpClient. I implemented CRUD operations, used RxJS operators like `map()`, `tap()`, `retry()`, `catchError()`, and `switchMap()`, and created Authentication, Error Handling, and Loading Interceptors. This hands-on improved my understanding of Angular HTTP communication and reactive programming.
