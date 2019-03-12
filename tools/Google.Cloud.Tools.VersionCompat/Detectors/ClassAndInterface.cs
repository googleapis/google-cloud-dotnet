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
using Google.Cloud.Tools.VersionCompat.Utils;
using Mono.Cecil;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace Google.Cloud.Tools.VersionCompat.Detectors
{
    internal class ClassAndInterface
    {
        public ClassAndInterface(TypeDefinition o, TypeDefinition n) => (_o, _n) = (o, n);

        // _o is the original definition; _n is the new definition.
        private readonly TypeDefinition _o;
        private readonly TypeDefinition _n;

        public IEnumerable<Diff> ImplementedInterfaces()
        {
            // Treat any change to exported implemented interfaces is breaking.
            // This isn't correct, as adding or removing an interface which an another interface itself implements is OK.
            //   But we can't check this as we only have this one dll loaded.
            var oExportedInterfaces = _o.Interfaces.Select(x => x.InterfaceType).Where(x => x.Def()?.IsExported() ?? true)
                .ToImmutableHashSet(SameTypeComparer.Instance);
            var nExportedInterfaces = _n.Interfaces.Select(x => x.InterfaceType).Where(x => x.Def()?.IsExported() ?? true)
                .ToImmutableHashSet(SameTypeComparer.Instance);
            foreach (var added in nExportedInterfaces.Except(oExportedInterfaces))
            {
                yield return Diff.Major(Cause.TypeImplementedInterfaceAdded, $"{_n.TypeType().Show()} '{_n.Show()}' implemented interface added '{added.Show()}'");
            }
            foreach (var removed in oExportedInterfaces.Except(nExportedInterfaces))
            {
                yield return Diff.Major(Cause.TypeImplementedInterfaceRemoved, $"{_n.TypeType().Show()} '{_n.Show()}' implemented interface removed '{removed.Show()}'");
            }
        }

        public IEnumerable<Diff> GenericConstraints()
        {
            foreach (var (o, n) in _o.GenericParameters.Zip(_n.GenericParameters))
            {
                if ((!o.HasReferenceTypeConstraint && n.HasReferenceTypeConstraint) ||
                    (!o.HasNotNullableValueTypeConstraint && n.HasNotNullableValueTypeConstraint) ||
                    (!o.HasDefaultConstructorConstraint && n.HasDefaultConstructorConstraint) ||
                    o.Constraints.ToImmutableHashSet(SameTypeComparer.Instance).IsProperSubsetOf(n.Constraints))
                {
                    yield return Diff.Major(Cause.TypeGenericConstraintChanged, $"{_n.TypeType().Show()} '{_n.Show()}' changed constraint on generic parameter '{n.Show()}'");
                }
                if ((!n.HasReferenceTypeConstraint && o.HasReferenceTypeConstraint) ||
                    (!n.HasNotNullableValueTypeConstraint && o.HasNotNullableValueTypeConstraint) ||
                    (!n.HasDefaultConstructorConstraint && o.HasDefaultConstructorConstraint) ||
                    n.Constraints.ToImmutableHashSet(SameTypeComparer.Instance).IsProperSubsetOf(o.Constraints))
                {
                    yield return Diff.Minor(Cause.TypeGenericConstraintChanged, $"{_n.TypeType().Show()} '{_n.Show()}' changed constraint on generic parameter '{n.Show()}'");
                }
                if ((o.IsCovariant && !n.IsCovariant) || (o.IsContravariant && !n.IsContravariant))
                {
                    yield return Diff.Major(Cause.TypeGenericVarianceChanged, $"{_n.TypeType().Show()} '{_n.Show()}' changed variance on generic parameter '{n.Show()}'");
                }
                if ((!o.IsCovariant && n.IsCovariant) || (o.IsContravariant && !n.IsContravariant))
                {
                    yield return Diff.Minor(Cause.TypeGenericVarianceChanged, $"{_n.TypeType().Show()} '{_n.Show()}' changed variance on generic parameter '{n.Show()}'");
                }
            }
        }
    }
}
