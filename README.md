## Bolero

```bash
dotnet new -i Bolero.Templates
dotnet new bolero-app -o . --force
dotnet run --project src/HelloBolero.Server/HelloBolero.Server.fsproj
dotnet watch --project src/HelloBolero.Server/HelloBolero.Server.fsproj run
``