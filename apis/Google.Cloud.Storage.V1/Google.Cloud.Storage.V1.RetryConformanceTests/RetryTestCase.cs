// Copyright 2023 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License").
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at 
//
// https://www.apache.org/licenses/LICENSE-2.0 
//
// Unless required by applicable law or agreed to in writing, software 
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and 
// limitations under the License.

using Google.Cloud.Storage.V1.Tests.Conformance;
using System.Collections.Generic;
using System.Linq;

namespace Google.Cloud.Storage.V1.RetryConformanceTests;

/// <summary>
/// A single retry test case, created from a <see cref="RetryTest"/> but for
/// a single <see cref="Tests.Conformance.InstructionList"/> and <see cref="Tests.Conformance.Method"/> combination.
/// </summary>
public class RetryTestCase
{
    public RetryTest Test { get; }
    public InstructionList InstructionList { get; }
    public Method Method { get; }

    private RetryTestCase(RetryTest test, Method method, InstructionList instructionList)
    {
        Test = test;
        InstructionList = instructionList;
        Method = method;
    }

    public override string ToString() =>
        $"Test={Test.Id}:{Test.Description}; Method={Method.Name}; Instructions={string.Join(", ", InstructionList.Instructions)}";

    /// <summary>
    /// Flattens the given test into its constituent test cases.
    /// </summary>
    public static IEnumerable<RetryTestCase> Flatten(RetryTest test) =>
        from method in test.Methods
        from instructionList in test.Cases
        select new RetryTestCase(test, method, instructionList);
}
