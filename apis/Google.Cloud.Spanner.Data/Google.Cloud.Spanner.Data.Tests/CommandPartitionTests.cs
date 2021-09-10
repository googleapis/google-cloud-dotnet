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

using Google.Cloud.Spanner.V1;
using Google.Protobuf;
using System.Text;
using Xunit;

namespace Google.Cloud.Spanner.Data.Tests
{
    public class CommandPartitionTests
    {
        [Fact]
        public void Base64RoundTrip_ExecuteSqlRequest()
        {
            var request = new ExecuteSqlRequest
            {
                Sql = "Test Sql",
                Session = "sessionName",
                Transaction = new TransactionSelector
                {
                    Id = ByteString.CopyFrom("some_id", Encoding.UTF8)
                }
            };

            var partition = new CommandPartition(ReadOrQueryRequest.FromRequest(request));
            var partition2 = CommandPartition.FromBase64String(partition.ToBase64String());
            Assert.Equal(request, partition2.Request.ExecuteSqlRequest);
        }

        [Fact]
        public void Base64RoundTrip_ReadRequest()
        {
            var request = new ReadRequest
            {
                Table = "Foo",
                Columns = { "Col1", "Col2" },
                Index = "Bar",
                Limit = 10,
                Session = "sessionName",
                Transaction = new TransactionSelector
                {
                    Id = ByteString.CopyFrom("some_id", Encoding.UTF8)
                }
            };

            var partition = new CommandPartition(ReadOrQueryRequest.FromRequest(request));
            var partition2 = CommandPartition.FromBase64String(partition.ToBase64String());
            Assert.Equal(request, partition2.Request.ReadRequest);
        }

        [Fact]
        public void Equals_ReadRequest()
        {
            var request = new ReadRequest
            {
                Table = "Foo",
                Columns = { "Col1", "Col2" },
                Index = "Bar",
                Limit = 10,
                Session = "sessionName",
                Transaction = new TransactionSelector
                {
                    Id = ByteString.CopyFrom("some_id", Encoding.UTF8)
                }
            };
            var request2 = request.Clone();
            var request3 = new ReadRequest();
            var partition1 = new CommandPartition(ReadOrQueryRequest.FromRequest(request));
            var partition2 = new CommandPartition(ReadOrQueryRequest.FromRequest(request2));
            var partition3 = new CommandPartition(ReadOrQueryRequest.FromRequest(request3));
            var partition4 = new CommandPartition(ReadOrQueryRequest.FromRequest(new ExecuteSqlRequest()));
            Assert.Equal(partition1, partition2);
            Assert.NotEqual(partition1, partition3);
            Assert.NotEqual(partition1, partition4);
            Assert.NotEqual(partition3, partition4);
            Assert.Equal(partition1, partition1.Clone());
        }

        [Fact]
        public void Equals_ExecuteSqlRequest()
        {
            var request = new ExecuteSqlRequest
            {
                Sql = "SELECT * FROM Foo",
                Session = "sessionName",
                Transaction = new TransactionSelector
                {
                    Id = ByteString.CopyFrom("some_id", Encoding.UTF8)
                }
            };
            var request2 = request.Clone();
            var request3 = new ExecuteSqlRequest();
            var partition1 = new CommandPartition(ReadOrQueryRequest.FromRequest(request));
            var partition2 = new CommandPartition(ReadOrQueryRequest.FromRequest(request2));
            var partition3 = new CommandPartition(ReadOrQueryRequest.FromRequest(request3));
            var partition4 = new CommandPartition(ReadOrQueryRequest.FromRequest(new ReadRequest()));
            Assert.Equal(partition1, partition2);
            Assert.NotEqual(partition1, partition3);
            Assert.NotEqual(partition1, partition4);
            Assert.NotEqual(partition3, partition4);
            Assert.Equal(partition1, partition1.Clone());
        }
    }
}
