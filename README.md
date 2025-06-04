# password-manager

This is an **early-stage** password manager built with a **microservices architecture** using .NET 9 with:
- YARP (Reverse Proxy)
- Blazor (frontend)
- ASP.NET (backend)
- SQLite

## Project Structure

```plaintext
password-manager/
├── api-gateway/            # API Gateway (YARP)
├── backend/
│   ├── user-service/       # Users Management
│   └── vault-service/      # Secrets Management
├── frontend/               # Blazor WebAssembly
├── start-all.bat           # Windows script
└── README.md
```

## Prerequisites

- .NET 9 SDK

## Getting Started

On Windows:

```
dotnet build
.\start-all.bat
```

## Endpoints

- API Gateway base URL: `http://localhost:80` or `https://localhost:443`
- Frontend base URL: `http://localhost:3000`
- User Service: `http://localhost:5000/api/user`
- Vault Service: `http://localhost:5001/api/vault`