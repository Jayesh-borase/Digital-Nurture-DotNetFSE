# Hands-On 4: Template-Driven Forms & Validation

## Objective

The objective of this hands-on was to understand how Angular Template-Driven Forms are used to collect, validate, and process user input. I learned how Angular simplifies form development using the **ngForm** and **ngModel** directives while providing built-in validation support. I also implemented contextual validation messages, applied Angular's automatic validation state classes for styling, handled form submission, and reset the form after completion to create a complete Student Enrollment Request form.

---

# Project Structure

```
student-course-portal/
│
├── src/
│   └── app/
│       │
│       ├── components/
│       │   ├── header/
│       │   │   ├── header.ts
│       │   │   ├── header.html
│       │   │   ├── header.css
│       │   │   └── header.spec.ts
│       │   │
│       │   └── course-card/
│       │       ├── course-card.ts
│       │       ├── course-card.html
│       │       ├── course-card.css
│       │       └── course-card.spec.ts
│       │
│       ├── directives/
│       │   ├── highlight.ts
│       │   └── highlight.spec.ts
│       │
│       ├── pipes/
│       │   ├── credit-label-pipe.ts
│       │   └── credit-label-pipe.spec.ts
│       │
│       ├── pages/
│       │   ├── home/
│       │   ├── course-list/
│       │   ├── student-profile/
│       │   └── enrollment-form/
│       │       ├── enrollment-form.ts
│       │       ├── enrollment-form.html
│       │       ├── enrollment-form.css
│       │       └── enrollment-form.spec.ts
│       │
│       ├── app.ts
│       ├── app.html
│       ├── app.css
│       ├── app.routes.ts
│       └── app.config.ts
│
├── public/
├── angular.json
├── package.json
├── tsconfig.json
└── README.md
```

---

# Task 1: Build the Enrollment Request Form

In this task, I generated a new **EnrollmentFormComponent** and integrated it into the Student Course Portal by configuring a new **/enroll** route. I updated the navigation menu so users could access the enrollment page from anywhere within the application. I created a template-driven form using Angular's **ngForm** directive together with multiple **ngModel** bindings. The form collected the student's name, email address, course ID, preferred semester, and agreement to the terms and conditions through different input controls. I implemented an **onSubmit()** method that received the complete **NgForm** object, displayed the submitted values in the browser console, and verified the overall validity of the form. Finally, I disabled the **Submit** button whenever the form was invalid to prevent incomplete submissions.

---

# Task 2: Validation and Error Messages

In this task, I enhanced the enrollment form by implementing Angular's built-in validation features. I applied validation rules such as **required**, **minlength**, and **email** to the appropriate form controls. I created template reference variables using **ngModel** to access the validation state of each control and displayed meaningful validation messages whenever a user interacted with an invalid field. I styled valid and invalid controls using Angular's automatically generated CSS classes so that valid inputs displayed green borders while invalid inputs displayed red borders after being touched. I also implemented a success message that appeared after a successful form submission using a **submitted** boolean property together with the **\*ngIf** structural directive. Finally, I added a **Reset** button that cleared all user inputs, removed validation states, and restored the form to its original condition.

---

# Expected Output

After successfully completing this hands-on, the application should:

- Display the Student Enrollment Request Form on the **/enroll** page.
- Bind all form controls using Angular Template-Driven Forms and **ngModel**.
- Disable the **Submit** button whenever the form is invalid.
- Display contextual validation messages for invalid fields after user interaction.
- Display red borders for invalid controls and green borders for valid controls.
- Successfully submit the form and log the form values together with the validation status in the browser console.
- Display a success message after successful form submission.
- Reset all form fields and validation states when the **Reset** button is clicked.

---

# Output

## Task 1 – Enrollment Request Form

<img width="1919" height="1034" alt="tak1_EnrollementForm" src="https://github.com/user-attachments/assets/d017ac75-306a-47b2-9dae-0985f645ba99" />

---

## Task 2 – Validation Errors

<img width="1897" height="1022" alt="task2_ValidationErrors" src="https://github.com/user-attachments/assets/4b4d863c-d703-4dbc-97e3-f30af658e1b3" />

---

## Task 2 – Valid Form
<img width="1915" height="1029" alt="task2_ValidFomr" src="https://github.com/user-attachments/assets/adbdbb7f-92d5-47d3-88b3-931730c51e55" />


---

## Task 2 – Successful Form Submission

<img width="1916" height="1023" alt="task2_Submission_Sucess" src="https://github.com/user-attachments/assets/7d0b1392-dea5-4608-a3ed-02d8f073b644" />


---

# Conclusion

Through this hands-on, I gained practical experience in developing **Template-Driven Forms** using Angular. I learned how Angular automatically tracks the state of form controls, performs validation, and exposes validation information through the **ngForm** and **ngModel** directives. I also implemented contextual validation messages, visual feedback using Angular's built-in form state classes, form submission handling, and form resetting. This hands-on strengthened my understanding of Angular's template-driven approach to form development and demonstrated how robust user input validation can be implemented with minimal code while following industry best practices.
