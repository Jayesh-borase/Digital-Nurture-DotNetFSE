# Hands-On 1 – Creating Your First React Application

## Objective

The objective of this hands-on is to create and run a React application using Create React App and display a simple welcome message.

---

# Prerequisites

- Node.js
- npm (Node Package Manager)
- Visual Studio Code

---

# Implementation

## Task 1 – Create a React Application

Created a new React application named **react_handson** using the following command:

```bash
npx create-react-app react_handson
```

---

## Task 2 – Navigate to the Project Folder

```bash
cd react_handson
```

---

## Task 3 – Open the Project in Visual Studio Code

```bash
code .
```

---

## Task 4 – Modify App.js

Replaced the existing code in **App.js** with the following:

```jsx
function App() {
  return (
    <div>
      <h1>Welcome to the First Session of React</h1>
    </div>
  );
}

export default App;
```

---

## Task 5 – Run the React Application

Executed the application using:

```bash
npm start
```

---

## Task 6 – View the Output

Opened the browser and navigated to:

```
http://localhost:3000
```

The application displayed:

**Welcome to the First Session of React**

---

# Output

### Welcome Page

Welcome to the First Session of React

---

# Conclusion

Through this hands-on, I learned how to create a React application using Create React App, open it in Visual Studio Code, modify the default component, and run the application successfully using the React development server.