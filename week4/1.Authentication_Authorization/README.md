# Question 1: Implement JWT Authentication in ASP.NET Core Web API

## Objective

In this hands-on, I implemented JWT (JSON Web Token) based authentication in an ASP.NET Core Web API. The objective was to create a secure login endpoint that generates a JWT token after successful authentication and to protect API endpoints using the `[Authorize]` attribute.

---

## Project Structure

```text
1.Authentication_Authorization
│
├── JwtAuthenticationApi
│   ├── Controllers
│   │   └── AuthController.cs
│   ├── Models
│   │   └── LoginModel.cs
│   ├── Program.cs
│   ├── appsettings.json
│   └── JwtAuthenticationApi.csproj
│
├── Screenshots
│   ├── authorized_profile_postman.png
│   ├── login_success_token.jpeg
│   └── login_success_token.png
│
└── README.md
```

---

## Steps Performed

**Step 1**

Created a new ASP.NET Core Web API project named **JwtAuthenticationApi**.

**Step 2**

Installed the **Microsoft.AspNetCore.Authentication.JwtBearer** NuGet package to enable JWT authentication.

**Step 3**

Created a **LoginModel** class to receive the username and password from the client.

**Step 4**

Configured the JWT settings inside the **appsettings.json** file by specifying the secret key, issuer, audience, and token expiration duration.

**Step 5**

Configured JWT authentication and authorization in **Program.cs** so that the application validates incoming JWT tokens before allowing access to protected endpoints.

**Step 6**

Created an **AuthController** containing a login endpoint and a protected profile endpoint.

**Step 7**

Implemented user validation using hardcoded credentials (**admin / password**) for demonstration purposes.

**Step 8**

After successful authentication, generated a JWT token and returned it in the API response.

**Step 9**

Protected the **GET /api/Auth/profile** endpoint using the **[Authorize]** attribute.

**Step 10**

Tested the login endpoint using **Swagger UI** and verified that a JWT token was generated successfully.

**Step 11**

Used **Postman** to access the protected endpoint by passing the generated JWT token as a **Bearer Token** in the Authorization header.

---

## API Endpoints

### Login Endpoint

**Method**

```text
POST /api/Auth/login
```

### Sample Request

```json
{
  "username": "admin",
  "password": "password"
}
```

### Successful Response

```json
{
  "token": "<Generated JWT Token>"
}
```

---

### Protected Endpoint

**Method**

```text
GET /api/Auth/profile
```

### Authorization Header

```text
Authorization: Bearer <Generated JWT Token>
```

### Successful Response

```json
{
  "message": "You have successfully accessed a protected endpoint.",
  "username": "admin"
}
```

---

## Expected Output

- The application successfully authenticates the user when valid credentials are provided.
- A JWT token is generated after successful authentication.
- The protected endpoint can be accessed only by sending a valid JWT token in the Authorization header.
- Requests without a valid JWT token are denied access.

---

## Output

### Successful Login and JWT Token Generation

<img width="1919" height="1033" alt="login_sucess_token" src="https://github.com/user-attachments/assets/8e705c9c-6dd6-4974-9a96-a2c97f07cb34" />


### Successful Login Response

<img width="1918" height="1079" alt="sucess_token_postman" src="https://github.com/user-attachments/assets/aac4d2e1-b6aa-4fca-ae61-a72e5c62e3e0" />


### Accessing Protected Endpoint using JWT Token

<img width="1919" height="1079" alt="authorized_postman" src="https://github.com/user-attachments/assets/b28b6f61-48dd-4c1e-9bf8-790fffd2bda8" />


---

## Conclusion

In this hands-on, I successfully implemented JWT-based authentication in an ASP.NET Core Web API. I configured JWT authentication, generated tokens for authenticated users, and secured API endpoints using the `[Authorize]` attribute. I verified the implementation by testing the login endpoint in Swagger UI and accessing the protected endpoint through Postman using the generated JWT token. This exercise helped me understand how JWT authentication is implemented and used to secure ASP.NET Core Web API microservices.
