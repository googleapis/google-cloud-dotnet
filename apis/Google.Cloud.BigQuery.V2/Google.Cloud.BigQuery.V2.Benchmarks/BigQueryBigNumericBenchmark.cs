// Copyright 2022 Google LLC
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
    public class BigQueryBigNumericBenchmark
    {
        private static readonly BigQueryBigNumeric HugeSample = BigQueryBigNumeric.Parse("123456789012345678901234567890123456789.12345678901234567890123456789012345678");
        private static readonly BigQueryBigNumeric MediumSample = (BigQueryBigNumeric) 12345.1234567890123456789m;
        private static readonly BigQueryBigNumeric IntegerSample = 12345;

        [Benchmark]
        public BigQueryBigNumeric Parse_Huge() => BigQueryBigNumeric.Parse("123456789012345678901234567890123456789.12345678901234567890123456789012345678");

        [Benchmark]
        public BigQueryBigNumeric Parse_Medium() => BigQueryBigNumeric.Parse("12345.1234567890123456789");

        [Benchmark]
        public BigQueryBigNumeric Parse_Integer() => BigQueryBigNumeric.Parse("12345");

        [Benchmark]
        public BigQueryBigNumeric DecimalConversion() => (BigQueryBigNumeric)12345.1234567890123456789m;

        [Benchmark]
        public BigQueryBigNumeric UInt64Conversion() => ulong.MaxValue;

        [Benchmark]
        public BigQueryBigNumeric Int64Conversion() => long.MaxValue;

        [Benchmark]
        public string ToString_Huge() => HugeSample.ToString();

        [Benchmark]
        public string ToString_Medium() => MediumSample.ToString();

        [Benchmark]
        public string ToString_Integer() => IntegerSample.ToString();

        [Benchmark]
        public decimal ToDecimal_Medium() => MediumSample.ToDecimal(LossOfPrecisionHandling.Throw);

        [Benchmark]
        public decimal ToDecimal_Integer() => IntegerSample.ToDecimal(LossOfPrecisionHandling.Throw);

        [Benchmark]
        public BigQueryBigNumeric Addition() => HugeSample + MediumSample;

        [Benchmark]
        public BigQueryBigNumeric Subtraction() => HugeSample - MediumSample;

        [Benchmark]
        public BigQueryBigNumeric UnaryNegation() => -HugeSample;
    }
}
