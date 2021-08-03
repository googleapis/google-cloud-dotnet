// Copyright 2021 Google LLC
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
using System.Collections.Immutable;
using System.Linq;

namespace Google.Cloud.Tools.VersionCompat.CecilUtils
{
    /// <summary>
    /// GenericParameterConstraint comparer that compares GenericParameterConstraint
    /// on their ConstraintType using the SameTypeComparar and on the types of the 
    /// CustomAttributes.
    /// See https://github.com/dotnet/roslyn/issues/29997
    /// </summary>
    internal class SameGenericParameterConstraintComparer : IEqualityComparer<GenericParameterConstraint>
    {
        public static SameGenericParameterConstraintComparer Instance { get; } = new SameGenericParameterConstraintComparer();

        private SameGenericParameterConstraintComparer() { }

        public bool Equals(GenericParameterConstraint x, GenericParameterConstraint y)
        {
            if (x is null && y is null)
            {
                return true;
            }
            if (x is null || y is null)
            {
                return false;
            }

            return SameTypeComparer.Instance.Equals(x.ConstraintType, y.ConstraintType)
                && x.CustomAttributes.Select(attr => attr.AttributeType).ToImmutableHashSet(SameTypeComparer.Instance)
                    .SetEquals(y.CustomAttributes.Select(attr => attr.AttributeType).ToImmutableHashSet(SameTypeComparer.Instance));
        }

        public int GetHashCode(GenericParameterConstraint obj)
        {
            if (obj is null)
            {
                return 0;
            }
            var hashCode = SameTypeComparer.Instance.GetHashCode(obj?.ConstraintType);
            foreach (var typ in obj.CustomAttributes.Select(attr => attr.AttributeType).ToImmutableHashSet(SameTypeComparer.Instance).OrderBy(typ => typ.FullName))
            {
                hashCode ^= SameTypeComparer.Instance.GetHashCode(typ);
            }

            return hashCode;
        }
    }
}
