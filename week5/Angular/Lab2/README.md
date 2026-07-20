# Angular Hands-On 2 – Data Binding, Lifecycle Hooks & Component Communication

## Objective

The objective of this hands-on was to enhance the **Student Course Portal** application by implementing Angular's data binding techniques, lifecycle hooks, and parent-child component communication. During this exercise, I learned how to use interpolation, property binding, event binding, and two-way data binding to create dynamic user interfaces. I also implemented Angular lifecycle hooks such as **ngOnInit**, **ngOnChanges**, and **ngOnDestroy** to understand the lifecycle of a component. Finally, I established communication between parent and child components using **@Input**, **@Output**, and **EventEmitter**.

---

# Project Structure

```text
2.Angular_Handson
│
├── student-course-portal
│   ├── src
│   │   ├── app
│   │   │
│   │   ├── app.config.ts
│   │   ├── app.css
│   │   ├── app.html
│   │   ├── app.routes.ts
│   │   ├── app.spec.ts
│   │   ├── app.ts
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
│   │   └── pages
│   │       ├── home
│   │       │   ├── home.ts
│   │       │   ├── home.html
│   │       │   ├── home.css
│   │       │   └── home.spec.ts
│   │       │
│   │       ├── course-list
│   │       │   ├── course-list.ts
│   │       │   ├── course-list.html
│   │       │   ├── course-list.css
│   │       │   └── course-list.spec.ts
│   │       │
│   │       └── student-profile
│   │           ├── student-profile.ts
│   │           ├── student-profile.html
│   │           ├── student-profile.css
│   │           └── student-profile.spec.ts
│   │
│   ├── assets
│   ├── index.html
│   ├── main.ts
│   └── styles.css
│
├── angular.json
├── package.json
├── tsconfig.json
│
├── Screenshots
│
└── README.md
```

---

# Task 1 – All Four Binding Types

## Steps Performed

- I modified the **Home** component to display dynamic data instead of hardcoded values.
- I declared a **portalName** property and displayed it using Angular **string interpolation**.
- I created an **isPortalActive** property and used **property binding** to enable or disable the **Enroll Now** button.
- I implemented the **onEnrollClick()** method and connected it using **event binding** so that clicking the button displays a confirmation message.
- I added a search input field and implemented **two-way data binding** using **[(ngModel)]**.
- I imported **FormsModule** into the standalone Home component to enable **ngModel**.
- I added comments explaining the difference between **property binding** and **two-way binding**.
- I verified that interpolation, property binding, event binding, and two-way binding worked successfully.

---

# Task 2 – Lifecycle Hooks

## Steps Performed

- I implemented the **ngOnInit** lifecycle hook inside the Home component.
- I simulated loading the available course count during component initialization.
- I logged the message **"HomeComponent initialized — courses loaded"** to the browser console.
- I implemented the **ngOnDestroy** lifecycle hook to observe when the component is destroyed.
- I logged **"HomeComponent destroyed"** whenever the user navigated away from the Home page.
- I generated a reusable **CourseCard** component using Angular CLI.
- I added an **@Input()** property to receive course data from the parent component.
- I implemented the **ngOnChanges** lifecycle hook and logged both previous and current values whenever the course input changed.
- I rendered multiple Course Card components and verified that **ngOnChanges()** executed for each component instance.

---

# Task 3 – Parent-Child Communication Using @Input and @Output

## Steps Performed

- I created a strongly typed **course** object containing **id**, **name**, **code**, and **credits**.
- I displayed all course information inside the **Course Card** component.
- I implemented an **@Output()** property using **EventEmitter<number>**.
- I added an **Enroll** button to every Course Card component.
- When the Enroll button was clicked, the selected course ID was emitted from the child component to the parent component.
- Inside the **Course List** component, I created an array containing **five different course objects**.
- I displayed all course cards dynamically using the **\*ngFor** structural directive.
- I implemented the **onEnroll()** method to receive the selected course ID.
- I displayed the selected course ID below the course list.
- I logged the enrollment message to the browser console.
- I verified successful parent-child communication using **@Input**, **@Output**, and **EventEmitter**.

---

# Expected Output

After completing this hands-on, the Student Course Portal application should:

- Display dynamic content using Angular interpolation.
- Enable and disable the Enroll button using property binding.
- Display a confirmation message using event binding.
- Update the search text instantly using two-way binding.
- Execute **ngOnInit**, **ngOnDestroy**, and **ngOnChanges** during the appropriate lifecycle stages.
- Display multiple Course Card components dynamically.
- Pass course information from the parent component to the child component using **@Input**.
- Send enrollment events from the child component back to the parent component using **@Output** and **EventEmitter**.
- Display the selected course ID after clicking the Enroll button.
- Log lifecycle events and enrollment actions in the browser console.

---

# Output

## Task 1 – Data Binding

<img width="1919" height="1079" alt="task1_dataBinding" src="https://github.com/user-attachments/assets/94fa5908-8ded-43c9-ac0e-2f4ea42cb493" />


---

## Task 2 – Home Component Initialization

<img width="1919" height="1077" alt="task2_Home_Initilization" src="https://github.com/user-attachments/assets/5d496668-1c47-40d9-bf6e-dc492ad983d6" />



---

## Task 2 – Lifecycle Hooks

<img width="1919" height="1079" alt="task2_lifecycle_console" src="https://github.com/user-attachments/assets/cca372d3-5491-41ff-80fb-afc99b697156" />


---

## Task 3 – Parent Child Communication

<img width="1919" height="1078" alt="task3_Parent_childcommunication" src="https://github.com/user-attachments/assets/c4af6e8a-533d-474a-a7c4-7a59c7154019" />


---

# Result

Successfully enhanced the **Student Course Portal** application by implementing Angular data binding techniques, lifecycle hooks, and parent-child communication. The application now supports dynamic UI updates, component lifecycle monitoring, reusable child components, and event-based communication between components using **@Input**, **@Output**, and **EventEmitter**.

---

# Conclusion

In this hands-on, I successfully transformed the Student Course Portal into a dynamic Angular application by implementing all four data binding techniques, Angular lifecycle hooks, and parent-child component communication. I learned how Angular updates the user interface through data binding, how lifecycle hooks execute during different stages of a component's lifecycle, and how components communicate using **@Input**, **@Output**, and **EventEmitter**. This exercise strengthened my understanding of Angular component interaction and provided a solid foundation for developing scalable and maintainable Angular applications.
