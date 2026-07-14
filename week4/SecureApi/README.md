# Question 2: Secure an API Endpoint Using JWT

## Objective

The objective of this hands-on is to secure an ASP.NET Core Web API endpoint using JWT (JSON Web Token) authentication. The API allows only authenticated users with a valid JWT token to access protected resources using the `[Authorize]` attribute.

---

## Project Structure

```
2.Secure_JWT_API
│
├── SecureApi
│   ├── Controllers
│   │   ├── AuthController.cs
│   │   └── SecureController.cs
│   ├── Models
│   │   └── LoginModel.cs
│   ├── Program.cs
│   ├── appsettings.json
│   └── SecureApi.csproj
│
├── Screenshots
│   ├── login_success_token.png
│   └── secure_data_response.png
│
└── README.md
```

---

## Steps Performed

**Step 1**

Created a new ASP.NET Core Web API project named **SecureApi**.

**Step 2**

Installed the following NuGet packages:

- Microsoft.AspNetCore.Authentication.JwtBearer
- Swashbuckle.AspNetCore

**Step 3**

Created the **LoginModel** class to accept the username and password from the client.

**Step 4**

Configured JWT settings in **appsettings.json** by specifying:

- Secret Key
- Issuer
- Audience
- Token Expiration Duration

**Step 5**

Configured JWT Authentication and Authorization in **Program.cs**.

**Step 6**

Created **AuthController** with a **POST /api/Auth/login** endpoint to authenticate the user and generate a JWT token.

**Step 7**

Implemented user validation using hardcoded credentials:

- Username: **admin**
- Password: **admin123**

**Step 8**

Created **SecureController** containing a protected endpoint **GET /api/Secure/data** secured using the **[Authorize]** attribute.

**Step 9**

Tested the Login endpoint using Postman and generated a JWT token.

**Step 10**

Passed the generated JWT token as a Bearer Token in Postman and successfully accessed the protected endpoint.

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

## Protected Endpoint

**GET**

```
/api/Secure/data
```

### Authorization Header

```
Authorization: Bearer <Generated JWT Token>
```

### Successful Response

```text
This is protected data.
```

---

# Expected Output

- User successfully logs in with valid credentials.
- JWT token is generated successfully.
- Protected endpoint is accessible only with a valid JWT token.
- Requests without a valid token return **401 Unauthorized**.

---

# Output

### Successful Login and JWT Token Generation

<img width="1857" height="1045" alt="postman_token_generation" src="https://github.com/user-attachments/assets/5e8d7723-ab6c-4046-9a6d-119c2dce4445" />

---

### Successfully Accessing Protected Endpoint Using JWT

<img width="1919" height="1079" alt="postman_authorize" src="https://github.com/user-attachments/assets/cbeecfb8-f754-4f1c-b9b9-77040a764a20" />


---

# Result

Successfully implemented JWT Authentication and Authorization in an ASP.NET Core Web API. The application generates a JWT token after successful login and protects API endpoints using the **[Authorize]** attribute. Only authenticated users with a valid JWT token can access the secured API endpoint.
