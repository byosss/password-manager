@echo off
start dotnet run --project api-gateway
start dotnet run --project backend/user-service
start dotnet run --project backend/vault-service
start dotnet run --project frontend
