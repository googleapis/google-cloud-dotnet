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
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace Google.Cloud.Tools.VersionCompat.Detectors
{
    internal class TopLevel
    {
        public static IEnumerable<Diff> Diffs(IReadOnlyList<TypeDefinition> olderTypes, IReadOnlyList<TypeDefinition> newerTypes)
        {
            var oSet = olderTypes.ToImmutableHashSet<TypeDefinition>(SameTypeComparer.Instance);
            var nSet = newerTypes.ToImmutableHashSet<TypeDefinition>(SameTypeComparer.Instance);
            foreach (var t in oSet.Union(nSet).OrderBy(x => x.FullName))
            {
                var inO = oSet.TryGetValue(t, out var o);
                var inN = nSet.TryGetValue(t, out var n);
                var oType = inO ? o.TypeType() : TypeType.None;
                var nType = inN ? n.TypeType() : TypeType.None;
                if (inO && inN && o.IsExported() && n.IsExported())
                {
                    // Both types present and exported; check for differences.
                    if (oType != nType)
                    {
                        // Type of type changed.
                        yield return Diff.Major(Cause.TypeTypeChanged, $"'{o}' changed type from {oType} to {nType}.");
                    }
                    else
                    {
                        // Types both exported, and both same. Check inside.
                        IEnumerable<Diff> typeDiffs;
                        switch (oType)
                        {
                            case TypeType.Class: typeDiffs = Class.Diffs(o, n); break;
                            case TypeType.Struct: typeDiffs = Struct.Diffs(o, n); break;
                            case TypeType.Interface: typeDiffs = Interface.Diffs(o, n); break;
                            case TypeType.Enum: typeDiffs = Enum.Diffs(o, n); break;
                            case TypeType.Delegate:
                                // TODO!
                                typeDiffs = Enumerable.Empty<Diff>();
                                break;
                            default:
                                throw new InvalidOperationException($"Cannot diff types of type: {oType}.");
                        }
                        foreach (var typeDiff in typeDiffs)
                        {
                            yield return typeDiff;
                        }
                    }
                }
                else
                {
                    // Presence/visibility changes.
                    if (inO && o.IsExported())
                    {
                        yield return inN ?
                            Diff.Major(Cause.TypeMadeNotExported, $"{oType} '{o}' made non-public.") :
                            Diff.Major(Cause.TypeRemoved, $"{oType} '{o}' removed.");
                    }
                    else if (inN && n.IsExported())
                    {
                        yield return inO ?
                            Diff.Minor(Cause.TypeMadeExported, $"{nType} '{n}' made public.") :
                            Diff.Minor(Cause.TypeAdded, $"{nType} '{n}' added."); ;
                    }
                }
            }
        }
    }
}
