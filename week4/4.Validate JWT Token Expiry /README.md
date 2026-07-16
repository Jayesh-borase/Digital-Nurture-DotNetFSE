# Question 4: Validate JWT Token Expiry and Handle Unauthorized Access

## Objective

The objective of this hands-on is to validate JWT token expiration and handle unauthorized access gracefully in an ASP.NET Core Web API. The application demonstrates how to configure JWT Bearer events to detect expired tokens and return a custom response header indicating that the JWT token has expired.

---

## Project Structure

```
4.JWT_Token_Expiry
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
└── README.md
```

---

## Steps Performed

**Step 1**

Used the existing ASP.NET Core Web API project with JWT Authentication and Role-Based Authorization.

**Step 2**

Configured JWT Bearer Events inside **Program.cs** to detect expired JWT tokens.

```csharp
options.Events = new JwtBearerEvents
{
    OnAuthenticationFailed = context =>
    {
        if (context.Exception.GetType() == typeof(SecurityTokenExpiredException))
        {
            context.Response.Headers.Add("Token-Expired", "true");
        }

        return Task.CompletedTask;
    }
};
```

**Step 3**

Modified the JWT token expiration time in **AuthController.cs** from 60 minutes to 1 minute for testing.

**Step 4**

Generated a new JWT token using the Login endpoint.

**Step 5**

Used the generated JWT token as a Bearer Token in Postman to access the protected Admin Dashboard endpoint successfully.

**Step 6**

Waited until the JWT token expired.

**Step 7**

Sent the same request again using the expired JWT token.

**Step 8**

Verified that the API returned **401 Unauthorized** and included the **Token-Expired: true** response header.

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

## Protected Admin Endpoint

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
- Protected endpoint is accessible using a valid JWT token.
- Expired JWT tokens are rejected with **401 Unauthorized**.
- The response contains the **Token-Expired: true** header when the JWT token has expired.

---

# Output

### JWT Token Generation

<img width="1919" height="1078" alt="token_generation" src="https://github.com/user-attachments/assets/d4c4f20b-01c0-4c37-964e-0cec4240c6ea" />


---

### Successful Access to Admin Dashboard

<img width="1919" height="1079" alt="admin_token_sucess" src="https://github.com/user-attachments/assets/f9654a03-24a5-45a1-a7c7-a0b2305813df" />


---

### Expired JWT Token (401 Unauthorized)

<img width="1917" height="1077" alt="token_expire" src="https://github.com/user-attachments/assets/2365e37b-3308-4947-9e82-c81e79656727" />


---

# Learning Outcomes

- Implemented JWT token expiration validation.
- Configured JWT Bearer Events in ASP.NET Core Web API.
- Detected expired JWT tokens using `OnAuthenticationFailed`.
- Returned a custom response header for expired tokens.
- Secured API endpoints using JWT Authentication and Role-Based Authorization.
- Tested token generation, successful authorization, and token expiration using Postman.

---

# Result

Successfully implemented JWT token expiration validation and custom unauthorized handling in an ASP.NET Core Web API. The application generated JWT tokens, authenticated authorized users, detected expired tokens using JWT Bearer Events, and returned **401 Unauthorized** along with the **Token-Expired: true** response header after token expiration. All objectives specified in the hands-on were completed successfully.
