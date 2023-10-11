FROM mcr.microsoft.com/dotnet/sdk:7.0.402-jammy

RUN apt-get update
RUN apt-get install -y git
RUN apt-get install -y unzip

WORKDIR /google-cloud-dotnet
ENTRYPOINT ["/bin/bash"]
