# Copyright 2021 Google LLC
#
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
#
#     http://www.apache.org/licenses/LICENSE-2.0
#
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.

# This Dockerfile image expects to be run in the root directory of the
# google-cloud-dotnet repository.

# It's usually built automatically via google cloud build, but you can also
# manually build with:
#   docker build -t gcr.io/cloud-devrel-public-resources/owlbot-dotnet .
FROM mcr.microsoft.com/dotnet/sdk:6.0-focal

# Additional tooling required to regenerate.

# Temporarily, install .NET Core 3.1 as well as .NET 6
# This (and the apt-get install of dotnet-sdk-3.1) can
# be removed when the generator is updated to use .NET 6
RUN wget https://packages.microsoft.com/config/ubuntu/20.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
RUN dpkg -i packages-microsoft-prod.deb

RUN apt-get update
RUN apt-get install -y unzip
RUN apt-get install -y python3
RUN apt-get install -y dotnet-sdk-3.1

# Note: main.sh is not packed into the docker image.  This command
# invokes the current main.sh in the repo.
CMD ["./owl-bot-post-processor/main.sh"]
