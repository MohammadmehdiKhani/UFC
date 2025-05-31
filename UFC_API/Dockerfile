FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app
COPY . .
RUN dotnet restore UFC_API.sln
RUN dotnet build UFC_API/UFC_API.csproj -c Release --no-restore
RUN dotnet publish UFC_API/UFC_API.csproj -c Release -o /app/out --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/out .
EXPOSE 8080
ENTRYPOINT ["dotnet", "UFC_API.dll"]
