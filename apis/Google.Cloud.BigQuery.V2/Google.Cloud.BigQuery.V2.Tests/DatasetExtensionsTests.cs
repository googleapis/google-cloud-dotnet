// Copyright 2020 Google LLC
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     https://www.apache.org/licenses/LICENSE-2.0
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
    public class DatasetExtensionsTests
    {
        [Fact]
        public void NullDatasetThrows()
        {
            TimeSpan expiration = TimeSpan.FromMilliseconds(35);
            Dataset dataset = null;

            Assert.Throws<ArgumentNullException>(() => dataset.GetDefaultPartitionExpiration());
            Assert.Throws<ArgumentNullException>(() => dataset.GetDefaultTableExpiration());
            Assert.Throws<ArgumentNullException>(() => dataset.SetDefaultPartitionExpiration(expiration));
            Assert.Throws<ArgumentNullException>(() => dataset.SetDefaultTableExpiration(expiration));
        }

        [Fact]
        public void SetDefaultPartitionExpiration()
        {
            TimeSpan expiration = TimeSpan.FromMilliseconds(35);
            Dataset dataset = new Dataset();

            Dataset modified = dataset.SetDefaultPartitionExpiration(expiration);

            Assert.Same(dataset, modified);
            Assert.Equal(35, modified.DefaultPartitionExpirationMs);
        }

        [Fact]
        public void ClearDefaultPartitionExpiration()
        {
            Dataset dataset = new Dataset { DefaultPartitionExpirationMs = 35 };

            Dataset modified = dataset.SetDefaultPartitionExpiration(null);

            Assert.Same(dataset, modified);
            Assert.Null(modified.DefaultPartitionExpirationMs);
        }

        [Fact]
        public void GetDefaultPartitionExpiration()
        {
            Dataset dataset = new Dataset { DefaultPartitionExpirationMs = 35 };

            var expiration = dataset.GetDefaultPartitionExpiration();

            Assert.Equal(35, expiration.Value.TotalMilliseconds);
        }

        [Fact]
        public void SetDefaultTableExpiration()
        {
            TimeSpan expiration = TimeSpan.FromMilliseconds(35);
            Dataset dataset = new Dataset();

            Dataset modified = dataset.SetDefaultTableExpiration(expiration);

            Assert.Same(dataset, modified);
            Assert.Equal(35, modified.DefaultTableExpirationMs);
        }

        [Fact]
        public void ClearDefaultTableExpiration()
        {
            Dataset dataset = new Dataset { DefaultTableExpirationMs = 35 };

            Dataset modified = dataset.SetDefaultTableExpiration(null);

            Assert.Same(dataset, modified);
            Assert.Null(modified.DefaultTableExpirationMs);
        }

        [Fact]
        public void GetDefaultTableExpiration()
        {
            Dataset dataset = new Dataset { DefaultTableExpirationMs = 35 };

            var expiration = dataset.GetDefaultTableExpiration();

            Assert.Equal(35, expiration.Value.TotalMilliseconds);
        }
    }
}
