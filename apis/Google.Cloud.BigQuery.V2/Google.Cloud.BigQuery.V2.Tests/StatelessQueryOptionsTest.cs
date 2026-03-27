// Copyright 2026 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Apis.Bigquery.v2.Data;
using System;
using System.Collections.Generic;
using Xunit;

namespace Google.Cloud.BigQuery.V2.Tests;

public class StatelessQueryOptionsTest
{
    [Fact]
    public void ModifyRequest()
    {
        var options = new StatelessQueryOptions
        {
            ConnectionProperties = new List<ConnectionProperty> { new ConnectionProperty { Key = "key", Value = "value" } },
            Continuous = true,
            CreateSession = true,
            DefaultDataset = new DatasetReference { ProjectId = "a", DatasetId = "b" },
            DestinationEncryptionConfiguration = new EncryptionConfiguration { KmsKeyName = "kms" },
            DryRun = true,
            FormatOptions = new DataFormatOptions { UseInt64Timestamp = false },
            JobCreationMode = JobCreationMode.Required,
            JobTimeout = TimeSpan.FromSeconds(10),
            Labels = new Dictionary<string, string> { { "label", "value" } },
            Location = "us",
            MaxResults = 100,
            MaximumBytesBilled = 1000,
            ParameterMode = BigQueryParameterMode.Positional,
            RequestId = "requestId",
            Reservation = "reservation",
            Timeout = TimeSpan.FromSeconds(5),
            UseLegacySql = true,
            UseQueryCache = false,
            WriteIncrementalResults = true
        };
        var request = new QueryRequest();
        options.ModifyRequest(request);

        var prop = Assert.Single(request.ConnectionProperties);
        Assert.Equal("key", prop.Key);
        Assert.Equal("value", prop.Value);
        Assert.Equal(true, request.Continuous);
        Assert.Equal(true, request.CreateSession);
        Assert.Equal("b", request.DefaultDataset.DatasetId);
        Assert.Equal("kms", request.DestinationEncryptionConfiguration.KmsKeyName);
        Assert.Equal(true, request.DryRun);
        Assert.Equal(false, request.FormatOptions.UseInt64Timestamp);
        Assert.Equal("JOB_CREATION_REQUIRED", request.JobCreationMode);
        Assert.Equal(10000L, request.JobTimeoutMs);
        Assert.Equal(options.Labels, request.Labels);
        Assert.Equal("us", request.Location);
        Assert.Equal(100L, request.MaxResults);
        Assert.Equal(1000L, request.MaximumBytesBilled);
        Assert.Equal("positional", request.ParameterMode);
        Assert.Equal("requestId", request.RequestId);
        Assert.Equal("reservation", request.Reservation);
        Assert.Equal(5000L, request.TimeoutMs);
        Assert.Equal(true, request.UseLegacySql);
        Assert.Equal(false, request.UseQueryCache);
        Assert.Equal(true, request.WriteIncrementalResults);
    }

    [Fact]
    public void ModifyRequest_RequestModifier()
    {
        var options = new StatelessQueryOptions
        {
            RequestModifier = request => request.RequestId = "modified"
        };
        var request = new QueryRequest { RequestId = "original" };
        options.ModifyRequest(request);
        Assert.Equal("modified", request.RequestId);
    }
}
