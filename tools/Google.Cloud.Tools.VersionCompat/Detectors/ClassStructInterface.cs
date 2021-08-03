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
    internal class ClassStructInterface
    {
        public ClassStructInterface(TypeDefinition o, TypeDefinition n) => (_o, _n) = (o, n);

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
                if (_n.TypeType() == TypeType.Interface)
                {
                    yield return Diff.Major(Cause.TypeImplementedInterfaceAdded, $"{_n.TypeType()} '{_n}' implemented interface added '{added}'");
                }
                else
                {
                    yield return Diff.Minor(Cause.TypeImplementedInterfaceAdded, $"{_n.TypeType()} '{_n}' implemented interface added '{added}'");
                }
            }
            foreach (var removed in oExportedInterfaces.Except(nExportedInterfaces))
            {
                yield return Diff.Major(Cause.TypeImplementedInterfaceRemoved, $"{_n.TypeType()} '{_n}' implemented interface removed '{removed}'");
            }
        }

        public IEnumerable<Diff> GenericConstraints() =>
            GenericConstraints(isType: true, $"{_n.TypeType()} '{_n}'", _o.GenericParameters, _n.GenericParameters);

        private IEnumerable<Diff> GenericConstraints(bool isType, FormattableString prefix,
            IList<GenericParameter> oGenericParameters, IList<GenericParameter> nGenericParameters)
        {
            var (causeConstraint, causeVariance) = isType ?
                (Cause.TypeGenericConstraintChanged, Cause.TypeGenericVarianceChanged) :
                (Cause.MethodGenericConstraintChanged, Cause.MethodGenericVarianceChanged);
            foreach (var (o, n) in oGenericParameters.Zip(nGenericParameters))
            {
                // TODO: Check `unmanaged` constraint.
                if ((!o.HasReferenceTypeConstraint && n.HasReferenceTypeConstraint) ||
                    (!o.HasNotNullableValueTypeConstraint && n.HasNotNullableValueTypeConstraint) ||
                    (!o.HasDefaultConstructorConstraint && n.HasDefaultConstructorConstraint) ||
                    !n.Constraints.ToImmutableHashSet(SameGenericParameterConstraintComparer.Instance).IsSubsetOf(o.Constraints))
                {
                    yield return Diff.Major(causeConstraint, $"{prefix} changed constraint on generic parameter '{n}'");
                }
                if ((!n.HasReferenceTypeConstraint && o.HasReferenceTypeConstraint) ||
                    (!n.HasNotNullableValueTypeConstraint && o.HasNotNullableValueTypeConstraint) ||
                    (!n.HasDefaultConstructorConstraint && o.HasDefaultConstructorConstraint) ||
                    !o.Constraints.ToImmutableHashSet(SameGenericParameterConstraintComparer.Instance).IsSubsetOf(n.Constraints))
                {
                    yield return Diff.Minor(causeConstraint, $"{prefix} changed constraint on generic parameter '{n}'");
                }
                if ((o.IsCovariant && !n.IsCovariant) || (o.IsContravariant && !n.IsContravariant))
                {
                    yield return Diff.Major(causeVariance, $"{prefix} changed variance on generic parameter '{n}'");
                }
                if ((!o.IsCovariant && n.IsCovariant) || (o.IsContravariant && !n.IsContravariant))
                {
                    yield return Diff.Minor(causeVariance, $"{prefix} changed variance on generic parameter '{n}'");
                }
            }
        }

        private IEnumerable<Diff> MethodModifiers(MethodDefinition o, MethodDefinition n, Cause cause, FormattableString prefix)
        {
            if ((o.IsVirtual && !n.IsVirtual) ||
                (!o.IsAbstract && n.IsAbstract) ||
                (!o.IsFinal && n.IsFinal && o.IsVirtual))
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

        private IEnumerable<Diff> MethodAccessModifiers(MethodDefinition o, MethodDefinition n, Cause cause, FormattableString prefix)
        {
            var oIsCallable = o != null && o.IsPublic;
            var oIsDerivable = o != null && o.IsExported();
            var nIsCallable = n != null && n.IsPublic;
            var nIsDerivable = n != null && n.IsExported();
            if ((oIsCallable && !nIsCallable) || (oIsDerivable && !nIsDerivable))
            {
                yield return Diff.Major(cause, $"{prefix} access modifer changed from '{o.ShowAccessModifier()}' to '{n.ShowAccessModifier()}'.");
            }
            if ((!oIsCallable && nIsCallable) || (!oIsDerivable && nIsDerivable))
            {
                yield return Diff.Minor(cause, $"{prefix} access modifer changed from '{o.ShowAccessModifier()}' to '{n.ShowAccessModifier()}'.");
            }
        }

        public IEnumerable<Diff> Obsoleteness() => Obsoleteness(_o, _n, $"Class '{_o}'");

        private IEnumerable<Diff> Obsoleteness(ICustomAttributeProvider o, ICustomAttributeProvider n, FormattableString prefix)
        {
            var oObs = o.HasCustomAttributes ? o.CustomAttributes.FirstOrDefault(x => x.AttributeType.FullName == typeof(ObsoleteAttribute).FullName) : null;
            var oIsError = IsError(oObs);
            var nObs = n.HasCustomAttributes ? n.CustomAttributes.FirstOrDefault(x => x.AttributeType.FullName == typeof(ObsoleteAttribute).FullName) : null;
            var nIsError = IsError(nObs);
            if (oObs is null && nObs is object)
            {
                yield return nIsError ?
                    Diff.Major(Cause.ObsoleteChanged, $"{prefix} has become 'Obsolete(error:true)'.") :
                    Diff.Minor(Cause.ObsoleteChanged, $"{prefix} has become 'Obsolete'.");
            }
            else if (oObs is object && nObs is null)
            {
                yield return Diff.Minor(Cause.ObsoleteChanged, $"{prefix} has become non-'Obsolete'.");
            }
            else if (oObs is object && nObs is object)
            {
                if (!oIsError && nIsError)
                {
                    yield return Diff.Major(Cause.ObsoleteChanged, $" changed from 'Obsolete(error:false)' to 'Obsolete(error:true)'.");
                }
                else if (oIsError && !nIsError)
                {
                    yield return Diff.Minor(Cause.ObsoleteChanged, $" changed from 'Obsolete(error:true)' to 'Obsolete(error:false)'.");
                }
            }

            bool IsError(CustomAttribute obs)
            {
                if (obs is object)
                {
                    if (obs.HasConstructorArguments && obs.ConstructorArguments.Count == 2)
                    {
                        // (string, bool) ctor
                        return (bool)obs.ConstructorArguments[1].Value;
                    }
                }
                return false;
            }
        }

        private string MethodSigOrder(MethodDefinition m) => string.Join(";", m.Parameters.Select(x => $"{x.ParameterType.FullName}:{x.Name}"));

        private IEnumerable<Diff> MethodsCtors(TypeType typeType, bool isCtor, Func<TypeDefinition, IEnumerable<MethodDefinition>> methodSelector)
        {
            var prefixType = isCtor ? "constructor" : "method";
            var oMethods = methodSelector(_o).ToImmutableHashSet(SameMethodComparer.Instance);
            var nMethods = methodSelector(_n).ToImmutableHashSet(SameMethodComparer.Instance);
            foreach (var method in oMethods.Union(nMethods).OrderBy(x => x.FullName).ThenBy(MethodSigOrder))
            {
                var inO = oMethods.TryGetValue(method, out var o);
                var inN = nMethods.TryGetValue(method, out var n);
                FormattableString prefix = $"{_o.TypeType()} '{_o}'; {prefixType} '{o}'";
                if (inO && inN && o.IsExported() && n.IsExported())
                {
                    if (typeType == TypeType.Class || typeType == TypeType.Struct)
                    {
                        // Method present and exported in both types.
                        if (o.IsStatic && !n.IsStatic)
                        {
                            // Cannot occur for ctors.
                            yield return Diff.Major(Cause.MethodMadeNonStatic, $"{prefix} made non-static.");
                        }
                        else if (!o.IsStatic && n.IsStatic)
                        {
                            // Cannot occur for ctors.
                            yield return Diff.Major(Cause.MethodMadeStatic, $"{prefix} made static.");
                        }
                        else
                        {
                            // Method modifiers not relevant for ctors.
                            var diffs = MethodModifiers(o, n, Cause.MethodModifierChanged, prefix)
                                .Concat(MethodAccessModifiers(o, n, C(Cause.MethodAccessModifierChanged, Cause.CtorAccessModifierChanged), prefix));
                            foreach (var diff in diffs)
                            {
                                yield return diff;
                            }
                        }
                    }
                    if (!SameTypeComparer.Instance.Equals(o.ReturnType, n.ReturnType))
                    {
                        // Cannot occur for ctors.
                        yield return Diff.Major(Cause.MethodReturnTypeChanged, $"{prefix} return type changed to '{n.ReturnType}'.");
                    }
                    foreach (var (oParam, nParam) in o.Parameters.Zip(n.Parameters))
                    {
                        if (oParam.Name != nParam.Name)
                        {
                            yield return Diff.Major(C(Cause.MethodParameterNameChanged, Cause.CtorParameterNameChanged),
                                $"{prefix} parameter name changed from '{oParam.Name}' to '{nParam.Name}'.");
                        }
                        if (oParam.IsIn != nParam.IsIn || oParam.IsOut != nParam.IsOut)
                        {
                            yield return Diff.Major(C(Cause.MethodParameterInOutChanged, Cause.CtorParameterInOutChanged),
                                $"{prefix} parameter '{oParam.Name}' changed from '{oParam.ShowInOut()}' to '{nParam.ShowInOut()}'.");
                        }
                    }
                    // Cannot occur for ctors
                    if (!isCtor)
                    {
                        foreach (var diff in GenericConstraints(isType: false, prefix, o.GenericParameters, n.GenericParameters))
                        {
                            yield return diff;
                        }
                    }
                    foreach (var diff in Obsoleteness(o, n, prefix))
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
                            Diff.Major(C(Cause.MethodMadeNotExported, Cause.CtorMadeNotExported), $"{prefix} made non-public.") :
                            Diff.Major(C(Cause.MethodRemoved, Cause.CtorRemoved), $"{prefix} removed.");
                    }
                    else if (inN && n.IsExported())
                    {
                        var diff = typeType == TypeType.Class || typeType == TypeType.Struct ? (Func<Cause, FormattableString, Diff>)Diff.Minor : Diff.Major;
                        yield return inO ?
                            diff(C(Cause.MethodMadeExported, Cause.CtorMadeExported), $"{prefix} made public.") :
                            diff(C(Cause.MethodAdded, Cause.CtorAdded), $"{prefix} added.");
                    }
                }
            }

            Cause C(Cause methodCause, Cause ctorCause) => isCtor ? ctorCause : methodCause;
        }

        public IEnumerable<Diff> Ctors(TypeType typeType) => MethodsCtors(typeType, isCtor: true, t => t.InstanceCtors());

        public IEnumerable<Diff> Methods(TypeType typeType) =>
            MethodsCtors(typeType, isCtor: false, t => t.Methods.Where(x => !x.IsGetter && !x.IsSetter && !x.IsConstructor));

        public IEnumerable<Diff> Properties(TypeType typeType)
        {
            var oProps = _o.Properties.ToImmutableHashSet(SamePropertyComparer.Instance);
            var nProps = _n.Properties.ToImmutableHashSet(SamePropertyComparer.Instance);
            foreach (var prop in oProps.Union(nProps).OrderBy(x => x.FullName))
            {
                var inO = oProps.TryGetValue(prop, out var o);
                var inN = nProps.TryGetValue(prop, out var n);
                FormattableString prefix = $"{_o.TypeType()} '{_o}'; property '{o}'";
                if (inO && inN && o.IsExported() && n.IsExported())
                {
                    if (typeType == TypeType.Class || typeType == TypeType.Struct)
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
                            var diffs = MethodModifiers(o.GetMethod ?? o.SetMethod, n.GetMethod ?? n.SetMethod, Cause.PropertyModifierChanged, prefix)
                                .Concat(MethodAccessModifiers(o.GetMethod, n.GetMethod, Cause.PropertyAccessModifierChanged, $"{prefix} getter"))
                                .Concat(MethodAccessModifiers(o.SetMethod, n.SetMethod, Cause.PropertyAccessModifierChanged, $"{prefix} setter"));
                            foreach (var diff in diffs)
                            {
                                yield return diff;
                            }
                        }
                    }
                    if (!SameTypeComparer.Instance.Equals(o.PropertyType, n.PropertyType))
                    {
                        yield return Diff.Major(Cause.PropertyTypeChanged, $"{prefix} return type changed to '{n.PropertyType}'.");
                    }
                    // No need to check parameter names, or in/out/ref.
                    foreach (var diff in Obsoleteness(o, n, prefix))
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
                            Diff.Major(Cause.PropertyMadeNotExported, $"{prefix} made non-public.") :
                            Diff.Major(Cause.PropertyRemoved, $"{prefix} removed.");
                    }
                    else if (inN && n.IsExported())
                    {
                        var diff = typeType == TypeType.Class || typeType == TypeType.Struct ? (Func<Cause, FormattableString, Diff>)Diff.Minor : Diff.Major;
                        yield return inO ?
                            diff(Cause.PropertyMadeExported, $"{prefix} made public.") :
                            diff(Cause.PropertyAdded, $"{prefix} added.");
                    }
                }
            }
        }
    }
}
