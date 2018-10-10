// Copyright 2018 Google LLC
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

using System;
using Xunit;

namespace Google.Cloud.Spanner.Data.Tests
{
    public class TransactionIdTests
    {
        public static TheoryData<TransactionId> SampleTransactionIds = new TheoryData<TransactionId>
        {
            new TransactionId("ConnectionString", "Session", "Id", TimestampBound.OfMaxStaleness(TimeSpan.FromHours(1))),
            new TransactionId("ConnectionString2", "Session2", "Id2", TimestampBound.OfReadTimestamp(new DateTime(1999, 12, 31, 3, 33, 33, DateTimeKind.Utc))),
            new TransactionId("ConnectionString3", "Session3", "Id3", TimestampBound.Strong)
        };

        [Theory]
        [MemberData(nameof(SampleTransactionIds))]
        public void Base64RoundTrip(TransactionId transactionId)
        {
            Assert.Equal(transactionId, TransactionId.FromBase64String(transactionId.ToBase64String()));
        }
    }
}
