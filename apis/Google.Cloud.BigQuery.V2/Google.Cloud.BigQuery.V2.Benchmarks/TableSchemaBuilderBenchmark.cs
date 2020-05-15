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

using BenchmarkDotNet.Attributes;

namespace Google.Cloud.BigQuery.V2.Benchmarks
{
    public class TableSchemaBuilderBenchmark
    {
        private const string ShortFieldName = "abc";
        private const string LongFieldName = "abcdefghijklmnopqrstuvwxyz1234567890_ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        [Benchmark]
        public void ValidateFieldName_Short() => TableSchemaBuilder.ValidateFieldName(ShortFieldName, "param");

        [Benchmark]
        public void ValidateFieldName_Long() => TableSchemaBuilder.ValidateFieldName(LongFieldName, "param");
    }
}
