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
using System.Linq;

namespace Google.Cloud.Tools.VersionCompat.Detectors
{
    internal class Class
    {
        public static IEnumerable<Diff> Diffs(TypeDefinition o, TypeDefinition n)
        {
            var cls = new Class(o, n);
            var classStructInterface = new ClassStructInterface(o, n);
            // TODO: Check (instance) constructors
            return Enumerable.Empty<Diff>()
                .Concat(cls.SealedAbstractStatic())
                .Concat(cls.BaseType())
                .Concat(classStructInterface.ImplementedInterfaces())
                .Concat(classStructInterface.GenericConstraints())
                .Concat(classStructInterface.Ctors(TypeType.Class))
                .Concat(classStructInterface.Methods(TypeType.Class))
                .Concat(classStructInterface.Properties(TypeType.Class))
                .Concat(classStructInterface.Obsoleteness());
        }

        private Class(TypeDefinition o, TypeDefinition n) => (_o, _n) = (o, n);

        // _o is the original definition; _n is the new definition.
        private readonly TypeDefinition _o;
        private readonly TypeDefinition _n;

        private IEnumerable<Diff> SealedAbstractStatic()
        {
            var oInstantiable = _o.InstanceCtors().Any(ctor => ctor.IsPublic);
            var oDerivable = _o.InstanceCtors().Any(ctor => ctor.IsExported());
            var toStatic = !_o.IsStatic() && _n.IsStatic();
            var toAbstract = !_o.IsAbstractOnly() && oInstantiable && _n.IsAbstractOnly();
            var toSealed = !_o.IsSealedOnly() && oDerivable && _n.IsSealedOnly();
            if (toStatic || toAbstract || toSealed)
            {
                yield return Diff.Major(Cause.ClassModifierChanged, $"Class '{_o}' modifiers changed from '{_o.ShowSas()}' to '{_n.ShowSas()}'");
            }
            var nInstantiable = _n.InstanceCtors().Any(ctor => ctor.IsPublic);
            var _nDerivable = _n.InstanceCtors().Any(ctor => ctor.IsExported());
            var fromStatic = _o.IsStatic() && !_n.IsStatic() && _nDerivable;
            var fromAbstract = _o.IsAbstractOnly() && !_n.IsAbstractOnly() && nInstantiable;
            var fromSealed = _o.IsSealedOnly() && !_n.IsSealedOnly() && _nDerivable;
            if (fromStatic || fromAbstract || fromSealed)
            {
                yield return Diff.Minor(Cause.ClassModifierChanged, $"Class '{_n} modifiers changed from '{_o.ShowSas()}' to '{_n.ShowSas()}'");
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
                    yield return Diff.Minor(Cause.ClassBaseClassChanged, $"Class '{_n}' changed base-class from '{_o.BaseType}' to '{_n.BaseType}'");
                }
                else
                {
                    yield return Diff.Major(Cause.ClassBaseClassChanged, $"Class '{_n}' changed base-class from '{_o.BaseType}' to '{_n.BaseType}'");
                }
            }
        }
    }
}
