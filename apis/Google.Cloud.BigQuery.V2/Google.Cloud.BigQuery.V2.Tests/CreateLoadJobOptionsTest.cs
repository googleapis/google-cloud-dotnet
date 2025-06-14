// Copyright 2017 Google Inc. All Rights Reserved.
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
using Xunit;

namespace Google.Cloud.BigQuery.V2.Tests
{
    public class CreateLoadJobOptionsTest
    {
        [Fact]
        public void PropertiesSetOnRequest()
        {
            var options = new CreateLoadJobOptions
            {
                AllowJaggedRows = true,
                AllowQuotedNewlines = true,
                Autodetect = false,
                CreateDisposition = CreateDisposition.CreateIfNeeded,
                FieldDelimiter = "/",
                IgnoreUnknownValues = true,
                MaxBadRecords = 100,
                NullMarker = "null",
                ProjectionFields = new[] { "foo", "bar" },
                Quote = "q",
                SkipLeadingRows = 10,
                SourceFormat = FileFormat.DatastoreBackup,
                TimePartitioning = TimePartition.CreateDailyPartitioning(expiration: null),
                WriteDisposition = WriteDisposition.WriteAppend,
                DestinationEncryptionConfiguration = new EncryptionConfiguration { KmsKeyName = "projects/1/locations/us/keyRings/1/cryptoKeys/1" },
                DestinationSchemaUpdateOptions = SchemaUpdateOption.AllowFieldAddition | SchemaUpdateOption.AllowFieldRelaxation,
                UseAvroLogicalTypes = true,
                Encoding = "encoding-test",
                ConfigurationModifier = options => options.ETag = "test",
                Reservation = "Reservation"
            };

            JobConfigurationLoad load = new JobConfigurationLoad();
            options.ModifyRequest(load);
            Assert.Equal(true, load.AllowJaggedRows);
            Assert.Equal(true, load.AllowQuotedNewlines);
            Assert.Equal(false, load.Autodetect);
            Assert.Equal("CREATE_IF_NEEDED", load.CreateDisposition);
            Assert.Equal("/", load.FieldDelimiter);
            Assert.Equal(true, load.IgnoreUnknownValues);
            Assert.Equal(100, load.MaxBadRecords);
            Assert.Equal("null", load.NullMarker);
            Assert.Equal(new[] { "foo", "bar" }, load.ProjectionFields);
            Assert.Equal("q", load.Quote);
            Assert.Equal(10, load.SkipLeadingRows);
            Assert.Equal("DATASTORE_BACKUP", load.SourceFormat);
            Assert.Equal("WRITE_APPEND", load.WriteDisposition);
            Assert.Equal("DAY", load.TimePartitioning.Type);
            Assert.Equal("encoding-test", load.Encoding);
            Assert.Null(load.TimePartitioning.ExpirationMs);
            Assert.Equal("projects/1/locations/us/keyRings/1/cryptoKeys/1", load.DestinationEncryptionConfiguration.KmsKeyName);
            Assert.Contains("ALLOW_FIELD_ADDITION", load.SchemaUpdateOptions);
            Assert.Contains("ALLOW_FIELD_RELAXATION", load.SchemaUpdateOptions);
            Assert.True(load.UseAvroLogicalTypes);
            Assert.Equal("test", load.ETag);
        }
    }
}
