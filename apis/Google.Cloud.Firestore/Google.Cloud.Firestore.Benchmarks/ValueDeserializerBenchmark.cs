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

using BenchmarkDotNet.Attributes;
using System.Collections.Generic;
using System.Dynamic;

namespace Google.Cloud.Firestore.Benchmarks
{
    public class ValueDeserializerBenchmark
    {
        public static FirestoreDb FakeDb { get; } =
            FirestoreDb.Create("project", "database", new FakeFirestoreClient());

        private static DeserializationContext Context => new DeserializationContext(FakeDb.Document("a/b"));

        [Benchmark]
        public object DeserializeMap_Attributed() =>
            ValueDeserializer.DeserializeMap(Context, SampleData.SerializedMap, typeof(HighScore));

        [Benchmark]
        public object Deserialize_Attributed() =>
            ValueDeserializer.Deserialize(Context, SampleData.Serialized, typeof(HighScore));

        [Benchmark]
        public object DeserializeMap_Dictionary() =>
            ValueDeserializer.DeserializeMap(Context, SampleData.SerializedMap, typeof(Dictionary<string, object>));

        [Benchmark]
        public object Deserialize_Dictionary() =>
            ValueDeserializer.Deserialize(Context, SampleData.Serialized, typeof(Dictionary<string, object>));

        [Benchmark]
        public object DeserializeMap_Expando() =>
            ValueDeserializer.DeserializeMap(Context, SampleData.SerializedMap, typeof(ExpandoObject));

        [Benchmark]
        public object Deserialize_Expando() =>
            ValueDeserializer.Deserialize(Context, SampleData.Serialized, typeof(ExpandoObject));
    }
}
