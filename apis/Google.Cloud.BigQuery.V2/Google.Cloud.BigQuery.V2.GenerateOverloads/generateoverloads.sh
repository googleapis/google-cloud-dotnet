#!/bin/bash

declare -r CLIENT=../Google.Cloud.BigQuery.V2/BigQueryClient

# Remove all previously-generated code.
rm ../Google.Cloud.BigQuery.V2/*.g.cs

dotnet run -- Methods/DatasetCrud.xml $CLIENT.DatasetCrud.g.cs
dotnet run -- Methods/DatasetLabels.xml $CLIENT.DatasetLabels.g.cs
dotnet run -- Methods/InsertData.xml $CLIENT.InsertData.g.cs
dotnet run -- Methods/JobCrud.xml $CLIENT.JobCrud.g.cs
dotnet run -- Methods/ModelCrud.xml $CLIENT.ModelCrud.g.cs
dotnet run -- Methods/Queries.xml $CLIENT.Queries.g.cs
dotnet run -- Methods/RoutineCrud.xml $CLIENT.RoutineCrud.g.cs
dotnet run -- Methods/ServiceAccount.xml $CLIENT.ServiceAccount.g.cs
dotnet run -- Methods/TableCrud.xml $CLIENT.TableCrud.g.cs
