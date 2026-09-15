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

using Google.Api.Gax;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Google.Cloud.Spanner.Data;

/// <summary>
/// 
/// </summary>
public class Payload
{
    internal Value Value { get; set; }

    private Payload(SpannerDbType spannerDbType, object val) => Value = spannerDbType.ToProtobufValue(GaxPreconditions.CheckNotNull(val, nameof(val)));

    /// <summary>
    /// 
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public static Payload FromString(string str) => new(SpannerDbType.String, str);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="bytes"></param>
    /// <returns></returns>
    public static Payload FromBytes(byte[] bytes) => new(SpannerDbType.Bytes, bytes);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="json"></param>
    /// <returns></returns>
    public static Payload FromJson(string json) => new(SpannerDbType.Json, json);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="message"></param>
    /// <returns></returns>
    public static Payload FromProtobufMessage(object message) => new(SpannerDbType.FromClrType(message.GetType()), message);

    /// <inheritdoc />
    public object Clone() => (Payload) MemberwiseClone();
}
