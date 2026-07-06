FROM mcr.microsoft.com/dotnet/sdk:6.0.414-jammy@sha256:095558469a541095189d8533eb6593786b3213add88b397d468b86bed32fd33c

RUN apt-get update
RUN apt-get install -y git
RUN apt-get install -y unzip

WORKDIR /google-cloud-dotnet
ENTRYPOINT ["/bin/bash"]
