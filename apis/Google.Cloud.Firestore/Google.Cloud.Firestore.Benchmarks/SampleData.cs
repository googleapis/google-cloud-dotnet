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

using Google.Cloud.Firestore.V1;
using System.Collections.Generic;
using System.Dynamic;

namespace Google.Cloud.Firestore.Benchmarks
{
    internal class SampleData
    {
        // We have the same data in multiple POCO formats, then serialized as both a map and a single value.
        internal static HighScore Attributed { get; } = new HighScore("Alice", 20, 100);
        internal static object Anonymous { get; } = new { Name = "Alice", Level = 20, Score = 100 };
        internal static object Dictionary { get; } = new Dictionary<string, object>
        {
            { "Name", "Alice" },
            { "Level", 20 },
            { "Score", 100 }
        };

        internal static ExpandoObject Expando { get; } = CreateExpando();
        internal static Value Serialized { get; } = ValueSerializer.Serialize(SerializationContext.Default, Attributed);
        internal static Dictionary<string, Value> SerializedMap { get; } = ValueSerializer.SerializeMap(SerializationContext.Default, Attributed);

        // Expandos don't work well with object initializers :(
        private static ExpandoObject CreateExpando()
        {
            dynamic expando = new ExpandoObject();
            expando.Name = "Alice";
            expando.Level = 20;
            expando.Score = 100;
            return expando;
        }
    }
}
