# Hands-On 7: Angular Routing – Guards, Lazy Loading & Route Data

## Objective

The objective of this hands-on was to understand Angular Routing by implementing route configuration, route parameters, query parameters, nested routes, lazy loading, and route guards within the Student Course Portal. I learned how Angular enables Single Page Application (SPA) navigation using the Router, how feature modules can be lazy loaded to improve application performance, and how route guards can protect pages and prevent accidental navigation away from unsaved forms.

---

# Project Structure

```text
student-course-portal/
│
├── src/
│   └── app/
│       │
│       ├── components/
│       │   ├── header/
│       │   ├── course-card/
│       │   ├── course-summary-widget/
│       │   └── notification/
│       │
│       ├── pages/
│       │   ├── home/
│       │   ├── course-list/
│       │   ├── courses-layout/
│       │   ├── course-detail/
│       │   ├── enrollment-form/
│       │   ├── reactive-enrollment-form/
│       │   ├── student-profile/
│       │   └── not-found/
│       │
│       ├── guards/
│       │   ├── auth-guard.ts
│       │   └── unsaved-changes-guard.ts
│       │
│       ├── services/
│       │   ├── auth.ts
│       │   ├── course.ts
│       │   └── enrollment.ts
│       │
│       ├── features/
│       │   └── enrollment/
│       │       ├── enrollment-module.ts
│       │       └── enrollment-routing-module.ts
│       │
│       ├── app.routes.ts
│       ├── app.ts
│       ├── app.html
│       ├── app.css
│       └── app.config.ts
│
├── angular.json
├── package.json
└── ...
```

---

# Task 1: Route Configuration, Parameters and Nested Routes

In this task, I configured the application's routing using Angular Router by creating routes for the Home page, Course List, Course Detail, Student Profile, and Not Found page. I generated a Course Detail component and used route parameters to retrieve the selected course ID through the ActivatedRoute service before displaying the corresponding course information using the CourseService. I made each course card clickable so that selecting a course automatically navigated to its detailed view. I also implemented query parameters for searching courses and retrieved the search value from the URL. Finally, I configured nested routing by introducing a Courses Layout component containing a router-outlet that displays both the course list and course detail pages within the same layout.

---

# Task 2: Lazy Loading and Route Guards

In this task, I implemented Angular's lazy loading feature by creating an Enrollment feature module and configuring it to load only when the user navigates to the enrollment routes, reducing the application's initial bundle size. I created an Auth Service together with an Auth Guard that protected the Student Profile and Enrollment pages by allowing access only when the user is logged in. Finally, I implemented a CanDeactivate Guard for the Reactive Enrollment Form that warns users whenever they attempt to leave the page with unsaved changes, preventing accidental data loss.

---

# Expected Output

After successfully completing this hands-on, the application should:

- Configure routing for all portal pages.
- Navigate to Course Detail using route parameters.
- Pass and retrieve query parameters for searching courses.
- Display nested routes using a Courses Layout component.
- Display a custom 404 Not Found page for invalid URLs.
- Load the Enrollment feature using Lazy Loading.
- Protect Profile and Enrollment routes using an Auth Guard.
- Display a confirmation dialog before leaving a Reactive Form with unsaved changes.

---

# Output

## Task 1 – Course Detail Page

<img width="1895" height="1026" alt="Task1_Course-Detail" src="https://github.com/user-attachments/assets/6825a4c6-5674-4921-9a2d-ba43b3623ce6" />

---

## Task 1 – Query Parameters

<img width="1919" height="1026" alt="task1Query_Parameter" src="https://github.com/user-attachments/assets/fad71e3a-a85f-4c80-8a5f-0b481e0d8e8d" />


---

## Task 1 – Not Found Page

<img width="1785" height="1018" alt="Task1_NotFound" src="https://github.com/user-attachments/assets/c8288a09-0c2c-42fb-bbfe-5f514f62dfd5" />


---

## Task 2 – Lazy Loading Configuration

<img width="1917" height="1006" alt="Task2_ConfiguredLazyLoading" src="https://github.com/user-attachments/assets/14e82a47-e575-4a34-82ed-96adda7595ce" />


---

## Task 2 – CanDeactivate Guard

<img width="1898" height="1079" alt="Task2_CanDeactive" src="https://github.com/user-attachments/assets/68f6b6bb-577d-4ebc-b025-5cf9cc1f6e90" />


# Conclusion

Through this hands-on, I gained practical experience in Angular Routing by implementing route configuration, nested routes, route parameters, query parameters, lazy loading, and route guards. I learned how Angular manages navigation within a Single Page Application, how lazy loading improves application performance by downloading feature modules only when required, and how route guards protect application resources and prevent accidental data loss. This hands-on strengthened my understanding of Angular's routing architecture and demonstrated industry-standard navigation and security practices used in modern Angular applications.


# Conclusion

Through this hands-on, I gained practical experience in Angular Routing by implementing route configuration, nested routes, route parameters, query parameters, lazy loading, and route guards. I learned how Angular manages navigation within a Single Page Application, how lazy loading improves application performance by downloading feature modules only when required, and how route guards protect application resources and prevent accidental data loss. This hands-on strengthened my understanding of Angular's routing architecture and demonstrated industry-standard navigation and security practices used in modern Angular applications.
