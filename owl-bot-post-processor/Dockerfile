# This Dockerfile image expects to be run in the root directory of the
# google-cloud-dotnet repository.

# It's usually built automatically via google cloud build, but you can also
# manually build with:
#   docker build -t gcr.io/cloud-devrel-public-resources/owlbot-dotnet .
FROM mcr.microsoft.com/dotnet/core/sdk:3.1-bionic
CMD ["./copyfromstaging.sh"]
