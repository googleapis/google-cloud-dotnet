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

        Assert.Equal(options.ConnectionProperties, request.ConnectionProperties);
        Assert.Equal(options.Continuous, request.Continuous);
        Assert.Equal(options.CreateSession, request.CreateSession);
        Assert.Same(options.DefaultDataset, request.DefaultDataset);
        Assert.Same(options.DestinationEncryptionConfiguration, request.DestinationEncryptionConfiguration);
        Assert.Equal(options.DryRun, request.DryRun);
        Assert.Same(options.FormatOptions, request.FormatOptions);
        Assert.Equal(EnumMap.ToApiValue(options.JobCreationMode.Value), request.JobCreationMode);
        Assert.Equal((long)options.JobTimeout.Value.TotalMilliseconds, request.JobTimeoutMs);
        Assert.Same(options.Labels, request.Labels);
        Assert.Equal(options.Location, request.Location);
        Assert.Equal(options.MaxResults, request.MaxResults);
        Assert.Equal(options.MaximumBytesBilled, request.MaximumBytesBilled);
        Assert.Equal(options.ParameterMode.Value.ToString().ToLowerInvariant(), request.ParameterMode);
        Assert.Equal(options.RequestId, request.RequestId);
        Assert.Equal(options.Reservation, request.Reservation);
        Assert.Equal((long)options.Timeout.Value.TotalMilliseconds, request.TimeoutMs);
        Assert.Equal(options.UseLegacySql, request.UseLegacySql);
        Assert.Equal(options.UseQueryCache, request.UseQueryCache);
        Assert.Equal(options.WriteIncrementalResults, request.WriteIncrementalResults);
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
