# Question 3: Add Role-Based Authorization

## Objective

The objective of this hands-on is to implement Role-Based Authorization in an ASP.NET Core Web API using JWT (JSON Web Token). The application demonstrates how to include user roles inside JWT claims and restrict access to specific API endpoints using the `[Authorize(Roles = "Admin")]` attribute.

---

## Project Structure

```
3.Role_Based_Authorization
│
├── SecureApi
│   ├── Controllers
│   │   ├── AuthController.cs
│   │   ├── SecureController.cs
│   │   └── AdminController.cs
│   ├── Models
│   │   └── LoginModel.cs
│   ├── Program.cs
│   ├── appsettings.json
│   └── SecureApi.csproj
│

```

---

## Steps Performed

**Step 1**

Used the existing ASP.NET Core Web API project with JWT Authentication.

**Step 2**

Modified the JWT token generation by adding the **Admin** role inside the JWT claims.

```csharp
var claims = new[]
{
    new Claim(ClaimTypes.Name, username),
    new Claim(ClaimTypes.Role, "Admin")
};
```

**Step 3**

Created a new controller named **AdminController**.

**Step 4**

Protected the Admin endpoint using the **[Authorize(Roles = "Admin")]** attribute.

```csharp
[Authorize(Roles = "Admin")]
```

**Step 5**

Generated a JWT token by calling the Login endpoint.

**Step 6**

Copied the generated JWT token.

**Step 7**

Used the generated JWT token as a **Bearer Token** in Postman.

**Step 8**

Successfully accessed the protected Admin endpoint using the generated JWT token.

---

# API Endpoints

## Login Endpoint

**POST**

```
/api/Auth/login
```

### Request Body

```json
{
  "username": "admin",
  "password": "admin123"
}
```

### Successful Response

```json
{
  "token": "<Generated JWT Token>"
}
```

---

## Admin Dashboard Endpoint

**GET**

```
/api/Admin/dashboard
```

### Authorization Header

```
Authorization: Bearer <Generated JWT Token>
```

### Successful Response

```text
Welcome to the admin dashboard.
```

---

# Expected Output

- JWT token is generated successfully after login.
- The generated JWT contains the **Admin** role claim.
- The Admin Dashboard endpoint is accessible only to users having the **Admin** role.
- Unauthorized users are denied access to the protected endpoint.

---

# Output

### JWT Token Generation

<img width="1919" height="1079" alt="postman_admin_token" src="https://github.com/user-attachments/assets/b7b2dc48-536a-4fc3-a7de-3b8d52186f3e" />


---

### Accessing Admin Dashboard Using JWT Token

<img width="1919" height="1079" alt="admin_role_sucess" src="https://github.com/user-attachments/assets/1876b715-18aa-4f72-acb6-738dc1398108" />


---

# Learning Outcomes

- Implemented Role-Based Authorization using JWT.
- Added role information inside JWT claims.
- Protected API endpoints using the **[Authorize(Roles = "Admin")]** attribute.
- Generated JWT tokens containing role information.
- Accessed protected API endpoints using Bearer Token authentication.
- Tested secured endpoints using Postman.

---

# Result

Successfully implemented Role-Based Authorization in an ASP.NET Core Web API using JWT Authentication. The JWT token was generated with the **Admin** role claim, and access to the Admin Dashboard endpoint was successfully restricted using the **[Authorize(Roles = "Admin")]** attribute. The protected endpoint was verified successfully using Postman with a valid Bearer Token.
