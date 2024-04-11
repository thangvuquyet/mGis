# Use the official .NET 6 SDK image as a base image
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env

WORKDIR /app
COPY ./ ./
RUN dotnet restore src/mGISv3.Web.Host/mGISv3.Web.Host.csproj
RUN dotnet publish src/mGISv3.Web.Host/mGISv3.Web.Host.csproj -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build-env /app/out .
RUN apt-get update -y && apt-get install -y gss-ntlmssp libgdiplus

# Define the command to run the application
ENTRYPOINT ["dotnet", "mGISv3.Web.Host.dll"]