FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS builder
WORKDIR /sln

COPY ./LibraryManager.Api/LibraryManager.Api.csproj ./LibraryManager.Api/LibraryManager.Api.csproj
COPY ./LibraryManager.Domain/LibraryManager.Domain.csproj ./LibraryManager.Domain/LibraryManager.Domain.csproj
COPY ./LibraryManager.Infrastructure/LibraryManager.Infrastructure.csproj ./LibraryManager.Infrastructure/LibraryManager.Infrastructure.csproj
RUN dotnet restore "LibraryManager.Api/LibraryManager.Api.csproj"

COPY . .
RUN dotnet build -c Release --no-restore

RUN dotnet publish "./LibraryManager/LibraryManager.Api/LibraryManager.Api.csproj" -c Release -o /../../dist --no-restore

FROM mcr.microsoft.com/dotnet/core/sdk:3.1
WORKDIR /app
ENV ASPNETCORE_ENVIRONMENT Local
ENTRYPOINT ["dotnet", "LibraryManager.Api.dll"]
COPY --from=builder /sln/dist .
