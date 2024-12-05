# Use the official .NET SDK image
FROM mcr.microsoft.com/dotnet/sdk:8.0

# Set working directory
WORKDIR /app

# Copy the project files
COPY . .

# Restore the dependencies
RUN dotnet restore

# Build the project
RUN dotnet build --configuration Release

# Pack the project into a NuGet package
RUN dotnet pack --configuration Release --output ./nupkg
