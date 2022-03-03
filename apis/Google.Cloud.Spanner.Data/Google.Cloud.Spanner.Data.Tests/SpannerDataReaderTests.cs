// Copyright 2021 Google Inc. All Rights Reserved.
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

using Google.Api.Gax.Grpc.Testing;
using Google.Cloud.Spanner.V1;
using Google.Protobuf.WellKnownTypes;
using Microsoft.Extensions.Logging.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using TypeCode = Google.Cloud.Spanner.V1.TypeCode;

namespace Google.Cloud.Spanner.Data.Tests
{
    public class SpannerDataReaderTests
    {
        [InlineData(new byte[]{1,2,3}, 3)]
        [InlineData(new byte[]{}, 0)]
        [InlineData(null, 0)]
        [Theory]
        public void GetBytesNullBuffer_ReturnsLength(byte[] bytes, int length)
        {
            var reader = CreateTestReader(bytes);
            Assert.Equal(length, reader.GetBytes(0, 0L, null, 0, int.MaxValue));
        }

        [InlineData(new byte[]{1,2,3}, 3)]
        [InlineData(new byte[]{}, 0)]
        [InlineData(null, 0)]
        [Theory]
        public void GetBytes(byte[] bytes, int length)
        {
            var reader = CreateTestReader(bytes);

            var buffer = new byte[length];
            Assert.Equal(length, reader.GetBytes(0, 0L, buffer, 0, length));
            Assert.Equal(bytes ?? Array.Empty<byte>(), buffer);
        }

        [InlineData(new byte[]{1,2,3}, 1L, 3, 2)]
        [InlineData(new byte[]{1,2,3}, 2L, 3, 1)]
        [InlineData(new byte[]{1,2,3}, 3L, 3, 0)]
        [Theory]
        public void GetBytes_FieldOffset(byte[] bytes, long offset, int maxLength, int expectedLength)
        {
            var expectedBytes = new byte[maxLength];
            Array.Copy(bytes, offset, expectedBytes, 0L, expectedLength);

            var reader = CreateTestReader(bytes);

            var buffer = new byte[maxLength];
            Assert.Equal(expectedLength, reader.GetBytes(0, offset, buffer, 0, maxLength));
            Assert.Equal(expectedBytes, buffer);
        }

        [InlineData(new byte[]{1,2,3}, 1, 3, 3)]
        [InlineData(new byte[]{1,2,3}, 2, 3, 3)]
        [InlineData(new byte[]{1,2,3}, 3, 3, 3)]
        [Theory]
        public void GetBytes_BufferOffset(byte[] bytes, int offset, int maxLength, int expectedLength)
        {
            var expectedBytes = new byte[offset + maxLength];
            Array.Copy(bytes, 0, expectedBytes, offset, expectedLength);

            var reader = CreateTestReader(bytes);

            var buffer = new byte[offset + maxLength];
            Assert.Equal(expectedLength, reader.GetBytes(0, 0L, buffer, offset, maxLength));
            Assert.Equal(expectedBytes, buffer);
        }

        [Fact]
        public void GetBytes_MaxLengthExceedsBufferSize()
        {
            var reader = CreateTestReader(Array.Empty<byte>());

            var buffer = new byte[3];
            Assert.Throws<ArgumentOutOfRangeException>(() => reader.GetBytes(0, 0L, buffer, 0, 4));
        }

        [Fact]
        public void GetBytes_BufferOffsetExceedsBufferSize()
        {
            var reader = CreateTestReader(Array.Empty<byte>());

            var buffer = new byte[3];
            Assert.Throws<ArgumentOutOfRangeException>(() => reader.GetBytes(0, 0L, buffer, 4, 0));
        }

        [Fact]
        public void GetBytes_BufferOffsetAndMaxLengthExceedBufferSize()
        {
            var reader = CreateTestReader(Array.Empty<byte>());

            var buffer = new byte[3];
            Assert.Throws<ArgumentOutOfRangeException>(() => reader.GetBytes(0, 0L, buffer, 2, 2));
        }

        [Fact]
        public void GetBytes_FieldOffsetExceedsFieldLength()
        {
            var reader = CreateTestReader(new byte[] {1});

            var buffer = new byte[3];
            Assert.Throws<ArgumentOutOfRangeException>(() => reader.GetBytes(0, 2L, buffer, 0, 3));
        }

        [Fact]
        public void GetBytes_WrongType()
        {
            var results = new []
            {
                CreateResultSet( new []{Value.ForString("test")})
            };
            var reader = CreateSpannerDataReader(results, CreateSingleFieldMetadata(TypeCode.String));
            reader.Read();

            Assert.Throws<ArgumentException>(() => reader.GetBytes(0, 0L, null, 0, 0));
        }

        private static SpannerDataReader CreateTestReader(byte[] bytes)
        {
            var results = new []
            {
                CreateResultSet( new []{bytes})
            };
            var reader = CreateSpannerDataReader(results);
            reader.Read();
            return reader;
        }

        private static SpannerDataReader CreateSpannerDataReader(
            PartialResultSet[] results,
            ResultSetMetadata metadata = null) =>
            new SpannerDataReader(
                NullLogger.Instance, CreateReader(results, metadata), Timestamp.FromDateTime(DateTime.UtcNow),
                null, SpannerConversionOptions.Default, false, 120);

        private static PartialResultSet CreateResultSet(params byte[][] bytesValues) =>
            CreateResultSet(bytesValues.Select(bytes => bytes == null ? Value.ForNull() : Value.ForString(Convert.ToBase64String(bytes))));

        private static PartialResultSet CreateResultSet(IEnumerable<Value> values) => new PartialResultSet { Values = { values } };

        private static ReliableStreamReader CreateReader(PartialResultSet[] results, ResultSetMetadata metadata = null)
        {
            results[0].Metadata = metadata ?? CreateSingleBytesFieldMetadata();
            return new ReliableStreamReader(new AsyncStreamAdapter<PartialResultSet>(results.ToAsyncEnumerable().GetAsyncEnumerator()), NullLogger.Instance);
        }

        private static ResultSetMetadata CreateSingleBytesFieldMetadata() => CreateSingleFieldMetadata(TypeCode.Bytes);

        private static ResultSetMetadata CreateSingleFieldMetadata(TypeCode typeCode) =>
            new ResultSetMetadata
            {
                RowType = new StructType
                {
                    Fields =
                    {
                        new StructType.Types.Field
                        {
                            Name = "col1", Type = new V1.Type { Code = typeCode }
                        }
                    }
                }
            };
    }
}
