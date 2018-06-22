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

namespace Google.Cloud.BigQuery.V2.Benchmarks
{
    public class BigQueryNumericBenchmark
    {
        private static readonly BigQueryNumeric HugeSample = BigQueryNumeric.Parse("12345678901234567890123456789.123456789");
        private static readonly BigQueryNumeric MediumSample = (BigQueryNumeric) 12345.12345m;
        private static readonly BigQueryNumeric IntegerSample = 12345;

        [Benchmark]
        public BigQueryNumeric Parse_Huge() => BigQueryNumeric.Parse("12345678901234567890123456789.123456789");

        [Benchmark]
        public BigQueryNumeric Parse_Medium() => BigQueryNumeric.Parse("12345.12345");

        [Benchmark]
        public BigQueryNumeric Parse_Integer() => BigQueryNumeric.Parse("12345");

        [Benchmark]
        public BigQueryNumeric FromDecimal() => BigQueryNumeric.FromDecimal(12345.12345m, LossOfPrecisionHandling.Throw);

        [Benchmark]
        public BigQueryNumeric DecimalConversion() => (BigQueryNumeric)12345.12345m;

        [Benchmark]
        public BigQueryNumeric UInt64Conversion() => ulong.MaxValue;

        [Benchmark]
        public BigQueryNumeric Int64Conversion() => long.MaxValue;

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
        public BigQueryNumeric Addition() => HugeSample + MediumSample;

        [Benchmark]
        public BigQueryNumeric Subtraction() => HugeSample - MediumSample;

        [Benchmark]
        public BigQueryNumeric UnaryNegation() => -HugeSample;
    }
}
