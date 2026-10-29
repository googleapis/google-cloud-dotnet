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
using Google.Cloud.Spanner.V1.Internal.Logging;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        [Fact]
        public void GetChars_ReadsStringData()
        {
            var reader = CreateSpannerDataReader(
                new[] { CreateResultSet(new[] { Value.ForString("spanner") }) },
                CreateMetadata("text"));
            reader.Read();

            Assert.Equal(7, reader.GetChars(0, 0, null, 0, 0));
            var buffer = new char[5];
            Assert.Equal(3, reader.GetChars(0, 1, buffer, 1, 3));
            Assert.Equal(new[] { '\0', 'p', 'a', 'n', '\0' }, buffer);
        }

        [Fact]
        public void GetChars_RejectsNonStringColumn()
        {
            var reader = CreateTestReader(new byte[] { 1 });
            Assert.Throws<ArgumentException>(() => reader.GetChars(0, 0, null, 0, 0));
        }

        [Fact]
        public async Task GetOrdinal_CaseInsensitiveFallback()
        {
            var reader = CreateSpannerDataReader(
                new[] { CreateResultSet(new[] { Value.ForString("value") }) },
                CreateMetadata("id"));

            Assert.Equal(0, reader.GetOrdinal("Id"));
            Assert.Equal(0, await reader.GetOrdinalAsync("ID"));
        }

        [Fact]
        public void GetOrdinal_ExactCaseMatchPrecedesFallback()
        {
            var reader = CreateSpannerDataReader(
                new[] { CreateResultSet(new[] { Value.ForString("lower"), Value.ForString("upper") }) },
                CreateMetadata("id", "ID"));

            Assert.Equal(1, reader.GetOrdinal("ID"));
            Assert.Equal(0, reader.GetOrdinal("Id"));
        }

        [Fact]
        public async Task GetOrdinal_UnknownColumnThrowsIndexOutOfRangeException()
        {
            var reader = CreateSpannerDataReader(
                new[] { CreateResultSet(new[] { Value.ForString("value") }) },
                CreateMetadata("id"));

            Assert.Throws<IndexOutOfRangeException>(() => reader.GetOrdinal("missing"));
            await Assert.ThrowsAsync<IndexOutOfRangeException>(() => reader.GetOrdinalAsync("missing"));
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
                Logger.DefaultLogger, CreateReader(results, metadata), Timestamp.FromDateTime(DateTime.UtcNow),
                null, SpannerConversionOptions.Default, false, 120);

        private static PartialResultSet CreateResultSet(params byte[][] bytesValues) =>
            CreateResultSet(bytesValues.Select(bytes => bytes == null ? Value.ForNull() : Value.ForString(Convert.ToBase64String(bytes))));

        private static PartialResultSet CreateResultSet(IEnumerable<Value> values) => new PartialResultSet { Values = { values } };

        private static ReliableStreamReader CreateReader(PartialResultSet[] results, ResultSetMetadata metadata = null)
        {
            results[0].Metadata = metadata ?? CreateSingleBytesFieldMetadata();
            return new ReliableStreamReader(new AsyncStreamAdapter<PartialResultSet>(results.ToAsyncEnumerable().GetAsyncEnumerator()), Logger.DefaultLogger);
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

        private static ResultSetMetadata CreateMetadata(params string[] fieldNames) =>
            new ResultSetMetadata
            {
                RowType = new StructType
                {
                    Fields =
                    {
                        fieldNames.Select(name => new StructType.Types.Field
                        {
                            Name = name,
                            Type = new V1.Type { Code = TypeCode.String }
                        })
                    }
                }
            };
    }
}
