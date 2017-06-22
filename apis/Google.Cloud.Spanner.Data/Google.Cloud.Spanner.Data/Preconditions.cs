// Copyright 2017 Google Inc. All Rights Reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Linq;

namespace Google.Cloud.Spanner.Data
{
    internal static class Preconditions
    {
        public static void AssertOneOf(this object argument, string nameofArg, params object[] values)
        {
            AssertOneOf(argument, nameofArg, "", values);
        }

        public static void AssertOneOf(this object argument, string nameofArg, string detail, params object[] values)
        {
            if (values == null || !values.Any(x => Equals(argument, x)))
            {
                throw new ArgumentException($"Invalid value for {nameofArg}. {detail}");
            }
        }
    }
}
