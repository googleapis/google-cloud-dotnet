// Copyright 2016 Google Inc. All Rights Reserved.
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

namespace Google.Cloud.BigQuery.V2.Tests
{
    public class QueryOptionsTest
    {
        private readonly QueryOptions _options = new QueryOptions
        {
            AllowLargeResults = true,
            CreateDisposition = CreateDisposition.CreateNever,
            DefaultDataset = new DatasetReference { ProjectId = "a", DatasetId = "b" },
            DestinationTable = new TableReference { ProjectId = "a", DatasetId = "b", TableId = "c" },
            FlattenResults = false,
            MaximumBillingTier = 10,
            MaximumBytesBilled = 1000,
            Priority = QueryPriority.Batch,
            UseQueryCache = false,
            WriteDisposition = WriteDisposition.WriteIfEmpty,
            UseLegacySql = true,
            ParameterMode = BigQueryParameterMode.Positional,
            DestinationEncryptionConfiguration = new EncryptionConfiguration { KmsKeyName = "projects/1/locations/us/keyRings/1/cryptoKeys/1" },
            DestinationSchemaUpdateOptions = SchemaUpdateOption.AllowFieldAddition | SchemaUpdateOption.AllowFieldRelaxation,
            TimePartitioning = TimePartition.CreateDailyPartitioning(TimeSpan.FromHours(1), "field"),
            ConfigurationModifier = options => options.ETag = "test",
            JobConfigurationModifier = config => config.Reservation = "Reservation",
            DryRun = true,
            Labels = new Dictionary<string, string>()
            {
                { "Key", "Value" }
            }
        };

        [Fact]
        public void TestModifyRequest()
        {

            JobConfigurationQuery query = new JobConfigurationQuery();
            _options.ModifyRequest(query);
            Assert.Equal(true, query.AllowLargeResults);
            Assert.Equal("CREATE_NEVER", query.CreateDisposition);
            Assert.Equal("b", query.DefaultDataset.DatasetId);
            Assert.Equal("c", query.DestinationTable.TableId);
            Assert.Equal(false, query.FlattenResults);
            Assert.Equal(10, query.MaximumBillingTier);
            Assert.Equal(1000, query.MaximumBytesBilled);
            Assert.Equal("BATCH", query.Priority);
            Assert.Equal(false, query.UseQueryCache);
            Assert.Equal("WRITE_EMPTY", query.WriteDisposition);
            Assert.Equal(true, query.UseLegacySql);
            Assert.Equal("positional", query.ParameterMode);
            Assert.Equal("projects/1/locations/us/keyRings/1/cryptoKeys/1", query.DestinationEncryptionConfiguration.KmsKeyName);
            Assert.Equal(2, query.SchemaUpdateOptions.Count);
            Assert.Contains("ALLOW_FIELD_ADDITION", query.SchemaUpdateOptions);
            Assert.Contains("ALLOW_FIELD_RELAXATION", query.SchemaUpdateOptions);
            Assert.Equal(60 * 60 * 1000, query.TimePartitioning.ExpirationMs);
            Assert.Equal("DAY", query.TimePartitioning.Type);
            Assert.Equal("field", query.TimePartitioning.Field);
            Assert.Equal("test", query.ETag);
        }

        [Fact]
        public void TestModifyJobConfiguration()
        {
            var jobConfiguration = new JobConfiguration();
            _options.ModifyJobConfiguration(jobConfiguration);
            Assert.Equal("Reservation", jobConfiguration.Reservation);
            Assert.Equal(true, jobConfiguration.DryRun);
            Assert.Equal(_options.Labels, jobConfiguration.Labels);
        }
    }
}
