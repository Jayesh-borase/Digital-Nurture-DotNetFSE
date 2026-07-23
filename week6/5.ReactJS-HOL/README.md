# React Hands-On 5 – Styling React Components using CSS Modules

## Objective

- Understand the need for styling React components.
- Apply styles using CSS Modules.
- Use `className` and inline styles in React components.

---

## Prerequisites

- Node.js
- NPM
- Visual Studio Code

---

## Project Name

**cohortstracker**

---

## Implementation

### Step 1 – Restore Project Dependencies

Install all required packages.

```bash
npm install
```

---

### Step 2 – Run the React Application

Start the development server.

```bash
npm start
```

---

### Step 3 – Create CSS Module

Created a CSS Module file named:

```
CohortDetails.module.css
```

Defined the `.box` class with:

- Width: 300px
- Display: inline-block
- Margin: 10px
- Padding: 10px 20px
- Border: 1px solid black
- Border Radius: 10px

Also styled the `<dt>` element using a tag selector.

---

### Step 4 – Import CSS Module

Imported the CSS module into the `CohortDetails` component.

```javascript
import styles from "./CohortDetails.module.css";
```

---

### Step 5 – Apply CSS Module

Applied the `box` class to the container using:

```jsx
<div className={styles.box}>
```

---

### Step 6 – Apply Conditional Styling

Applied inline styling to the `<h3>` element.

- Green color for **Ongoing** cohorts.
- Blue color for all other cohort statuses.

Example:

```jsx
<h3 style={{ color: status === "Ongoing" ? "green" : "blue" }}>
```

---

## Output

### Final Styled React Application

![alt text](CohortDetails.png)

