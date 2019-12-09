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

using Google.Cloud.Tools.VersionCompat.CecilUtils;
using Mono.Cecil;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace Google.Cloud.Tools.VersionCompat.Detectors
{
    internal class Enum
    {
        public static IEnumerable<Diff> Diffs(TypeDefinition o, TypeDefinition n)
        {
            var oUnderlyingType = o.Fields.First(x => x.Name == "value__").FieldType;
            var nUnderlyingType = n.Fields.First(x => x.Name == "value__").FieldType;
            if (!SameTypeComparer.Instance.Equals(oUnderlyingType, nUnderlyingType))
            {
                yield return Diff.Major(Cause.EnumUnderlyingTypeChanged,
                    $"Enum '{o}' underlying type changed from '{o.GetElementType()}' to '{n.GetElementType()}'.");
            }
            var oEntries = o.Fields.Where(x => x.IsStatic).ToImmutableHashSet(SameFieldComparer.Instance);
            var nEntries = n.Fields.Where(x => x.IsStatic).ToImmutableHashSet(SameFieldComparer.Instance);
            foreach (var entry in oEntries.Union(nEntries))
            {
                var inO = oEntries.TryGetValue(entry, out var oEntry);
                var inN = nEntries.TryGetValue(entry, out var nEntry);
                if (inO && !inN)
                {
                    yield return Diff.Major(Cause.EnumValueRemoved, $"Enum '{o}' entry '{entry.Name}' removed.");
                }
                else if (inN && !inO)
                {
                    yield return Diff.Minor(Cause.EnumValueAdded, $"Enum '{o}' entry '{entry.Name}' added.");
                }
                else if (!Equals(oEntry.Constant, nEntry.Constant))
                {
                    yield return Diff.Major(Cause.EnumValueChanged,
                        $"Enum '{o}' entry '{entry.Name} value changed from {oEntry.Constant} to {nEntry.Constant}.");
                }
            }
            // TODO: Obsoleteness
        }
    }
}
