# Use Microsoft's official build .NET image.
# https://hub.docker.com/_/microsoft-dotnet-core-sdk/
FROM mcr.microsoft.com/dotnet/sdk:8.0@sha256:1b955f179b02df4f0eb5fadedaa898cbe44d620a64aab52eec72c8e91d1355b5 AS build
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
FROM mcr.microsoft.com/dotnet/aspnet:8.0@sha256:dccacae9e0e103b5d3ba5fbe442dd8d3316b990cd8f2ec9be0a0ec9db0c0e520 AS runtime
WORKDIR /app
COPY --from=build /app/out ./

# Run the web service on container startup.
ENTRYPOINT ["dotnet", "SampleApp.dll"]
