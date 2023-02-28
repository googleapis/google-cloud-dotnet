#!/bin/bash

set -e

# Ignore deprecation in the generated gRPC code
sed -i 's/#pragma warning disable/#pragma warning disable 0612,/g' Google.Cloud.Dialogflow.V2Beta1/ParticipantGrpc.g.cs
