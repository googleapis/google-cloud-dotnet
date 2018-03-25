/*
    MIT License

    Copyright(c) 2014-2018 Infragistics, Inc.
    Copyright 2018 Google LLC

    Permission is hereby granted, free of charge, to any person obtaining a copy
    of this software and associated documentation files (the "Software"), to deal
    in the Software without restriction, including without limitation the rights
    to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
    copies of the Software, and to permit persons to whom the Software is
    furnished to do so, subject to the following conditions:

    The above copyright notice and this permission notice shall be included in all
    copies or substantial portions of the Software.

    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
    IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
    FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
    AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
    LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
    OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
    SOFTWARE.
*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace BreakingChangesDetector.MetadataItems
{
    /// <summary>
    /// Represents the metadata for an externally visible constructed generic type.
    /// </summary>
    public sealed class ConstructedGenericTypeData : DeclaringTypeData
    {

        #region Member Variables
        private readonly bool _isNullable;

        #endregion // Member Variables

        #region Constructor

        internal ConstructedGenericTypeData(TypeDefinitionData genericTypeDefinition, IEnumerable<TypeData> genericArguments)
            : base(genericTypeDefinition.Name, genericTypeDefinition.Accessibility, genericTypeDefinition.MemberFlags, genericTypeDefinition.TypeKind)
        {
            GenericTypeDefinition = genericTypeDefinition;
            ContainingType = genericTypeDefinition.ContainingType;

            _isNullable = genericTypeDefinition.IsType(typeof(Nullable<>));

            GenericArguments = new GenericTypeArgumentCollection(genericArguments);
            genericTypeDefinition.RegisterConstructedGenericTypeData(this);
            genericTypeDefinition.AssemblyData.RegisterForFinalize(this);
        }

        #endregion // Constructor

        #region Base Class Overrides

        #region Accept

        /// <summary>
        /// Performs the specified visitor's functionality on this instance.
        /// </summary>
        /// <param name="visitor">The visitor whose functionality should be performed on the instance.</param>
        public override void Accept(MetadataItemVisitor visitor) => visitor.VisitConstructedGenericTypeData(this);

        #endregion // Accept

        #region AssemblyData

        /// <summary>
        /// Gets the <see cref="T:AssemblyData"/> representing the assembly in which the type is defined.
        /// </summary>
        public override AssemblyData AssemblyData => GenericTypeDefinition?.AssemblyData;

        #endregion // AssemblyData

        #region DoesMatch

        internal override bool DoesMatch(MetadataItemBase other)
        {
            if (base.DoesMatch(other) == false)
            {
                return false;
            }

            var otherTyped = other as ConstructedGenericTypeData;
            if (otherTyped == null)
            {
                return false;
            }

            if (GenericArguments.DoesMatch(otherTyped.GenericArguments) == false)
            {
                return false;
            }

            if (GenericTypeDefinition.DisplayName != otherTyped.GenericTypeDefinition.DisplayName)
            {
                return false;
            }

            if (_isNullable != otherTyped._isNullable)
            {
                return false;
            }

            return true;
        }

        #endregion // DoesMatch

        #region GenericArity

#if DEBUG
        /// <summary>
        /// Gets the number of generic parameters/arguments for the type.
        /// </summary> 
#endif
        internal override int GenericArity => GenericArguments.Count;

        #endregion // GenericArity

        #region GetDefiningAssemblyFamily

#if DEBUG
        /// <summary>
        /// Gets the <see cref="AssemblyFamily"/> containing the type. If the type is nullable and type with element, 
        /// such as T?, T[], or T*, this returns the family containing the type T.
        /// </summary> 
#endif
        internal override AssemblyFamily GetDefiningAssemblyFamily()
        {
            if (IsNullable(out TypeData underlyingType))
            {
                return underlyingType.GetDefiningAssemblyFamily();
            }

            return base.GetDefiningAssemblyFamily();
        }

        #endregion // GetDefiningAssemblyFamily

        #region GetDirectImplicitConversions

#if DEBUG
        /// <summary>
        /// Gets the types to which this type can implicitly convert. For type hierarchy conversions, only the direct base type will be enumerated.
        /// Ancestor base types will can be enumerated recursively by calling this method on the base type.
        /// </summary>
        /// <param name="onlyReferenceAndIdentityConversions">
        /// True if reference and identify conversions are they only allowed conversions; False if all implicit conversions are allowed.
        /// </param>
        /// <returns>
        /// A collection of all types to which this type can convert explicitly, except for ancestor base types which are not the direct base type.
        /// </returns> 
#endif
        internal override IEnumerable<TypeData> GetDirectImplicitConversions(bool onlyReferenceAndIdentityConversions)
        {
            if (onlyReferenceAndIdentityConversions == false)
            {
                // An implicit conversion from S? to interfaces and base classes of S
                if (IsNullable(out TypeData underlyingType))
                {
                    foreach (var item in underlyingType.GetDirectImplicitConversions(onlyReferenceAndIdentityConversions))
                    {
                        if (item.IsValueType == false)
                        {
                            yield return item;
                        }
                    }
                }
            }

            foreach (var item in base.GetDirectImplicitConversions(onlyReferenceAndIdentityConversions))
            {
                yield return item;
            }
        }

        #endregion // GetDirectImplicitConversions

        #region GetDisplayName

#if DEBUG
        /// <summary>
        /// Gets the display name for the type, which can be used for generating user-readable messages about the type.
        /// </summary>
        /// <param name="fullyQualify">Indicates whether the type name should be fully qualified with declaring type and namespace names.</param>
        /// <param name="includeGenericInfo">Indicates whether generic parameters and arguments should be included in type names.</param>
        /// <param name="genericArguments">
        /// The generic arguments used to parameterize a type. For nested types, this will include the arguments for the declaring type before the arguments 
        /// for the nested type.
        /// </param>
        /// <returns>The display name of the type.</returns> 
#endif
        internal override string GetDisplayName(bool fullyQualify, bool includeGenericInfo, GenericTypeArgumentCollection genericArguments)
        {
            if (IsNullable(out TypeData underlyingType))
            {
                return underlyingType.GetDisplayName(fullyQualify: false, includeGenericInfo: includeGenericInfo) + '?';
            }

            var genericArgumentsResolved = genericArguments ?? GenericArguments;

            var rootName = GenericTypeDefinition.GetDisplayName(fullyQualify: false, includeGenericInfo: false);
            if (includeGenericInfo)
            {
                var parentGenericArgumentCount = ContainingType == null ? 0 : ContainingType.GenericArity;
                rootName += genericArgumentsResolved.GetGenericArgumentListDisplayText(includeGenericInfo, parentGenericArgumentCount, GenericArguments.Count - parentGenericArgumentCount);
            }

            return PostProcessUnqualifiedName(rootName, fullyQualify, includeGenericInfo, genericArgumentsResolved);
        }

        #endregion // GetDisplayName

        #region GetEquivalentNewType

#if DEBUG
        /// <summary>
        /// Gets the type equivalent to this one which is from a newer assembly.
        /// </summary>
        /// <param name="newAssemblyFamily">The assembly family in which new assemblies reside.</param>
#endif
        internal override TypeData GetEquivalentNewType(AssemblyFamily newAssemblyFamily)
        {
            var newGenericTypeDefinition = (TypeDefinitionData)GenericTypeDefinition.GetEquivalentNewType(newAssemblyFamily);
            if (newGenericTypeDefinition == null)
            {
                return null;
            }

            var newGenericArguments = new TypeData[GenericArguments.Count];
            for (int i = 0; i < GenericArguments.Count; i++)
            {
                var newGenericArgument = GenericArguments[i].GetEquivalentNewType(newAssemblyFamily);
                if (newGenericArgument == null)
                {
                    return null;
                }

                newGenericArguments[i] = newGenericArgument;
            }

            return newGenericTypeDefinition.GetConstructedGenericTypeData(newGenericArguments);
        }

        #endregion // GetEquivalentNewType

        #region GetNamespaceName

#if DEBUG
        /// <summary>
        /// Gets the name of the namespace in which the type is defined, or null if it is not defined in a namespace.
        /// </summary> 
#endif
        internal override string GetNamespaceName()
        {
            // For nullable types, we want to get the namespace of the underlying type, not the System.Nullable<T> type, because it will be displayed as T?.
            if (IsNullable(out TypeData underlyingType))
            {
                return underlyingType.GetNamespaceName();
            }

            return GenericTypeDefinition.GetNamespaceName();
        }

        #endregion // GetNamespaceName

        #region IsAssignableFrom

#if DEBUG
        /// <summary>
        /// Gets the value indicating whether a variable of the current type is assignable from the specified source type.
        /// </summary>
        /// <param name="sourceType">The source type from which to test assignability to this type.</param>
        /// <param name="context">Information about the context of the IsAssignableFrom invocation.</param>
        /// <returns>True if a value of the source type is assignable to a variable of the current type.</returns> 
#endif
        internal override bool IsAssignableFrom(TypeData sourceType, IsAssignableFromContext context)
        {
            if (base.IsAssignableFrom(sourceType, context))
            {
                return true;
            }

            // Test for covariance and contravariance
            if (SupportsVariantTypeParameters && sourceType.IsVarianceConvertibleTo(this, context))
            {
                return true;
            }
            if (IsIListGenericType(out TypeData iListElementType) &&
                sourceType.IsArray(out int arrayRank, out TypeData arrayElementType) &&
                arrayRank == 1)
            {
                return iListElementType.IsAssignableFrom(arrayElementType, new IsAssignableFromContext(context.NewAssemblyFamily, context.IsSourceTypeOld, onlyReferenceAndIdentityConversions: true));
            }

            if (context.OnlyReferenceAndIdentityConversions == false)
            {
                if (IsNullable(out TypeData targetUnderlyingType))
                {
                    // An implicit conversion from S? to T?
                    if (sourceType.IsNullable(out TypeData sourceUnderlyingType))
                    {
                        return targetUnderlyingType.IsAssignableFrom(sourceUnderlyingType, context);
                    }

                    // An implicit conversion from S to T?
                    return targetUnderlyingType.IsAssignableFrom(sourceType, context);
                }
            }

            return false;
        }

        #endregion // IsAssignableFrom

        #region IsEquivalentToNewMember

#if DEBUG
        /// <summary>
        /// Indicates whether a new member of the same type and name is logically the same member as the current member, just from a newer build.
        /// </summary> 
#endif
        internal override bool IsEquivalentToNewMember(MemberDataBase newMember, AssemblyFamily newAssemblyFamily)
        {
            if (base.IsEquivalentToNewMember(newMember, newAssemblyFamily) == false)
            {
                return false;
            }

            var other = newMember as ConstructedGenericTypeData;
            if (other == null)
            {
                return false;
            }

            if (GenericTypeDefinition.IsEquivalentToNew(other.GenericTypeDefinition, newAssemblyFamily) == false)
            {
                return false;
            }

            if (GenericArguments.Count != other.GenericArguments.Count)
            {
                return false;
            }

            for (int i = 0; i < GenericArguments.Count; i++)
            {
                if (GenericArguments[i].IsEquivalentToNewMember(other.GenericArguments[i], newAssemblyFamily) == false)
                {
                    return false;
                }
            }

            return true;
        }

        #endregion // IsEquivalentToNewMember

        #region IsNullable

#if DEBUG
        /// <summary>
        /// Gets the value indicating whether type is a nullable value type.
        /// </summary>
        /// <param name="underlyingType">[Out] Will be set to the underlying value type if the tpye is nullable; will be null otherwise.</param>
        /// <returns>True if the type is nullable; False otherwise.</returns> 
#endif
        internal override bool IsNullable(out TypeData underlyingType)
        {
            if (GenericArguments.Count == 1 &&
                _isNullable)
            {
                underlyingType = GenericArguments[0];
                return true;
            }

            underlyingType = null;
            return false;
        }

        #endregion // IsNullable

        #region IsVarianceConvertibleTo

#if DEBUG
        /// <summary>
        /// Gets the value indicating whether the type can convert to the specified target type using type parameter variance.
        /// </summary>
        /// <param name="target">The target type to which this type might convert.</param>
        /// <param name="context">Information about the context of the IsAssignableFrom invocation.</param>
        /// <returns>True is the type is variance convertible to the target; False otherwise.</returns> 
#endif
        internal override bool IsVarianceConvertibleTo(ConstructedGenericTypeData target, IsAssignableFromContext context)
        {
            if (target.TypeKind == TypeKind &&
                target.GenericTypeDefinition == GenericTypeDefinition &&
                target.GenericArguments.Count == GenericArguments.Count)
            {
                Debug.Assert(
                    target.GenericArguments.Count == GenericArguments.Count,
                    "Two constructed generic types from the same generic type definition should have the same number of generic arguments.");

                var genericParameters = target.GenericTypeDefinition.GenericParameters;
                for (int i = 0, count = genericParameters.Count; i < count; i++)
                {
                    if (genericParameters[i].IsGenericTypeArgumentVariant(target.GenericArguments[i], GenericArguments[i], context) == false)
                    {
                        return false;
                    }
                }

                return true;
            }

            return false;
        }

        #endregion // IsVarianceConvertibleTo

        #region MetadataItemKind

        /// <summary>
        /// Gets the type of item the instance represents.
        /// </summary>
        public override MetadataItemKinds MetadataItemKind => MetadataItemKinds.ConstructedGenericType;

        #endregion // MetadataItemKind

        #region ReplaceGenericTypeParameters

#if DEBUG
        /// <summary>
        /// Replaces all type parameters used by the member with their associated generic arguments specified in a constructed generic type.
        /// </summary>
        /// <param name="genericParameters">The generic parameters being replaced.</param>
        /// <param name="genericArguments">The generic arguments replacing the parameters.</param>
        /// <returns>A new member with the replaced type parameters or the current instance if the member does not use any of the generic parameters.</returns> 
#endif
        internal override MemberDataBase ReplaceGenericTypeParameters(GenericTypeParameterCollection genericParameters, GenericTypeArgumentCollection genericArguments)
        {
            List<TypeData> replacedGenericArguments = null;
            for (int i = 0; i < GenericArguments.Count; i++)
            {
                var currentArgument = GenericArguments[i];
                var replacedArgument = (TypeData)currentArgument.ReplaceGenericTypeParameters(genericParameters, genericArguments);
                if (replacedArgument == currentArgument)
                {
                    continue;
                }

                if (replacedGenericArguments == null)
                {
                    replacedGenericArguments = new List<TypeData>(GenericArguments);
                }

                replacedGenericArguments[i] = replacedArgument;
            }

            if (replacedGenericArguments != null)
            {
                return GenericTypeDefinition.GetConstructedGenericTypeData(replacedGenericArguments);
            }

            return this;
        }

        #endregion // ReplaceGenericTypeParameters

        #endregion // Base Class Overrides

        #region Methods

        #region Internal Methods

        #region FinalizeDefiniton

        internal void FinalizeDefiniton()
        {
            var genericParameters = GenericTypeDefinition.GenericParameters;

            if (GenericTypeDefinition.BaseType != null)
            {
                BaseType = (DeclaringTypeData)GenericTypeDefinition.BaseType.ReplaceGenericTypeParameters(genericParameters, GenericArguments);
            }

            ImplementedInterfaces = new ImplementedInterfacesCollection(
                GenericTypeDefinition.ImplementedInterfaces.Select(i => (DeclaringTypeData)i.ReplaceGenericTypeParameters(genericParameters, GenericArguments))
                );

            if (TypeKind == Microsoft.CodeAnalysis.TypeKind.Delegate)
            {
                var invokeMethod = (MethodData)GenericTypeDefinition.GetMethod("Invoke").ReplaceGenericTypeParameters(genericParameters, GenericArguments);
                DelegateParameters = invokeMethod.Parameters;
                DelegateReturnType = invokeMethod.Type;
                DelegateReturnTypeIsDynamic = invokeMethod.IsTypeDynamic;
            }
            else
            {
                foreach (var member in GenericTypeDefinition.GetMembers().Where(m => m.MetadataItemKind != MetadataItemKinds.TypeDefinition))
                {
                    AddMember(member.ReplaceGenericTypeParameters(genericParameters, GenericArguments));
                }
            }
        }

        #endregion // FinalizeDefiniton

        #endregion // Internal Methods

        #region Private Methods

        #region IsIListGenericType

#if DEBUG
        /// <summary>
        /// Indicates whether the type is an IList&lt;T&gt; constructed generic type.
        /// </summary> 
#endif
        private bool IsIListGenericType(out TypeData elementType)
        {
            if (GenericArguments.Count == 1 &&
                GenericTypeDefinition.IsType(typeof(IList<>)))
            {
                elementType = GenericArguments[0];
                return true;
            }

            elementType = null;
            return false;
        }

        #endregion // IsIListGenericType

        #endregion // Private Methods

        #endregion // Methods

        #region Properties

        #region Public Properties

        /// <summary>
        /// Gets the collection of generic arguments specified when constructing this type.
        /// </summary>
        public GenericTypeArgumentCollection GenericArguments { get; } // TODO_Serialize: Round trip and unit test

        /// <summary>
        /// Gets the generic type definition.
        /// </summary>
        public TypeDefinitionData GenericTypeDefinition { get; } // TODO_Serialize: Round trip and unit test

        #endregion // Public Properties

        #region Internal Properties

#if DEBUG
        /// <summary>
        /// Gets the value indicating whether the type, if it were generic, supports variant type parameters (this is true for interfaces and delegates).
        /// </summary>  
#endif
        internal bool SupportsVariantTypeParameters =>
            TypeKind == Microsoft.CodeAnalysis.TypeKind.Interface ||
            TypeKind == Microsoft.CodeAnalysis.TypeKind.Delegate;

        #endregion // Internal Properties

        #endregion // Properties
    }
}
