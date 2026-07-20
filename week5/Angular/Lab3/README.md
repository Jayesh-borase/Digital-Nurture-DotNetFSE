# Angular Hands-On 3 – Directives & Pipes (Built-in and Custom)

## Objective

The objective of this hands-on was to understand how Angular Directives and Pipes improve the functionality and presentation of an application. During this exercise, I implemented Angular's built-in structural directives, attribute directives, a reusable custom attribute directive, and a custom pipe in the **Student Course Portal** application. I learned how directives dynamically control the DOM, how styles can be applied conditionally, and how pipes transform data into user-friendly formats.

---

# Project Structure

```text
student-course-portal
│
├── src
│   ├── app
│   │   │
│   │   ├── app.config.ts
│   │   ├── app.routes.ts
│   │   ├── app.ts
│   │   ├── app.html
│   │   ├── app.css
│   │   │
│   │   ├── components
│   │   │   ├── header
│   │   │   │   ├── header.ts
│   │   │   │   ├── header.html
│   │   │   │   ├── header.css
│   │   │   │   └── header.spec.ts
│   │   │   │
│   │   │   └── course-card
│   │   │       ├── course-card.ts
│   │   │       ├── course-card.html
│   │   │       ├── course-card.css
│   │   │       └── course-card.spec.ts
│   │   │
│   │   ├── directives
│   │   │   ├── highlight.ts
│   │   │   └── highlight.spec.ts
│   │   │
│   │   ├── pages
│   │   │   ├── home
│   │   │   ├── course-list
│   │   │   └── student-profile
│   │   │
│   │   └── pipes
│   │       ├── credit-label-pipe.ts
│   │       └── credit-label-pipe.spec.ts
│   │
│   ├── index.html
│   ├── main.ts
│   └── styles.css
│
├── angular.json
├── package.json
├── tsconfig.json
└── README.md
```

---

# Task 1: Structural Directives

### Steps Performed

- Implemented the **`*ngIf`** directive to display a loading message while course data was being loaded.
- Simulated loading using `setTimeout()` for **1.5 seconds** before displaying the courses.
- Rendered all course cards dynamically using the **`*ngFor`** directive.
- Implemented the **`trackByCourseId()`** function to improve rendering performance by preventing unnecessary DOM recreation.
- Added a **gradeStatus** property to every course object.
- Used the **`*ngSwitch`** directive to display different badges for **Passed**, **Failed**, and **Pending** courses.
- Implemented an **else block** using `ng-template` to display a "No courses available" message when the course list becomes empty.

---

# Task 2: Attribute Directives

### Steps Performed

- Used **`ngClass`** to dynamically apply CSS classes based on the enrollment status and course credits.
- Applied the **`card--enrolled`** class when a student enrolled in a course.
- Applied the **`card--full`** class when course credits were greater than or equal to four.
- Used **`ngStyle`** to dynamically change the left border color according to the course grade status.
- Implemented a **Show Details** button that expands and collapses each course card.
- Used a getter method (**cardClasses**) to keep the template clean and improve code readability.

---

# Task 3: Custom Directive and Custom Pipe

### Steps Performed

- Generated a reusable custom attribute directive named **Highlight**.
- Used **`@HostListener`** to detect **mouseenter** and **mouseleave** events.
- Changed the background color of the course card while hovering over it.
- Added an **`@Input()`** property to make the highlight color configurable.
- Applied the directive to all course cards and verified the hover effect.
- Generated a custom pipe named **CreditLabelPipe**.
- Implemented the **PipeTransform** interface.
- Converted numeric credit values into user-friendly labels:
  - **1 → 1 Credit**
  - **2 or more → X Credits**
  - **0 or null → No Credits**
- Displayed the transformed credit labels inside every course card.

---

# Expected Output

After completing this hands-on, the Student Course Portal application should:

- Display a loading message before rendering the course list.
- Render course cards dynamically using **`*ngFor`**.
- Display different grade badges using **`*ngSwitch`**.
- Apply conditional CSS classes using **`ngClass`**.
- Apply dynamic border colors using **`ngStyle`**.
- Expand and collapse course cards using the **Show Details** button.
- Highlight course cards on mouse hover using the custom **Highlight Directive**.
- Display user-friendly credit labels using the custom **Credit Label Pipe**.
- Display the selected course ID after clicking the **Enroll** button.

---

# Output

## Task 1 – Structural Directives

> **Screenshot 1:** Loading State and Structural Directives

<img width="1919" height="1079" alt="task1_LoadingState" src="https://github.com/user-attachments/assets/3ffce39a-3042-4b32-9464-69ad5c3e1566" />
<img width="1919" height="1079" alt="task1_Structured_Directives" src="https://github.com/user-attachments/assets/46c6d159-87d8-445c-9606-03e76efb6954" />


---

## Task 2 – Attribute Directives

> **Screenshot 2:** ngClass and ngStyle Applied

<img width="1919" height="1079" alt="task2_Atrribute_Directives" src="https://github.com/user-attachments/assets/7ca7f7e5-1601-440c-909a-4cb87646b152" />

---

## Task 3 – Highlight Directive

> **Screenshot 3:** Hover Effect using Custom Highlight Directive

<img width="1919" height="1079" alt="task3_Highlight_Directives" src="https://github.com/user-attachments/assets/e2fe1802-a720-48e5-afec-8072ae5b479b" />

---

## Task 3 – Custom Credit Label Pipe

> **Screenshot 4:** Credit Label Pipe Output

<img width="1917" height="1079" alt="task3_CustomDir_And_CustomPipe" src="https://github.com/user-attachments/assets/38bc42c2-4fd1-495b-a2d6-9c40aee5937b" />

---

# Conclusion

In this hands-on, I successfully implemented Angular's built-in and custom directives and pipes within the **Student Course Portal** application. I learned how structural directives dynamically create and remove DOM elements, how attribute directives apply conditional styling, how custom directives encapsulate reusable behavior, and how custom pipes transform data into readable formats. This exercise strengthened my understanding of Angular templates, reusable components, and best practices for building clean, scalable, and maintainable Angular applications.
