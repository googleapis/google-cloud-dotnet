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

using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Google.Cloud.Spanner.V1;
using Google.Protobuf;
using Xunit;


namespace Google.Cloud.Spanner.Data.Tests
{
    public class SerializableTests
    {
        [Fact]
        public void CommandPartitionSerializable()
        {
            //since ExecuteSqlRequest is serializable and is the only state, this is just a sanity check.
            var partition = new CommandPartition(
                new ExecuteSqlRequest
                {
                    Sql = "Test Sql",
                    Session = "sessionName",
                    Transaction = new TransactionSelector
                    {
                        Id = ByteString.CopyFrom("some_id", Encoding.UTF8)
                    }
                });

            var partition2 = CommandPartition.FromBase64String(partition.ToBase64String());
            Assert.Equal(partition, partition2);
        }

        [Fact]
        public void TransactionIdSerializable()
        {
            var transactionId = new TransactionId(
                "ConnectionString", "Session", "Id", new TimestampBound(
                    TimestampBoundMode.MaxStaleness,
                    new TimeSpan(1, 0, 0)));

            Assert.Equal(transactionId, TransactionId.FromBase64String(transactionId.ToBase64String()));

            transactionId = new TransactionId(
                "ConnectionString2", "Session2", "Id2", new TimestampBound(
                    TimestampBoundMode.ReadTimestamp,
                    new DateTime(1999, 12, 31, 3, 33, 33, DateTimeKind.Local)));

            Assert.Equal(transactionId, TransactionId.FromBase64String(transactionId.ToBase64String()));

            transactionId = new TransactionId(
                "ConnectionString3", "Session3", "Id3", new TimestampBound(
                    TimestampBoundMode.Strong));

            Assert.Equal(transactionId, TransactionId.FromBase64String(transactionId.ToBase64String()));
        }

    }
}
