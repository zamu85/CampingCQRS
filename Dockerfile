FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /CampingCQRS

# copy csproj and restore as distinct layers
COPY CampingCQRS/*.sln .
COPY CampingCQRS/Camping/Camping.csproj ./Camping
COPY CampingCQRS/Application/Application.csproj ./Application
COPY CampingCQRS/Domain/Domain.csproj ./Domain
COPY CampingCQRS/Infrastructure/Infrastructure.csproj ./Infrastructure
COPY CampingCQRS/Persistence/Persistence.csproj ./Persistence
COPY CampingCQRS/Shared/Shared.csproj ./Shared

RUN dotnet restore CampingCQRS/Camping/Camping.csproj
RUN dotnet restore Application/Application.csproj
RUN dotnet restore Domain/Domain.csproj
RUN dotnet restore Infrastructure/Infrastructure.csproj
RUN dotnet restore Persistence/Persistence.csproj
RUN dotnet restore Shared/Shared.csproj


# copy everything else and build app
COPY CampingCQRS/. ./CampingCQRS
RUN dotnet publish -c Release -o /app --no-restore

# final stage/image
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app ./
ENTRYPOINT ["dotnet", "Camping.dll"]