// Copyright 2019 Google LLC
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

using Mono.Cecil;
using System.Collections.Generic;
using System.Linq;

namespace Google.Cloud.Tools.VersionCompat.CecilUtils
{
    /// <summary>
    /// PropertyDefinition comparer that compares properties in the same way that the C#
    /// compiler considers properties to be the same. I.e. if the C# compiler allows two
    /// properties to be defined in the same class, then this comparer will consider them
    /// separate properties; conversly if the C# compiler considers them the same, so it's
    /// an error to define them both in the same class, then this comparer will consider
    /// the two properties the same.
    /// </summary>
    internal class SamePropertyComparer: IEqualityComparer<PropertyDefinition>
    {
        public static IEqualityComparer<PropertyDefinition> Instance { get; } = new SamePropertyComparer();
        private SamePropertyComparer() { }
        public bool Equals(PropertyDefinition x, PropertyDefinition y)
        {
            if (x is null && y is null)
            {
                return true;
            }
            if (x is null || y is null)
            {
                return false;
            }
            if (x.Name != y.Name)
            {
                return false;
            }
            if (x.Parameters.Count != y.Parameters.Count)
            {
                return false;
            }
            foreach (var (xParam, yParam) in x.Parameters.Zip(y.Parameters))
            {
                if (!SameTypeComparer.Instance.Equals(xParam.ParameterType, yParam.ParameterType))
                {
                    return false;
                }
            }
            return true;
        }
        public int GetHashCode(PropertyDefinition obj) => obj?.Name.GetHashCode() ?? 0;
    }
}
