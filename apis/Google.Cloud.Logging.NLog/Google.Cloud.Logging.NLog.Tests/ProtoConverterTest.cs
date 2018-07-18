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

using Google.Protobuf.WellKnownTypes;
using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using Xunit;

namespace Google.Cloud.Logging.NLog.Tests
{
    public class ProtoConverterTest
    {
        [Fact]
        public void Convert_Primitives()
        {
            Assert.Equal(Value.KindOneofCase.NullValue, ProtoConverter.Convert(null).KindCase);
            Assert.Equal("Hello world", ProtoConverter.Convert("Hello world").StringValue);
            Assert.Equal(42.0, ProtoConverter.Convert(42).NumberValue);
            Assert.Equal(42.0, ProtoConverter.Convert(42L).NumberValue);
            Assert.Equal(42.5, ProtoConverter.Convert(42.5).NumberValue);
            Assert.Equal(42.5, ProtoConverter.Convert(42.5f).NumberValue);
            Assert.True(ProtoConverter.Convert(true).BoolValue);
        }

        [Fact]
        public void Convert_Array()
        {
            var array = ProtoConverter.Convert(new JArray { 1, 2, 3 });
            Assert.Equal(new[] { 1.0, 2.0, 3.0 }, array.ListValue.Values.Select(x => x.NumberValue));

            var arrayPoly = ProtoConverter.Convert(new JArray { true, "s", 1.5, null });
            var values = arrayPoly.ListValue.Values;
            Assert.True(values[0].BoolValue);
            Assert.Equal("s", values[1].StringValue);
            Assert.Equal(1.5, values[2].NumberValue);
            Assert.Equal(Value.KindOneofCase.NullValue, values[3].KindCase);
        }

        [Fact]
        public void Convert_Object()
        {
            var obj = ProtoConverter.Convert(new JObject
            {
                { "a", "a" },
                { "b", 2 },
                { "c", false },
                { "d", new JArray { 1, 2 } }
            });
            var fields = obj.StructValue.Fields;
            Assert.Equal("a", fields["a"].StringValue);
            Assert.Equal(2.0, fields["b"].NumberValue);
            Assert.False(fields["c"].BoolValue);
            Assert.Equal(new[] { 1.0, 2.0 }, fields["d"].ListValue.Values.Select(x => x.NumberValue));
        }

        [Fact]
        public void Convert_TimeSpan()
        {
            var obj = ProtoConverter.Convert(JToken.FromObject(TimeSpan.FromSeconds(2)));
            Assert.Equal(TimeSpan.FromSeconds(2).ToString("c"), obj.StringValue);
        }

        [Fact]
        public void Convert_DateTime()
        {
            var dt = new DateTime(2018, 1, 30, 11, 12, 13, DateTimeKind.Utc);
            var obj = ProtoConverter.Convert(JToken.FromObject(dt));
            Assert.Equal(dt.ToString("o"), obj.StringValue);
        }

        [Fact]
        public void Convert_Bytes()
        {
            var bytesShort = new byte[] { 1, 2, 3 };
            var objShort = ProtoConverter.Convert(JToken.FromObject(bytesShort));
            Assert.Equal("01 02 03", objShort.StringValue);
            var bytesLong = Enumerable.Repeat((byte)0xff, 1000).ToArray();
            var objLong = ProtoConverter.Convert(JToken.FromObject(bytesLong));
            Assert.Equal(string.Join(" ", Enumerable.Repeat("ff", 32)) + "...(length:1000)", objLong.StringValue);
        }

        [Fact]
        public void Convert_Guid()
        {
            var guid = Guid.NewGuid();
            var obj = ProtoConverter.Convert(JToken.FromObject(guid));
            Assert.Equal(guid.ToString("B"), obj.StringValue);
        }

        [Fact]
        public void Convert_Uri()
        {
            var uri = new Uri("https://example.com:8081/path?param=eter&an=other");
            var obj = ProtoConverter.Convert(JToken.FromObject(uri));
            Assert.Equal(uri.ToString(), obj.StringValue);
        }
    }
}
