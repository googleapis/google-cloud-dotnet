# Use Microsoft's official build .NET image.
# https://hub.docker.com/_/microsoft-dotnet-core-sdk/
FROM mcr.microsoft.com/dotnet/sdk:8.0@sha256:3c0edbfe1549dd93fb789dc96299a40df865ad7bffefcaf38e8c05940686d641 AS build
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
FROM mcr.microsoft.com/dotnet/aspnet:8.0@sha256:8f6a307ae32fb393a4b4bcde0a81f0ce3f0a715de0e5575df71f3030448f2dde AS runtime
WORKDIR /app
COPY --from=build /app/out ./

# Run the web service on container startup.
ENTRYPOINT ["dotnet", "SampleApp.dll"]
