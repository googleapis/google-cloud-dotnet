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

namespace Google.Cloud.Logging.NLog
{
    internal static class ProtoConverter
    {
        public static Value Convert(JToken token)
        {
            // All JTokenTypes are handled that could arise from Json.Net converting a C# object into JSON
            switch (token?.Type ?? JTokenType.Null)
            {
                case JTokenType.Null:
                    return Value.ForNull();
                case JTokenType.String:
                    return Value.ForString(token.Value<string>());
                case JTokenType.Boolean:
                    return Value.ForBool(token.Value<bool>());
                case JTokenType.Integer:
                    return Value.ForNumber(token.Value<long>());
                case JTokenType.Float:
                    return Value.ForNumber(token.Value<double>());
                case JTokenType.Array:
                    return new Value { ListValue = new ListValue { Values = { token.Select(x => Convert(x)) } } };
                case JTokenType.Object:
                    var obj = new Struct();
                    foreach (var property in (JObject)token)
                    {
                        obj.Fields.Add(property.Key, Convert(property.Value));
                    }
                    return new Value { StructValue = obj };
                case JTokenType.TimeSpan:
                    return Value.ForString(token.Value<TimeSpan>().ToString("c")); // Culture-insensitive
                case JTokenType.Date:
                    return Value.ForString(token.Value<DateTime>().ToString("o")); // Culture-insensitive
                case JTokenType.Bytes:
                    var bytes = token.Value<byte[]>();
                    var str = string.Join(",", bytes.Take(32).Select(x => x.ToString("x02")));
                    if (bytes.Length > 32)
                    {
                        str += $"...(length:{bytes.Length})";
                    }
                    return Value.ForString(str);
                case JTokenType.Guid:
                    return Value.ForString(token.Value<Guid>().ToString("B")); // Culture-insensitive
                case JTokenType.Uri:
                    return Value.ForString(token.Value<Uri>().ToString()); // Culture-insensitive
                default:
                    throw new InvalidOperationException($"Unexpected token of type: {token.Type}");
            }
        }
    }
}
