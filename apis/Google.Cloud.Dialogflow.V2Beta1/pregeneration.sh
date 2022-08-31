#!/bin/bash

# Correct the version number from V2beta1 to V2Beta1 in the namespace
sed -i 's/option csharp_namespace = "Google.Cloud.Dialogflow.V2beta1";/option csharp_namespace = "Google.Cloud.Dialogflow.V2Beta1";/g' $GOOGLEAPIS/google/cloud/dialogflow/v2beta1/*.proto
