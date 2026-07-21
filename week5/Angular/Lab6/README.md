# Hands-On 6: Services & Dependency Injection

## Objective

The objective of this hands-on was to understand how Angular Services and Dependency Injection (DI) are used to share data and business logic across multiple components. I learned how to create reusable services, inject them into components using Angular's dependency injection system, implement the Singleton Service pattern using `providedIn: 'root'`, share application state between components, and understand hierarchical dependency injection through component-level providers. I also developed an Enrollment Service to manage course enrollment and demonstrated service-to-service dependency injection.

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
│       ├── models/
│       │   └── course.model.ts
│       │
│       ├── services/
│       │   ├── course.ts
│       │   ├── enrollment.ts
│       │   └── notification.ts
│       │
│       ├── directives/
│       ├── pipes/
│       │
│       ├── pages/
│       │   ├── home/
│       │   ├── course-list/
│       │   ├── student-profile/
│       │   ├── enrollment-form/
│       │   └── reactive-enrollment-form/
│       │
│       ├── app.ts
│       ├── app.html
│       ├── app.routes.ts
│       └── app.config.ts
│
├── public/
├── angular.json
├── package.json
├── tsconfig.json
└── ...
```

---

# Task 1: Create and Use a Course Service

In this task, I created a reusable **CourseService** to centralize all course-related data within the Student Course Portal. I defined a strongly typed **Course** interface to improve type safety and maintainability. The service contained methods to retrieve all courses, fetch a course by its ID, and add new courses. I injected the CourseService into both the Home and Course List components, replacing hardcoded course data with shared service data. I also created a Course Summary Widget that displayed the total number of available courses, demonstrating that all components were using the same singleton service instance provided through Angular's dependency injection system.

---

# Task 2: Enrollment Service and Hierarchical Dependency Injection

In this task, I implemented an **EnrollmentService** to manage course enrollment across the application. The service maintained a shared list of enrolled course IDs and provided methods to enroll, unenroll, verify enrollment status, and retrieve complete course information by using the CourseService internally. I injected the EnrollmentService into the Course Card component, allowing the Enroll button to dynamically toggle between **Enroll** and **Unenroll** while updating the shared enrollment state. I also displayed all enrolled courses inside the Student Profile page, demonstrating how multiple components share the same service instance. Finally, I implemented a **NotificationService** together with a Notification Component using component-level providers to demonstrate Angular's hierarchical dependency injection and the creation of isolated service instances.

---

# Expected Output

After successfully completing this hands-on, the application should:

- Display course data using the shared CourseService.
- Show the total number of available courses in both the Home page and Course Summary Widget.
- Allow users to enroll and unenroll from courses.
- Update the Enroll button dynamically based on enrollment status.
- Display all enrolled courses inside the Student Profile page.
- Demonstrate service-to-service dependency injection using EnrollmentService and CourseService.
- Demonstrate component-level dependency injection using NotificationService.
- Share application state using Angular's singleton service pattern.

---

# Output

## Task 1 – Course Service

<img width="1918" height="1030" alt="Task1_Course_Service" src="https://github.com/user-attachments/assets/853e1fac-5e9f-46a0-86bd-58a04468049d" />

---

## Task 2 – Enrollment System

<img width="1919" height="1034" alt="Task2_EnrollementServicde" src="https://github.com/user-attachments/assets/e36df577-72b9-413c-beed-f97d7470df66" />


---

## Task 2 – Student Profile (Enrolled Courses)
<img width="1919" height="1031" alt="Task2_Enrolled_Courses" src="https://github.com/user-attachments/assets/2b97a10f-72d9-4ef2-89db-eb601be29aec" />


---

## Task 2 – Notification Service

<img width="1919" height="1079" alt="Task3Notification_Service" src="https://github.com/user-attachments/assets/e7501448-abdf-4c13-873d-af4487e3d382" />


---

# Conclusion

Through this hands-on, I gained practical experience with Angular Services and Dependency Injection by implementing shared application services for the Student Course Portal. I learned how singleton services created with `providedIn: 'root'` allow multiple components to share the same application state, while component-level providers create isolated service instances. I also implemented service-to-service dependency injection, centralized business logic inside reusable services, and developed an enrollment management system that dynamically updated multiple components. This hands-on strengthened my understanding of Angular's dependency injection architecture and demonstrated how services improve modularity, maintainability, and scalability in modern Angular applications.
