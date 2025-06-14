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
using System;
using Xunit;

namespace Google.Cloud.BigQuery.V2.Tests
{
    public class CreateExtractJobOptionsTest
    {
        [Fact]
        public void ModifyRequest()
        {
            var options = new CreateExtractJobOptions
            {
                Compression = CompressionType.Gzip,
                PrintHeader = false,
                DestinationFormat = FileFormat.NewlineDelimitedJson,
                // May not make any sense for JSON, but we don't validate...
                FieldDelimiter = "gronkle",
                // Again, doesn't make sense for JSON, but we don't validate.
                UseAvroLogicalTypes = true,
                ConfigurationModifier = options => options.ETag = "test",
                Reservation = "Reservation"
            };

            JobConfigurationExtract extract = new JobConfigurationExtract();
            options.ModifyRequest(extract);
            Assert.Equal("GZIP", extract.Compression);
            Assert.Equal(false, extract.PrintHeader);
            Assert.Equal("NEWLINE_DELIMITED_JSON", extract.DestinationFormat);
            Assert.Equal("gronkle", extract.FieldDelimiter);
            Assert.Equal("test", extract.ETag);
            Assert.True(extract.UseAvroLogicalTypes);
        }

        [Fact]
        public void CannotExtractAsDatastoreBackup()
        {
            var options = new CreateExtractJobOptions { DestinationFormat = FileFormat.DatastoreBackup };
            JobConfigurationExtract extract = new JobConfigurationExtract();
            Assert.Throws<ArgumentException>(() => options.ModifyRequest(extract));
        }
    }
}
