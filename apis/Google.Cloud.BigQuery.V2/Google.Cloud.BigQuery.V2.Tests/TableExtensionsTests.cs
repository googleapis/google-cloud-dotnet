// Copyright 2020 Google Inc. All Rights Reserved.
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
    public class TableExtensionsTests
    {
        private static readonly DateTimeOffset UnixEpoch = new DateTimeOffset(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc), TimeSpan.Zero);

        [Fact]
        public void NullTableThrows()
        {
            Table table = null;

            Assert.Throws<ArgumentNullException>(() => table.GetExpirationTime());
            Assert.Throws<ArgumentNullException>(() => table.SetExpirationTime(DateTimeOffset.Now));
        }

        [Fact]
        public void SetExpiration()
        {
            DateTimeOffset expiration = UnixEpoch.AddMilliseconds(35);
            Table table = new Table();

            Table modified = table.SetExpirationTime(expiration);

            Assert.Same(table, modified);
            Assert.Equal(35, modified.ExpirationTime);
        }

        [Fact]
        public void ClearExpiration()
        {
            Table table = new Table { ExpirationTime = 35 };

            Table modified = table.SetExpirationTime(null);

            Assert.Same(table, modified);
            Assert.Null(modified.ExpirationTime);
        }

        [Fact]
        public void GetExpiration()
        {
            Table table = new Table { ExpirationTime = 35 };

            var expiration = table.GetExpirationTime();

            Assert.Equal(UnixEpoch.AddMilliseconds(35), expiration.Value);
        }
    }
}
