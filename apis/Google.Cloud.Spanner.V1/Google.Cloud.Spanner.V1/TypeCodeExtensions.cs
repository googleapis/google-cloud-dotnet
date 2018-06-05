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
using System.Collections.Generic;
using System.Linq;
using Google.Api.Gax;

namespace Google.Cloud.Spanner.V1
{
    /// <summary>
    /// Extension methods and factory methods for type codes.
    /// </summary>
    public static class TypeCodeExtensions
    {
        private static readonly Dictionary<string, TypeCode> s_originalNameToCode
            = Enum.GetValues(typeof(TypeCode)).Cast<TypeCode>().ToDictionary(code => code.GetOriginalName());

        /// <summary>
        /// Returns the original name of a <see cref="TypeCode" />, as specified in the proto file.
        /// </summary>
        /// <param name="typeCode">The type code to retrieve the original name of.</param>
        /// <returns>The original name of the type code.</returns>
        public static string GetOriginalName(this TypeCode typeCode) =>
            typeCode.ToString().ToUpperInvariant();

        /// <summary>
        /// Returns a TypeCode given its original string representation.
        /// </summary>
        /// <param name="originalName">The original name to retrieve the type code from. Must not be null.</param>
        /// <returns>The type code corresponding to the given name, or <see cref="TypeCode.Unspecified"/> if there is no such type code.</returns>
        public static TypeCode GetTypeCode(string originalName)
        {
            GaxPreconditions.CheckNotNull(originalName, nameof(originalName));
            return s_originalNameToCode.TryGetValue(originalName.Trim(), out var typeCode)
                ? typeCode
                : TypeCode.Unspecified;
        }
    }
}
