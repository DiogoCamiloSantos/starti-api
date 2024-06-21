# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy and restore project files
COPY ["starti-api.csproj", "./"]
RUN dotnet restore

# Copy the rest of the application files
COPY . .

# Build and publish the application
RUN dotnet build -c Release -o /app/build
RUN dotnet publish "starti-api.csproj" -c Release -o /app/publish --runtime linux-x64 --self-contained false

# Stage 2: Run
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "starti-api.dll"]
