# password-manager

This is an **early-stage** password manager built with a **microservices architecture** using .NET 9 with:
- YARP (Reverse Proxy)
- Blazor (frontend)
- ASP.NET (backend)
- SQL Server

## Project Structure

```plaintext
password-manager/
├── api-gateway/            # API Gateway (YARP)
├── backend/
│   ├── auth-service/       # Auth Management
│   ├── user-service/       # Users Management
│   └── vault-service/      # Secrets Management
├── frontend/               # Blazor WebAssembly
├── start-all.bat           # Windows script
└── README.md
```

## Prerequisites

- .NET 9 SDK
- SQL Server (local or remote)

## Getting Started

On Windows:

```
dotnet build
.\start-all.bat
```

## Endpoints

### API Gateway

- API Gateway base URL: `http://localhost:5000` or `https://localhost:7000`
- Auth Service: `/api/auth`
- User Service: `/api/user`
- Vault Service: `/api/vault`

### Frontend

- Frontend base URL: `http://localhost:5080` or `https://localhost:7443`

## Postman

You can use Postman to test the API endpoints. Import the `postman_collection.json` file to get started with the predefined requests.