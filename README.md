# Quark - .NET Microservices Example

Commands run to create from scratch

```bash
dotnet new sln --name Quark
mkdir src
mkdir tests
mkdir scripts
touch README.md
cd src/
dotnet new webapi -n Quark.API
dotnet new webapi -n Quark.Services.Identity
dotnet new webapi -n Quark.Services.Activities
dotnet new classlib -n Quark.Common
cd ..
dotnet add src/Quark.Services.Activities/Quark.Services.Activities.csproj reference src/Quark.Common/Quark.Common.csproj
dotnet add src/Quark.Services.Identity/Quark.Services.Identity.csproj reference src/Quark.Common/Quark.Common.csproj
dotnet add src/Quark.Identity/Quark.Identity.csproj reference src/Quark.Common/Quark.Common.csproj
dotnet add src/Quark.API/Quark.API.csproj reference src/Quark.Common/Quark.Common.csproj

dotnet sln add src/Quark.Services.Activities/Quark.Services.Activities.csproj
dotnet sln add src/Quark.Services.Identity/Quark.Services.Identity.csproj
dotnet sln add src/Quark.Common/Quark.Common.csproj
dotnet sln add src/Quark.API/Quark.API.csproj

dotnet restore
dotnet build
```