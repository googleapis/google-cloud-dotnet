#!/bin/bash

curl https://packages.microsoft.com/keys/microsoft.asc | gpg --dearmor > microsoft.gpg
mv microsoft.gpg /etc/apt/trusted.gpg.d/microsoft.gpg
apt-get update
apt-get install -y lsb-core
apt-get install -y jed
apt-get install -y vi
sh -c 'echo "deb [arch=amd64] https://packages.microsoft.com/repos/microsoft-ubuntu-$(lsb_release -cs)-prod $(lsb_release -cs) main" > /etc/apt/sources.list.d/dotnetdev.list'
apt-get update
apt-get install -y azure-functions-core-tools-3
#mkdir azure
#cd azure
#func init AssetTest --worker-runtime=dotnet
#cd AssetTest
#func new --name=AssetTestFunction --template=HttpTrigger

