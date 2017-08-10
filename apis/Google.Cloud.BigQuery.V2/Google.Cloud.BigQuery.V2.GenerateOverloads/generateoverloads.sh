#!/bin/bash

declare -r CLIENT=../Google.Cloud.BigQuery.V2/BigQueryClient
dotnet run -- Methods/SetDatasetLabel.xml $CLIENT.DatasetLabels.cs
dotnet run -- Methods/RemoveDatasetLabel.xml $CLIENT.DatasetLabels.cs
dotnet run -- Methods/ClearDatasetLabels.xml $CLIENT.DatasetLabels.cs
dotnet run -- Methods/ModifyDatasetLabels.xml $CLIENT.DatasetLabels.cs