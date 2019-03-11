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

namespace Google.Cloud.Tools.VersionCompat.CecilUtils
{
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
            if (x.FullName != y.FullName)
            {
                return false;
            }
            // If names are the same, then they will have the same number of generic parameters
            // because the generic parameter count is encoded in the name. E.g. List`1 for a List<AnyType>
            for (int i =0; i<x.GenericParameters.Count;i++)
            {
                if (!Equals(x.GenericParameters[i], y.GenericParameters[i]))
                {
                    return false;
                }
            }
            return true;
        }
        public int GetHashCode(TypeReference obj) => obj?.FullName.GetHashCode() ?? 0;
    }
}
