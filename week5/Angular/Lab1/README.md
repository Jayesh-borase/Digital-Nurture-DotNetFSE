# Hands-On 1 – Environment Setup, Project Structure & First Component

## Objective

The objective of this hands-on is to set up the Angular development environment, create a new Angular application using Angular CLI, understand the generated project structure, and create the first Angular components for the Student Course Portal. The application demonstrates the basics of Angular project creation, component generation, routing, and application execution.

---

## Project Structure

```
1.Angular_Handson
│
├── student-course-portal
│   ├── src
│   │   ├── app
│   │   │   ├── components
│   │   │   │   └── header
│   │   │   ├── pages
│   │   │   │   ├── home
│   │   │   │   ├── course-list
│   │   │   │   └── student-profile
│   │   │   ├── app.ts
│   │   │   ├── app.html
│   │   │   ├── app.css
│   │   │   ├── app.config.ts
│   │   │   └── app.routes.ts
│   │   │
│   │   ├── index.html
│   │   ├── main.ts
│   │   └── styles.css
│   │
│   ├── angular.json
│   ├── package.json
│   ├── tsconfig.json
│   ├── tsconfig.app.json
│   └── notes.txt
│
├── Screenshots
│
└── README.md
```

---

# Task 1 – Environment Setup & Project Structure

## Step 1

Installed Angular CLI globally using npm.

```bash
npm install -g @angular/cli
```

---

## Step 2

Created a new Angular project named **student-course-portal** with routing and CSS support.

```bash
ng new student-course-portal --routing --style=css
```

---

## Step 3

Opened the project in Visual Studio Code and studied the generated project structure.

Created a **notes.txt** file explaining the purpose of the following files:

- angular.json
- tsconfig.json
- tsconfig.app.json
- package.json
- src/main.ts
- src/app/app.config.ts
- src/app/app.ts
- src/index.html

---

## Step 4

Executed the Angular application using:

```bash
ng serve
```

Verified that the default Angular welcome page loaded successfully in the browser.

---

## Step 5

Built the application using:

```bash
ng build
```

Verified that the **dist** folder was created successfully containing the compiled Angular application.

Also verified the **budgets** configuration inside **angular.json**.

---

# Task 2 – Create and Organize Components

## Step 6

Generated the following components using Angular CLI.

```bash
ng generate component components/header

ng generate component pages/home

ng generate component pages/course-list

ng generate component pages/student-profile
```

Each generated component contained the following files:

- component.ts
- component.html
- component.css
- component.spec.ts

---

## Step 7

Modified the **HeaderComponent** to display the portal title and navigation links.

Navigation links added:

- Home
- Courses
- Profile

---

## Step 8

Modified the **HomeComponent** to display:

- Welcome heading
- Portal description
- Hardcoded statistics

Statistics displayed:

- Courses Available : 12
- Enrolled : 3
- GPA : 3.8

---

## Step 9

Updated the root application component to include:

- Header Component
- Router Outlet

---

## Step 10

Configured routing so that the Home component is displayed when the application starts.

Verified that the application compiled successfully without any errors.

---

# Screenshots

## Task 1

### Angular Project Creation

![alt text](angular_application_created.png)

---

### Angular Default Welcome Page

![alt text](Welcome_Page.png)

---

### Angular Application Build (Compiled Code)

![alt text](compiled_code.png)

---

## Task 2

### Student Course Portal Home Page

![alt text](Home_Page.png)
---

# Concepts Demonstrated

- Angular CLI Installation
- Angular Workspace Creation
- Angular Project Structure
- Angular Routing
- Angular Standalone Components
- Angular Component Generation
- Angular Application Build
- Angular Development Server
- Router Outlet
- Header Component
- Home Component
- Navigation
- Project Compilation

---

# Result

Successfully installed Angular CLI and created the **Student Course Portal** application. Generated multiple Angular components, configured routing, built the application, and verified successful execution using the Angular development server. The header navigation and home page were displayed successfully, completing all objectives of Hands-On 1.