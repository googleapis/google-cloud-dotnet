# Start with the .NET Core SDK, targeting Ubuntu 18.04 (Bionic Beaver)
FROM mcr.microsoft.com/dotnet/core/sdk:3.1-bionic

RUN apt-get update
RUN apt-get install -y git
RUN apt-get install -y unzip
RUN apt-get install -y python3
RUN apt-get install -y python3-pip
RUN python3 -m pip install --upgrade pip
RUN python3 -m pip install --upgrade gcp-synthtool

# Install the .NET Core 2.1 runtime for running tests
RUN wget -q https://packages.microsoft.com/config/ubuntu/18.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
RUN dpkg -i packages-microsoft-prod.deb
RUN apt-get update
RUN apt-get install -y dotnet-runtime-2.1

# Extra environment variables for synthtool
ENV LC_ALL=C.UTF-8
ENV LANG=C.UTF-8

WORKDIR /google-cloud-dotnet
ENTRYPOINT ["/bin/bash"]
