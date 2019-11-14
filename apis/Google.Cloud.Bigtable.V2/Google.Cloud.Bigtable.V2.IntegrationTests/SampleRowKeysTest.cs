// Copyright 2017 Google Inc. All rights reserved.
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

using Google.Cloud.Bigtable.Common.V2;
using Google.Protobuf;
using Google.Rpc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Bigtable.V2.IntegrationTests
{
    [Collection(nameof(BigtableFixture))]
    public class SampleRowKeysTest
    {
        private readonly BigtableFixture _fixture;

        public SampleRowKeysTest(BigtableFixture fixture) => _fixture = fixture;

        [Fact]
        public async Task Streaming()
        {
            var client = _fixture.TableClient;
            var tableName = await _fixture.CreateTable();

            await _fixture.InsertRowsAsync(
                tableName, 
                Enumerable.Range(0, 10000).Select(i => (BigtableByteString)$"row{i:d5}"));

            var stream = client.SampleRowKeys(tableName);

            BigtableByteString previousRowKey;
            long previousByteOffset = 0;
            bool hasResponses = false;
            while (await stream.GrpcCall.ResponseStream.MoveNext(default))
            {
                hasResponses = true;
                var sample = stream.GrpcCall.ResponseStream.Current;
                Assert.True(previousRowKey <= sample.RowKey);
                Assert.True(previousByteOffset <= sample.OffsetBytes);
                previousRowKey = sample.RowKey;
                previousByteOffset = sample.OffsetBytes;
            }
            Assert.True(hasResponses);
        }

        [Fact]
        public async Task Spooling()
        {
            var client = _fixture.TableClient;
            var tableName = await _fixture.CreateTable();

            await _fixture.InsertRowsAsync(
                tableName,
                Enumerable.Range(0, 10000).Select(i => (BigtableByteString)$"row{i:d5}"));

            var samples = client.SampleRowKeys(tableName).ToList();

            Assert.NotEmpty(samples);

            BigtableByteString previousRowKey;
            long previousByteOffset = 0;
            foreach(var sample in samples)
            {
                Assert.True(previousRowKey <= sample.RowKey);
                Assert.True(previousByteOffset <= sample.OffsetBytes);
                previousRowKey = sample.RowKey;
                previousByteOffset = sample.OffsetBytes;
            }
        }

        [Fact]
        public async Task AsyncSpooling()
        {
            var client = _fixture.TableClient;
            var tableName = await _fixture.CreateTable();

            await _fixture.InsertRowsAsync(
                tableName,
                Enumerable.Range(0, 10000).Select(i => (BigtableByteString)$"row{i:d5}"));

            var samples = await client.SampleRowKeys(tableName).ToListAsync();

            Assert.NotEmpty(samples);

            BigtableByteString previousRowKey;
            long previousByteOffset = 0;
            foreach(var sample in samples)
            {
                Assert.True(previousRowKey <= sample.RowKey);
                Assert.True(previousByteOffset <= sample.OffsetBytes);
                previousRowKey = sample.RowKey;
                previousByteOffset = sample.OffsetBytes;
            }
        }
    }
}
