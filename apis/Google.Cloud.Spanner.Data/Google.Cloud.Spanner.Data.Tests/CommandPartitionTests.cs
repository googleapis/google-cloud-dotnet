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
        public void Base64RoundTrip()
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

            var partition = new CommandPartition(request);
            var partition2 = CommandPartition.FromBase64String(partition.ToBase64String());
            Assert.Equal(request, partition2.ExecuteSqlRequest);
        }
    }
}
