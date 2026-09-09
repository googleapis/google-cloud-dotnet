# Use Microsoft's official build .NET image.
# https://hub.docker.com/_/microsoft-dotnet-core-sdk/
FROM mcr.microsoft.com/dotnet/sdk:8.0@sha256:5ef85cc12cb25be6ec319a7392d1e9efd53c3bc8abb971c53d8058a473f09053 AS build
WORKDIR /app

# Install production dependencies.
# Copy csproj and restore as distinct layers.
RUN mkdir Google.Cloud.Logging.Console && mkdir SampleApp
COPY Google.Cloud.Logging.Console/*.csproj Google.Cloud.Logging.Console/
COPY SampleApp/*.csproj SampleApp/
RUN dotnet restore SampleApp

# Copy local code to the container image.
COPY Google.Cloud.Logging.Console Google.Cloud.Logging.Console/
COPY SampleApp SampleApp/
WORKDIR /app

# Build a release artifact.
RUN dotnet publish -c Release -o /app/out SampleApp

# Use Microsoft's official runtime .NET image.
# https://hub.docker.com/_/microsoft-dotnet-core-aspnet/
FROM mcr.microsoft.com/dotnet/aspnet:8.0@sha256:9a464e9a7e8c6144631020975f703c89034fe386417cb740620df69c2c6cfe24 AS runtime
WORKDIR /app
COPY --from=build /app/out ./

# Run the web service on container startup.
ENTRYPOINT ["dotnet", "SampleApp.dll"]
