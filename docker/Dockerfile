# Start with the .NET Core SDK
FROM mcr.microsoft.com/dotnet/core/sdk:2.2.104-bionic

RUN apt-get update
RUN apt-get install -y git
# Note: when all APIs are on the microgenerator, we can remove the following line.
RUN apt-get install -y openjdk-8-jdk

RUN apt-get install -y python3
RUN apt-get install -y python3-pip
RUN python3 -m pip install --upgrade pip
RUN python3 -m pip install --upgrade gcp-synthtool

# Extra environment variables for synthtool
ENV LC_ALL=C.UTF-8
ENV LANG=C.UTF-8

WORKDIR /google-cloud-dotnet
ENTRYPOINT ["/bin/bash"]
