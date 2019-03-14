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
    internal class Class
    {
        public static IEnumerable<Diff> Diffs(TypeDefinition o, TypeDefinition n)
        {
            var cls = new Class(o, n);
            var classAndInterface = new ClassAndInterface(o, n);
            return Enumerable.Empty<Diff>()
                .Concat(cls.SealedAbstractStatic())
                .Concat(cls.BaseType())
                .Concat(classAndInterface.ImplementedInterfaces())
                .Concat(classAndInterface.GenericConstraints())
                .Concat(classAndInterface.Methods(TypeType.Class))
                .Concat(cls.Properties());
        }

        private Class(TypeDefinition o, TypeDefinition n) => (_o, _n) = (o, n);

        // _o is the original definition; _n is the new definition.
        private readonly TypeDefinition _o;
        private readonly TypeDefinition _n;

        private IEnumerable<Diff> SealedAbstractStatic()
        {
            var oInstantiable = _o.Ctors().Any(ctor => ctor.IsPublic);
            var oDerivable = _o.Ctors().Any(ctor => ctor.IsExported());
            var toStatic = !_o.IsStatic() && _n.IsStatic();
            var toAbstract = !_o.IsAbstractOnly() && oInstantiable && _n.IsAbstractOnly();
            var toSealed = !_o.IsSealedOnly() && oDerivable && _n.IsSealedOnly();
            if (toStatic || toAbstract || toSealed)
            {
                yield return Diff.Major(Cause.ClassModifierChanged, $"Class '{_o.Show()}' modifiers changed from '{_o.ShowSas()}' to '{_n.ShowSas()}'");
            }
            var nInstantiable = _n.Ctors().Any(ctor => ctor.IsPublic);
            var _nDerivable = _n.Ctors().Any(ctor => ctor.IsExported());
            var fromStatic = _o.IsStatic() && !_n.IsStatic() && _nDerivable;
            var fromAbstract = _o.IsAbstractOnly() && !_n.IsAbstractOnly() && nInstantiable;
            var fromSealed = _o.IsSealedOnly() && !_n.IsSealedOnly() && _nDerivable;
            if (fromStatic || fromAbstract || fromSealed)
            {
                yield return Diff.Minor(Cause.ClassModifierChanged, $"Class '{_n.Show()} modifiers changed from '{_o.ShowSas()}' to '{_n.ShowSas()}'");
            }
        }

        private IEnumerable<Diff> BaseType()
        {
            // If it's abstract then any base-class change is a major change, as non-overridden methods can percolate through this class.
            // Changing base-class to a more-derived class is a minor change.
            //   We only check only if initial base-class was `object`, as we only have this one dll loaded, so cannot check full class derivation.
            // Any other change is a major change.
            if (!SameTypeComparer.Instance.Equals(_o.BaseType, _n.BaseType))
            {
                if (_o.BaseType.IsObject() && !_n.IsAbstractOnly())
                {
                    yield return Diff.Minor(Cause.ClassBaseClassChanged, $"Class '{_n.Show()} changed base-class from '{_o.BaseType.Show()}' to '{_n.BaseType.Show()}'");
                }
                else
                {
                    yield return Diff.Major(Cause.ClassBaseClassChanged, $"Class '{_n.Show()} changed base-class from '{_o.BaseType.Show()}' to '{_n.BaseType.Show()}'");
                }
            }
        }

        private IEnumerable<Diff> Properties()
        {
            var oProps = _o.Properties.ToImmutableHashSet(SamePropertyComparer.Instance);
            var nProps = _n.Properties.ToImmutableHashSet(SamePropertyComparer.Instance);
            foreach (var prop in oProps.Union(nProps).OrderBy(x => x.FullName))
            {
                var inO = oProps.TryGetValue(prop, out var o);
                var inN = nProps.TryGetValue(prop, out var n);
                string ShowPrefix() => $"{_o.TypeType().Show()} '{_o.Show()}'; property '{o.Show()}'";
                if (inO && inN && o.IsExported() && n.IsExported())
                {
                    // Property present and exported in both types.
                    if (o.IsStatic() && !n.IsStatic())
                    {
                        yield return Diff.Major(Cause.PropertyMadeNonStatic, $"{ShowPrefix()} made non-static.");
                    }
                    else if (!o.IsStatic() && n.IsStatic())
                    {
                        yield return Diff.Major(Cause.PropertyMadeStatic, $"{ShowPrefix()} made static.");
                    }
                    if (!SameTypeComparer.Instance.Equals(o.PropertyType, n.PropertyType))
                    {
                        yield return Diff.Major(Cause.PropertyTypeChanged, $"{ShowPrefix()} return type changed to '{n.PropertyType.Show()}'.");
                    }
                    // No need to check parameter names, or in/out/ref.
                    // TODO: abstract/virtual/sealed.
                    // TODO: changes of get/set visibility.
                }
                else
                {
                    // Presence/visibility changes.
                    if (inO && o.IsExported())
                    {
                        yield return inN ?
                            Diff.Major(Cause.PropertyMadeNotExported, $"{ShowPrefix()} made non-public.") :
                            Diff.Major(Cause.PropertyRemoved, $"{ShowPrefix()} removed.");
                    }
                    else if (inN && n.IsExported())
                    {
                        yield return inO ?
                            Diff.Minor(Cause.PropertyMadeExported, $"{ShowPrefix()} made public.") :
                            Diff.Minor(Cause.PropertyAdded, $"{ShowPrefix()} added.");
                    }
                }
            }
        }
    }
}
