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
    /// TypeReference comparer that compares types in the same way that the C#
    /// compiler considers types to be the same. I.e. if the C# compiler allows two
    /// types to be defined in the same namespace, then this comparer will consider them
    /// separate types; conversly if the C# compiler considers them the same, so it's
    /// an error to define them both in the same namespace, then this comparer will consider
    /// the two types the same.
    /// </summary>
    internal class SameTypeComparer : IEqualityComparer<TypeReference>
    {
        public static SameTypeComparer Instance { get; } = new SameTypeComparer();
        private SameTypeComparer() { }
        public bool Equals(TypeReference x, TypeReference y)
        {
            if (x is null && y is null)
            {
                return true;
            }
            if (x is null || y is null)
            {
                return false;
            }
            var xName = x.Name.Split(' ')[0]; // Required because `modreq(...)` and `modopt(...)` are appended after a space
            var yName = y.Name.Split(' ')[0]; // to the type name, but do not become part of the method signature for overloads.
            if (x.Namespace != y.Namespace || xName != yName || !Equals(x.DeclaringType, y.DeclaringType))
            {
                return false;
            }
            if (x is GenericInstanceType xg && y is GenericInstanceType yg)
            {
                // If names are the same, then they will have the same number of generic parameters
                // because the generic parameter count is encoded in the name. E.g. List`1 for a List<AnyType>
                if (!xg.GenericArguments.SequenceEqual(yg.GenericArguments, this))
                {
                    return false;
                }
            }
            return true;
        }
        public int GetHashCode(TypeReference obj) => obj?.FullName.GetHashCode() ?? 0;
    }
}
