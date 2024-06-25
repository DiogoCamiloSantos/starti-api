FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

COPY ["starti-api.csproj", "./"]
RUN dotnet restore

COPY . .

RUN dotnet build -c Release -o /app/build
RUN dotnet publish "starti-api.csproj" -c Release -o /app/publish --runtime linux-x64 --self-contained false

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .

EXPOSE 80

ENV ASPNETCORE_HTTP_PORTS=80

ENTRYPOINT ["dotnet", "starti-api.dll"]