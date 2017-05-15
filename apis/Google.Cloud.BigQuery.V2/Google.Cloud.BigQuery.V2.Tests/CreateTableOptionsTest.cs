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

using Google.Apis.Bigquery.v2;
using Google.Apis.Bigquery.v2.Data;
using System;
using Xunit;
using static Google.Apis.Bigquery.v2.TablesResource;

namespace Google.Cloud.BigQuery.V2.Tests
{
    public class CreateTableOptionsTest
    {
        [Fact]
        public void PropertiesSetOnRequest()
        {
            var options = new CreateTableOptions
            {
                Expiration = new DateTimeOffset(1970, 1, 1, 0, 0, 5, 0, TimeSpan.Zero),
                Description = "A description",
                FriendlyName = "A friendly name",
                TimePartitionType = TimePartitionType.Day,
                TimePartitionExpiration = TimeSpan.FromDays(10),
                ExternalDataConfiguration = new ExternalDataConfiguration(),
            };
            Table table = new Table();
            InsertRequest request = new InsertRequest(new BigqueryService(), table, "project", "dataset");
            options.ModifyRequest(table, request);
            Assert.Equal(5 * 1000, table.ExpirationTime);
            Assert.Equal("A description", table.Description);
            Assert.Equal("A friendly name", table.FriendlyName);
            Assert.Equal("DAY", table.TimePartitioning.Type);
            Assert.Equal(10 * 24 * 60 * 60 * 1000L, table.TimePartitioning.ExpirationMs);
            Assert.Same(options.ExternalDataConfiguration, table.ExternalDataConfiguration);
        }

        [Fact]
        public void InvalidTimePartitioningType()
        {
            var options = new CreateTableOptions
            {
                TimePartitionType = (TimePartitionType) 2
            };
            Table table = new Table();
            InsertRequest request = new InsertRequest(new BigqueryService(), table, "project", "dataset");
            Assert.Throws<ArgumentException>(() => options.ModifyRequest(table, request));
        }

        [Fact]
        public void TimePartitioningExpirationWithoutTimePartitioningType()
        {
            var options = new CreateTableOptions
            {
                TimePartitionExpiration = TimeSpan.FromDays(1)
            };
            Table table = new Table();
            InsertRequest request = new InsertRequest(new BigqueryService(), table, "project", "dataset");
            Assert.Throws<ArgumentException>(() => options.ModifyRequest(table, request));
        }

        [Fact]
        public void ExternalConfigurationAndViewInvalid()
        {
            var options = new CreateTableOptions
            {
                ExternalDataConfiguration = new ExternalDataConfiguration(),
                View = new ViewDefinition()
            };
            Table table = new Table();
            InsertRequest request = new InsertRequest(new BigqueryService(), table, "project", "dataset");
            Assert.Throws<ArgumentException>(() => options.ModifyRequest(table, request));
        }
    }
}
