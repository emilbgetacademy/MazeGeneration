# Use the official Microsoft .NET SDK image as a base image
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS base_image

# Set the working directory to /app
WORKDIR /app

# Copy the .csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore

# Copy the remaining source code
COPY . ./

# Build the application
RUN dotnet publish -c Release -o out

# Build the runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=base_image /app/out .

# Set the entry point to your application
ENTRYPOINT ["dotnet", "MazeGeneration.dll"]
