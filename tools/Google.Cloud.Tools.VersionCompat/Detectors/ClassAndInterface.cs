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
using System;
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

        public IEnumerable<Diff> GenericConstraints() =>
            GenericConstraints(isType: true, $"{_n.TypeType().Show()} '{_n.Show()}'", _o.GenericParameters, _n.GenericParameters);

        private IEnumerable<Diff> GenericConstraints(bool isType, string prefix,
            IList<GenericParameter> oGenericParameters, IList<GenericParameter> nGenericParameters)
        {
            var (causeConstraint, causeVariance) = isType ?
                (Cause.TypeGenericConstraintChanged, Cause.TypeGenericVarianceChanged) :
                (Cause.MethodGenericConstraintChanged, Cause.MethodGenericVarianceChanged);
            foreach (var (o, n) in oGenericParameters.Zip(nGenericParameters))
            {
                if ((!o.HasReferenceTypeConstraint && n.HasReferenceTypeConstraint) ||
                    (!o.HasNotNullableValueTypeConstraint && n.HasNotNullableValueTypeConstraint) ||
                    (!o.HasDefaultConstructorConstraint && n.HasDefaultConstructorConstraint) ||
                    !n.Constraints.ToImmutableHashSet(SameTypeComparer.Instance).IsSubsetOf(o.Constraints))
                {
                    yield return Diff.Major(causeConstraint, $"{prefix} changed constraint on generic parameter '{n.Show()}'");
                }
                if ((!n.HasReferenceTypeConstraint && o.HasReferenceTypeConstraint) ||
                    (!n.HasNotNullableValueTypeConstraint && o.HasNotNullableValueTypeConstraint) ||
                    (!n.HasDefaultConstructorConstraint && o.HasDefaultConstructorConstraint) ||
                    !o.Constraints.ToImmutableHashSet(SameTypeComparer.Instance).IsSubsetOf(n.Constraints))
                {
                    yield return Diff.Minor(causeConstraint, $"{prefix} changed constraint on generic parameter '{n.Show()}'");
                }
                if ((o.IsCovariant && !n.IsCovariant) || (o.IsContravariant && !n.IsContravariant))
                {
                    yield return Diff.Major(causeVariance, $"{prefix} changed variance on generic parameter '{n.Show()}'");
                }
                if ((!o.IsCovariant && n.IsCovariant) || (o.IsContravariant && !n.IsContravariant))
                {
                    yield return Diff.Minor(causeVariance, $"{prefix} changed variance on generic parameter '{n.Show()}'");
                }
            }
        }

        private IEnumerable<Diff> MethodModifiers(MethodDefinition o, MethodDefinition n, Cause cause, string prefix)
        {
            if ((o.IsVirtual && !n.IsVirtual) ||
                (!o.IsAbstract && n.IsAbstract) ||
                (!o.IsFinal && n.IsFinal))
            {
                yield return Diff.Major(cause, $"{prefix} modifiers changed from '{o.ShowModifiers()}' to '{n.ShowModifiers()}'.");
            }
            if ((!o.IsVirtual && n.IsVirtual) ||
                (o.IsAbstract && !n.IsAbstract) ||
                (o.IsFinal && !n.IsFinal))
            {
                yield return Diff.Minor(cause, $"{prefix} modifers changed from '{o.ShowModifiers()}' to '{n.ShowModifiers()}'.");
            }
        }

        public IEnumerable<Diff> Methods(TypeType typeType)
        {
            var oMethods = _o.Methods.Where(x => !x.IsGetter && !x.IsSetter).ToImmutableHashSet(SameMethodComparer.Instance);
            var nMethods = _n.Methods.Where(x => !x.IsGetter && !x.IsSetter).ToImmutableHashSet(SameMethodComparer.Instance);
            foreach (var method in oMethods.Union(nMethods).OrderBy(x => x.FullName).ThenBy(x => x.Parameters.Count))
            {
                var inO = oMethods.TryGetValue(method, out var o);
                var inN = nMethods.TryGetValue(method, out var n);
                var prefix = $"{_o.TypeType().Show()} '{_o.Show()}'; method '{o.Show()}'";
                if (inO && inN && o.IsExported() && n.IsExported())
                {
                    if (typeType == TypeType.Class)
                    {
                        // Method present and exported in both types.
                        if (o.IsStatic && !n.IsStatic)
                        {
                            yield return Diff.Major(Cause.MethodMadeNonStatic, $"{prefix} made non-static.");
                        }
                        else if (!o.IsStatic && n.IsStatic)
                        {
                            yield return Diff.Major(Cause.MethodMadeStatic, $"{prefix} made static.");
                        }
                        else
                        {
                            foreach (var diff in MethodModifiers(o, n, Cause.MethodModifierChanged, prefix))
                            {
                                yield return diff;
                            }
                        }
                    }
                    if (!SameTypeComparer.Instance.Equals(o.ReturnType, n.ReturnType))
                    {
                        yield return Diff.Major(Cause.MethodReturnTypeChanged, $"{prefix} return type changed to '{n.ReturnType.Show()}'.");
                    }
                    foreach (var (oParam, nParam) in o.Parameters.Zip(n.Parameters))
                    {
                        if (oParam.Name != nParam.Name)
                        {
                            yield return Diff.Major(Cause.MethodParameterNameChanged,
                                $"{prefix} parameter name changed from '{oParam.Name}' to '{nParam.Name}'.");
                        }
                        if (oParam.IsIn != nParam.IsIn || oParam.IsOut != nParam.IsOut)
                        {
                            yield return Diff.Major(Cause.MethodParameterInOutChanged,
                                $"{prefix} parameter '{oParam.Name}' changed from '{oParam.ShowInOut()}' to '{nParam.ShowInOut()}'.");
                        }
                    }
                    foreach (var diff in GenericConstraints(isType: false, prefix, o.GenericParameters, n.GenericParameters))
                    {
                        yield return diff;
                    }
                }
                else
                {
                    // Presence/visibility changes.
                    if (inO && o.IsExported())
                    {
                        yield return inN ?
                            Diff.Major(Cause.MethodMadeNotExported, $"{prefix} made non-public.") :
                            Diff.Major(Cause.MethodRemoved, $"{prefix} removed.");
                    }
                    else if (inN && n.IsExported())
                    {
                        var diff = typeType == TypeType.Class ? (Func<Cause, string, Diff>)Diff.Minor : Diff.Major;
                        yield return inO ?
                            diff(Cause.MethodMadeExported, $"{prefix} made public.") :
                            diff(Cause.MethodAdded, $"{prefix} added.");
                    }
                }
            }
        }

        public IEnumerable<Diff> Properties(TypeType typeType)
        {
            var oProps = _o.Properties.ToImmutableHashSet(SamePropertyComparer.Instance);
            var nProps = _n.Properties.ToImmutableHashSet(SamePropertyComparer.Instance);
            foreach (var prop in oProps.Union(nProps).OrderBy(x => x.FullName))
            {
                var inO = oProps.TryGetValue(prop, out var o);
                var inN = nProps.TryGetValue(prop, out var n);
                var prefix = $"{_o.TypeType().Show()} '{_o.Show()}'; property '{o.Show()}'";
                if (inO && inN && o.IsExported() && n.IsExported())
                {
                    if (typeType == TypeType.Class)
                    {
                        // Property present and exported in both types.
                        if (o.IsStatic() && !n.IsStatic())
                        {
                            yield return Diff.Major(Cause.PropertyMadeNonStatic, $"{prefix} made non-static.");
                        }
                        else if (!o.IsStatic() && n.IsStatic())
                        {
                            yield return Diff.Major(Cause.PropertyMadeStatic, $"{prefix} made static.");
                        }
                        else
                        {
                            var oMethod = o.GetMethod ?? o.SetMethod;
                            var nMethod = n.GetMethod ?? n.SetMethod;
                            foreach (var diff in MethodModifiers(oMethod, nMethod, Cause.PropertyModifierChanged, prefix))
                            {
                                yield return diff;
                            }
                        }
                    }
                    if (!SameTypeComparer.Instance.Equals(o.PropertyType, n.PropertyType))
                    {
                        yield return Diff.Major(Cause.PropertyTypeChanged, $"{prefix} return type changed to '{n.PropertyType.Show()}'.");
                    }
                    // No need to check parameter names, or in/out/ref.
                    // TODO: changes of get/set visibility.
                }
                else
                {
                    // Presence/visibility changes.
                    if (inO && o.IsExported())
                    {
                        yield return inN ?
                            Diff.Major(Cause.PropertyMadeNotExported, $"{prefix} made non-public.") :
                            Diff.Major(Cause.PropertyRemoved, $"{prefix} removed.");
                    }
                    else if (inN && n.IsExported())
                    {
                        yield return inO ?
                            Diff.Minor(Cause.PropertyMadeExported, $"{prefix} made public.") :
                            Diff.Minor(Cause.PropertyAdded, $"{prefix} added.");
                    }
                }
            }
        }
    }
}
