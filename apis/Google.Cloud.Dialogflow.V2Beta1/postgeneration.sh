#!/bin/bash

set -e

# Undo the changes made in pregeneration.sh
git -C $GOOGLEAPIS checkout google/cloud/dialogflow/v2beta1

# Ignore deprecation in the generated gRPC code
sed -i 's/#pragma warning disable/#pragma warning disable 0612,/g' Google.Cloud.Dialogflow.V2Beta1/ParticipantGrpc.g.cs
