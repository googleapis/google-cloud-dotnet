// Copyright 2020 Google LLC
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

using System;
using Newtonsoft.Json;

namespace Google.Cloud.Logging.NLog
{
    /// <summary>
    /// JSON converter that just calls ToString on the target value (when non-null).
    /// This is configured as the converter for types that will otherwise spew a lot of irrelevant JSON
    /// into logs.
    /// </summary>
    internal sealed class ToStringJsonConverter : JsonConverter
    {
        private readonly System.Type _type;

        /// <inheritdoc />
        public override bool CanRead => false;

        public ToStringJsonConverter(System.Type type) =>
            _type = type;

        /// <inheritdoc />
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(value.ToString());
            }
        }

        /// <inheritdoc />
        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer) =>
            throw new NotSupportedException("Only serialization is supported");

        /// <inheritdoc />
        public override bool CanConvert(System.Type objectType) =>
            _type.IsAssignableFrom(objectType);
    }
}
