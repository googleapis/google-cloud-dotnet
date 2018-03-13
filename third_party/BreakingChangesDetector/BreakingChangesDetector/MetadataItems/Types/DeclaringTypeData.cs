/*
    MIT License

    Copyright(c) 2014-2018 Infragistics, Inc.

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

using Mono.Cecil;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BreakingChangesDetector.MetadataItems
{
	/// <summary>
	/// Abstract base class representing metadata for an externally visible type which can contain member declarations.
	/// </summary>
	public abstract class DeclaringTypeData : TypeData
	{
		#region Member Variables

		private readonly Dictionary<string, List<MemberDataBase>> _membersByName;

		#endregion // Member Variables

		#region Constructors

		internal DeclaringTypeData(string name, MemberAccessibility accessibility, MemberFlags memberFlags, TypeKind typeKind)
			: base(name, accessibility, memberFlags, typeKind)
		{
			_membersByName = new Dictionary<string, List<MemberDataBase>>();
		}

		internal DeclaringTypeData(TypeReference type, MemberAccessibility accessibility, DeclaringTypeData declaringType)
			: base(type, accessibility, declaringType)
		{
			_membersByName = new Dictionary<string, List<MemberDataBase>>();
		}

		#endregion // Constructors

		#region Base Class Overrides

		#region DoesMatch

		internal override bool DoesMatch(MetadataItemBase other)
		{
			if (base.DoesMatch(other) == false)
				return false;

			var otherTyped = other as DeclaringTypeData;
			if (otherTyped == null)
				return false;

			if (this.BaseType == null ^ otherTyped.BaseType == null)
				return false;

			if (this.BaseType != null && this.BaseType.DisplayName != otherTyped.BaseType.DisplayName)
				return false;

			if (this.DelegateParameters == null ^ otherTyped.DelegateParameters == null)
				return false;

			if (this.DelegateParameters != null && this.DelegateParameters.DoesMatch(otherTyped.DelegateParameters) == false)
				return false;

			if (this.DelegateReturnType == null ^ otherTyped.DelegateReturnType == null)
				return false;

			if (this.DelegateReturnType != null && this.DelegateReturnType.DisplayName != otherTyped.DelegateReturnType.DisplayName)
				return false;

			if (this.DelegateReturnTypeIsDynamic != this.DelegateReturnTypeIsDynamic)
				return false;

			if (this.GenericArity != otherTyped.GenericArity)
				return false;

			if (this.IsExtensionsClass != otherTyped.IsExtensionsClass)
				return false;

			if (_membersByName.Count != otherTyped._membersByName.Count)
				return false;

			foreach (var pair in _membersByName)
			{
				var value = pair.Value;
				List<MemberDataBase> otherValue;
				if (otherTyped._membersByName.TryGetValue(pair.Key, out otherValue) == false)
					return false;

				if (value.Count != otherValue.Count)
					return false;

				for (int i = 0; i < value.Count; i++)
					if (value[i].DoesMatch(otherValue[i]) == false)
						return false;
			}

			return true;
		}

		#endregion // DoesMatch

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
			if (onlyReferenceAndIdentityConversions && this.IsValueType)
				yield break;

			if (this.TypeKind != TypeKind.Enum && this.BaseType != null)
				yield return this.BaseType;

			foreach (var implementedInterface in this.ImplementedInterfaces)
				yield return implementedInterface;

			// Any interface type can convert to object
			if (this.TypeKind == TypeKind.Interface)
			{
				var mscorlibData = this.AssemblyData.GetReferencedAssembly(Utilities.CommonObjectRuntimeAssemblyName);
				if (mscorlibData != null)
					yield return mscorlibData.GetTypeDefinitionData(Utilities.ObjectTypeName);
			}
		}

		#endregion // GetDirectImplicitConversions

		#region GetDisplayName

		/// <summary>
		/// Gets the display name for the type, which can be used for generating user-readable messages about the type.
		/// </summary>
		/// <param name="fullyQualify">Indicates whether the type name should be fully qualified with declaring type and namespace names.</param>
		/// <param name="includeGenericInfo">Indicates whether generic parameters and arguments should be included in type names.</param>
		/// <returns>The display name of the type.</returns>
		public override sealed string GetDisplayName(bool fullyQualify = true, bool includeGenericInfo = true)
		{
			return this.GetDisplayName(fullyQualify, includeGenericInfo, null);
		}

		#endregion // GetDisplayName

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
				return true;

			if (context.OnlyReferenceAndIdentityConversions == false)
			{
				// See if there are any user-defined implicit conversions from the source type to the target type defined in new types:
				// (we want to check in new types because a breaking change in a new version due to a type change can be mitigated by
				// defining an implicit conversion in one of the types in the new version).
				if (this.DoesSourceTypeHaveImplicitOperatorOverloadToTarget(sourceType, context))
					return true;

				if (this.DoesTargetTypeHaveImplicitOperatorOverloadFromSource(sourceType, context))
					return true;
			}

			return false;
		}

		#endregion // IsAssignableFrom

		#endregion // Base Class Overrides

		#region Methods

		#region Public Methods

		#region GetMember

		/// <summary>
		/// Gets the single member with the specified name or null if no such member exists. If multiple members exist with the specified name, 
		/// an exception will be thrown.
		/// </summary>
		/// <param name="name">The name of the member to get.</param>
		/// <exception cref="InvalidOperationException">
		/// Occurs when multiple members have the specified name.
		/// </exception>
		/// <returns>The single member with the specified name, or null if no such member exists.</returns>
		public MemberDataBase GetMember(string name)
		{
			var members = this.GetMembers(name);
			if (members.Count == 0)
				return null;

			if (members.Count != 1)
				throw new InvalidOperationException(string.Format("There are multiple members in {0} with the name '{1}'", this.Name, name));

			return members[0];
		}

		#endregion // GetMember

		#region GetMembers

		/// <summary>
		/// Gets the collection of all members declared in the type.
		/// </summary>
		public IEnumerable<MemberDataBase> GetMembers()
		{
			return _membersByName.OrderBy(p => p.Key).SelectMany(p => p.Value);
		}

		/// <summary>
		/// Gets the collection of all members declared in the type with the specified name.
		/// </summary>
		public List<MemberDataBase> GetMembers(string name)
		{
			List<MemberDataBase> members;
			if (_membersByName.TryGetValue(name, out members))
				return members;

			return MemberDataBase.EmptyList;
		}

		#endregion // GetMembers

		#region GetMethod

		/// <summary>
		/// Gets the single method with the specified name or null if no such method exists. If multiple methods exist with the specified name, 
		/// an exception will be thrown.
		/// </summary>
		/// <param name="name">The name of the method to get.</param>
		/// <returns>The single method with the specified name, or null if no such method exists.</returns>
		public MethodData GetMethod(string name)
		{
			return this.GetMembers(name).OfType<MethodData>().SingleOrDefault();
		}

		#endregion // GetMethod

		#endregion // Public Methods

		#region Internal Methods

		#region AddMember

#if DEBUG
		/// <summary>
		/// Adds the specified member to the declaring type.
		/// </summary> 
#endif
		internal void AddMember(MemberDataBase member)
		{
			if (member == null)
				return;

			if (member.Accessibility == MemberAccessibility.Protected && this.IsSealed)
				return;

			List<MemberDataBase> members;
			if (_membersByName.TryGetValue(member.Name, out members) == false)
			{
				members = new List<MemberDataBase>();
				_membersByName[member.Name] = members;
			}

			members.Add(member);
		}

		#endregion // AddMember

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
		internal abstract string GetDisplayName(bool fullyQualify, bool includeGenericInfo, GenericTypeArgumentCollection genericArguments);

		#endregion // GetDisplayName

		#region PostProcessUnqualifiedName

#if DEBUG
		/// <summary>
		/// Adds in the fully qualified information for the type name if necessary.
		/// </summary>
		/// <param name="unqualifiedName">The unqualified name of the type.</param>
		/// <param name="fullyQualify">Indicates whether the type name should be fully qualified with declaring type and namespace names.</param>
		/// <param name="includeGenericInfo">Indicates whether generic parameters and arguments should be included in type names.</param>
		/// <param name="genericArguments">
		/// The generic arguments used to parameterize a type. For nested types, this will include the arguments for the declaring type before the arguments 
		/// for the nested type.
		/// </param>
#endif
		internal string PostProcessUnqualifiedName(string unqualifiedName, bool fullyQualify, bool includeGenericInfo, GenericTypeArgumentCollection genericArguments)
		{
			if (fullyQualify)
			{
				if (this.DeclaringType != null)
					return this.DeclaringType.GetDisplayName(fullyQualify, includeGenericInfo, genericArguments) + "." + unqualifiedName;

				var namespaceName = this.GetNamespaceName();
				if (string.IsNullOrEmpty(namespaceName) == false)
					return namespaceName + "." + unqualifiedName;
			}

			return unqualifiedName;
		}

		#endregion // PostProcessUnqualifiedName

		#endregion // Internal Methods

		#region Private Methods

		#region DoesSourceTypeHaveImplicitOperatorOverloadToTarget

		private bool DoesSourceTypeHaveImplicitOperatorOverloadToTarget(TypeData sourceType, IsAssignableFromContext context)
		{
			var sourceDeclaringTypeData = sourceType as DeclaringTypeData;
			if (sourceDeclaringTypeData == null)
				return false;

			var newSourceType = context.IsSourceTypeOld
				? sourceDeclaringTypeData.GetEquivalentNewType(context.NewAssemblyFamily) as DeclaringTypeData
				: sourceDeclaringTypeData;

			if (newSourceType == null)
				return false;

			var implicitOperatorsFromSource = newSourceType.GetMembers(OperatorData.ImplicitCastOperatorName)
				.OfType<OperatorData>()
				.Where(o => o.Parameters[0].Type == newSourceType);

			foreach (var op in implicitOperatorsFromSource)
			{
				if (context.IsTargetTypeOld)
				{
					if (op.Type.IsEquivalentToOld(this, context.NewAssemblyFamily))
						return true;
				}
				else
				{
					if (op.Type == this)
						return true;
				}
			}

			return false;
		}

		#endregion // DoesSourceTypeHaveImplicitOperatorOverloadToTarget

		#region DoesTargetTypeHaveImplicitOperatorOverloadFromSource

		private bool DoesTargetTypeHaveImplicitOperatorOverloadFromSource(TypeData sourceType, IsAssignableFromContext context)
		{
			var newTargetType = context.IsTargetTypeOld
				? this.GetEquivalentNewType(context.NewAssemblyFamily) as DeclaringTypeData
				: this;

			if (newTargetType == null)
				return false;

			var implicitOperators = newTargetType.GetMembers(OperatorData.ImplicitCastOperatorName)
				.OfType<OperatorData>()
				.Where(o => o.Type == newTargetType);

			foreach (var op in implicitOperators)
			{
				if (context.IsSourceTypeOld)
				{
					if (op.Parameters[0].Type.IsEquivalentToOld(sourceType, context.NewAssemblyFamily))
						return true;
				}
				else
				{
					if (op.Parameters[0].Type == sourceType)
						return true;
				}
			}

			return false;
		}

		#endregion // DoesTargetTypeHaveImplicitOperatorOverloadFromSource

		#endregion // Private Methods

		#endregion // Methods

		#region Properties

		#region Public Properties

		/// <summary>
		/// Gets the base type of the current type.
		/// </summary>
		public DeclaringTypeData BaseType { get; internal set; }

		/// <summary>
		/// Gets the collection of parameters for delegate types, or null if the type is not a delegate.
		/// </summary>
		public ParameterCollection DelegateParameters { get; internal set; }

		/// <summary>
		/// Gets the return type for delegate types, or null if the tpye is not a delegate.
		/// </summary>
		public TypeData DelegateReturnType { get; internal set; }

		/// <summary>
		/// Gets the value indicating whether the return type of the delegate type is 'dynamic'. This value should be ignored for non-delegate types.
		/// </summary>
		public bool DelegateReturnTypeIsDynamic { get; internal set; } // TODO_Serialize: Round trip and unit test

		/// <summary>
		/// Gets the value indicating whether the type has any members declared.
		/// </summary>
		public bool HasMembers
		{
			get { return _membersByName.Count != 0; }
		}

		/// <summary>
		/// Gets the collection of interfaces implemented by the type.
		/// </summary>
		public ImplementedInterfacesCollection ImplementedInterfaces { get; internal set; }

		#endregion // Public Properties

		#region Internal Properties

		#region GenericArity

#if DEBUG
		/// <summary>
		/// Gets the number of generic parameters/arguments for the type.
		/// </summary> 
#endif
		internal abstract int GenericArity { get; }

		#endregion // GenericArity

		#region IsExtensionsClass

#if DEBUG
		/// <summary>
		/// Gets the value indicating whether the type is an extension class (a class containing extension methods).
		/// </summary> 
#endif
		internal abstract bool IsExtensionsClass { get; }

		#endregion // IsExtensionsClass

		#endregion // Internal Properties

		#endregion // Properties
	}
}
