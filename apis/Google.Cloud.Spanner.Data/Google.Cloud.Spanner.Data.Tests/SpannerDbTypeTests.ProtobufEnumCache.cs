// Copyright 2026 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License"):
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

using Google.Cloud.Spanner.Data.CommonTesting;
using Google.Protobuf.Reflection;
using System;
using Xunit;
using static Google.Cloud.Spanner.Data.SpannerDbType;

namespace Google.Cloud.Spanner.Data.Tests;

public partial class SpannerDbTypeTests
{
    private class NonProtoClass
    {
        public class Types
        {
            public enum Status
            {
                NotStarted = 0,
                Started = 1,
            }
        }
    }

    [Fact]
    public void GetEnumDescriptor_TopLevelProtobufEnum_ReturnsEnumDescriptor()
        => Assert.IsType<EnumDescriptor>(ProtobufEnumCache.GetEnumDescriptor(typeof(Color)));

    [Fact]
    public void GetEnumDescriptor_NonProtobufEnum_ReturnsNull()
        => Assert.Null(ProtobufEnumCache.GetEnumDescriptor(typeof(DayOfWeek)));

    [Fact]
    public void GetEnumDescriptor_NotEnum_ReturnsNull()
        => Assert.Null(ProtobufEnumCache.GetEnumDescriptor(typeof(NonProtoClass)));

    [Fact]
    public void GetEnumDescriptor_NestedNonProtobufEnum_ReturnsNull()
        => Assert.Null(ProtobufEnumCache.GetEnumDescriptor(typeof(NonProtoClass.Types.Status)));
}
