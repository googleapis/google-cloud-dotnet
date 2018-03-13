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
	/// Represents the metadata for an generic type parameter defined on an externally visible generic type or method.
	/// </summary>
	public sealed class GenericTypeParameterData : TypeData
	{
		#region Constants

		private const string InVarianceModifier = "in ";
		private const string OutVarianceModifier = "out ";

		#endregion // Constants

		#region Static Variables

		internal new static readonly GenericTypeParameterCollection EmptyList = new GenericTypeParameterCollection();

		#endregion // Static Variables

		#region Member Variables

		private readonly AssemblyData _assembly;
		private bool _isInIsEquivalentToNewMember;

		#endregion // Member Variables

		#region Constructors

		internal GenericTypeParameterData(string name, MemberAccessibility accessibility, MemberFlags memberFlags, TypeKind typeKind, AssemblyData assembly, System.Reflection.GenericParameterAttributes genericParameterAttributes, int genericParameterPosition)
			: base(name, accessibility, memberFlags, typeKind)
		{
			_assembly = assembly;
			this.Constraints = new List<TypeData>();
			this.GenericParameterAttributes = genericParameterAttributes;
			this.GenericParameterPosition = genericParameterPosition;
		}

		internal GenericTypeParameterData(GenericParameter genericTypeParameter, AssemblyData assembly)
			: base(genericTypeParameter, MemberAccessibility.Public, declaringType: null)
		{
			_assembly = assembly;
			this.GenericParameterAttributes = (System.Reflection.GenericParameterAttributes)genericTypeParameter.Attributes;
			this.GenericParameterPosition = genericTypeParameter.Position;
			this.Constraints = new List<TypeData>();
		}

		#endregion // Constructors

		#region Base Class Overrides

		#region Accept

		/// <summary>
		/// Performs the specified visitor's functionality on this instance.
		/// </summary>
		/// <param name="visitor">The visitor whose functionality should be performed on the instance.</param>
		public override void Accept(MetadataItemVisitor visitor)
		{
			visitor.VisitGenericTypeParameterData(this);
		}

		#endregion // Accept

		#region AssemblyData

		/// <summary>
		/// Gets the <see cref="T:AssemblyData"/> representing the assembly in which the type is defined.
		/// </summary>
		public override AssemblyData AssemblyData
		{
			get { return _assembly; }
		}

		#endregion // AssemblyData

		#region DoesMatch

		internal override bool DoesMatch(MetadataItemBase other)
		{
			if (base.DoesMatch(other) == false)
				return false;

			var otherTyped = other as GenericTypeParameterData;
			if (otherTyped == null)
				return false;

			if (this.Constraints.Count != otherTyped.Constraints.Count)
				return false;

			for (int i = 0; i < this.Constraints.Count; i++)
			{
				if (this.Constraints[i].DisplayName != otherTyped.Constraints[i].DisplayName)
					return false;
			}

			if (this.GenericDeclaringMember.DisplayName != otherTyped.GenericDeclaringMember.DisplayName)
				return false;

			if (this.GenericParameterAttributes != otherTyped.GenericParameterAttributes)
				return false;

			if (this.GenericParameterPosition != otherTyped.GenericParameterPosition)
				return false;

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

			foreach (var constraint in this.Constraints)
				yield return constraint;

			// Any generic type parameter can convert to object
			var mscorlibData = this.AssemblyData.GetReferencedAssembly(Utilities.CommonObjectRuntimeAssemblyName);
			if (mscorlibData != null)
				yield return mscorlibData.GetTypeDefinitionData(Utilities.ObjectTypeName);
		}

		#endregion // GetDirectImplicitConversions

		#region GetDisplayName

		/// <summary>
		/// Gets the display name for the type, which can be used for generating user-readable messages about the type.
		/// </summary>
		/// <param name="fullyQualify">Indicates whether the type name should be fully qualified with declaring type and namespace names.</param>
		/// <param name="includeGenericInfo">Indicates whether generic parameters and arguments should be included in type names.</param>
		/// <returns>The display name of the type.</returns>
		public override string GetDisplayName(bool fullyQualify = true, bool includeGenericInfo = true)
		{
			return this.Name;
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
			var declaringGenericType = this.GenericDeclaringMember as TypeDefinitionData;
			if (declaringGenericType != null)
			{
				Debug.Assert(this == declaringGenericType.GenericParameters[this.GenericParameterPosition], "This type should be the generic parameter at its position in the declaring type.");

				var newGenericType = (TypeDefinitionData)declaringGenericType.GetEquivalentNewType(newAssemblyFamily);
				if (newGenericType == null || newGenericType.GenericParameters.Count <= this.GenericParameterPosition)
					return null;

				return newGenericType.GenericParameters[this.GenericParameterPosition];
			}

			var declaringGenericMethod = this.GenericDeclaringMember as MethodData;
			if (declaringGenericMethod != null)
			{
				Debug.Assert(this == declaringGenericMethod.GenericParameters[this.GenericParameterPosition], "This type should be the generic parameter at its position in the declaring method.");

				var newDeclaringType = (DeclaringTypeData)declaringGenericMethod.DeclaringType.GetEquivalentNewType(newAssemblyFamily);
				if (newDeclaringType == null)
					return null;

				var matchingMethods = newDeclaringType.GetMembers(declaringGenericMethod.Name).OfType<MethodData>().Where(m => declaringGenericMethod.IsEquivalentToNewMember(m, newAssemblyFamily)).ToList();
				if (matchingMethods.Count == 0)
					return null;

				Debug.Assert(matchingMethods.Count == 1, "There should only be one matching method.");
				var newGenericMethod = matchingMethods[0];
				if (newGenericMethod.GenericParameters.Count <= this.GenericParameterPosition)
					return null;


				return newGenericMethod.GenericParameters[this.GenericParameterPosition];
			}

			Debug.Fail("Unknown owner of the generic parameter");
			return null;
		}

		#endregion // GetEquivalentNewType

		#region IsEquivalentToNewMember

		internal override bool IsEquivalentToNewMember(MemberDataBase newMember, AssemblyFamily newAssemblyFamily)
		{
			if (base.IsEquivalentToNewMember(newMember, newAssemblyFamily) == false)
				return false;

			var newGenericParameter = (GenericTypeParameterData)newMember;
			if (this.GenericParameterPosition != newGenericParameter.GenericParameterPosition)
				return false;

			if (this.GenericDeclaringMember.MetadataItemKind == MetadataItemKinds.Method &&
				newGenericParameter.GenericDeclaringMember.MetadataItemKind == MetadataItemKinds.Method)
			{
				// We will get in here recursively for generic methods that take one of their own generic parameters as a parameter
				// because the method will check to see whether its parameters are equivalent. All other things being equal, we don't
				// need to recheck that the methods are equal here (and if we do, we will end up with a SOE). If the methods are 
				// otherwise equal, so are these parameters because they came from the same method and had the same position. 
				// If the methods are not, neither are the parameters.
				if (_isInIsEquivalentToNewMember)
					return true;

				try
				{
					_isInIsEquivalentToNewMember = true;
					return this.GenericDeclaringMember.IsEquivalentToNewMember(newGenericParameter.GenericDeclaringMember, newAssemblyFamily);
				}
				finally
				{
					_isInIsEquivalentToNewMember = false;
				}
			}

			return this.GenericDeclaringMember.IsEquivalentToNewMember(newGenericParameter.GenericDeclaringMember, newAssemblyFamily);
		}

		#endregion // IsEquivalentToNewMember

		#region MetadataItemKind

		/// <summary>
		/// Gets the type of item the instance represents.
		/// </summary>
		public override MetadataItemKinds MetadataItemKind
		{
			get { return MetadataItemKinds.GenericTypeParameter; }
		}

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
			for (int i = 0; i < genericParameters.Count; i++)
			{
				if (this == genericParameters[i])
				{
					Debug.Assert(this.GenericParameterPosition == i, "We are expecting the generic argument to be in its proper position.");
					return genericArguments[i];
				}
			}

			return this;
		}

		#endregion // ReplaceGenericTypeParameters

		#endregion // Base Class Overrides

		#region Methods

		#region Public Methods

		/// <summary>
		/// Gets the derived <see cref="GenericTypeParameterData"/> instance representing the specified type.
		/// </summary>
		/// <typeparam name="T">The type for which to get the <see cref="GenericTypeParameterData"/>.</typeparam>
		/// <returns>The derived <see cref="GenericTypeParameterData"/> instance.</returns>
		public new static GenericTypeParameterData FromType<T>()
		{
			return GenericTypeParameterData.FromType(typeof(T));
		}

		/// <summary>
		/// Gets the derived <see cref="GenericTypeParameterData"/> instance representing the specified type.
		/// </summary>
		/// <returns>The derived <see cref="GenericTypeParameterData"/> instance.</returns>
		public new static GenericTypeParameterData FromType(Type t)
		{
			if (t.IsGenericParameter == false)
				throw new ArgumentException("The specified type is not a valid generic type parameter.", "t");

			var module = t.Assembly.ToAssemblyDefinition().MainModule;
			var declaringType = module.GetType(t.DeclaringType.FullName, runtimeName: true);

			if (t.DeclaringMethod != null)
			{
				var methods = declaringType.Resolve().Methods.Where(
					m => m.Name == t.DeclaringMethod.Name &&
					m.Parameters.Count == t.DeclaringMethod.GetParameters().Length &&
					m.GenericParameters.Count == t.DeclaringMethod.GetGenericArguments().Length);

				// TODO: Test this with various cases (ref and out parameters, parameters types being nested types
				foreach (var method in methods)
				{
					var isMatch = true;

					int parameterIndex = 0;
					foreach (var parameter in t.DeclaringMethod.GetParameters())
					{
						if (method.Parameters[parameterIndex++].ParameterType.EqualsType(parameter.ParameterType) == false)
						{
							isMatch = false;
							break;
						}
					}

					if (isMatch)
						return GenericTypeParameterData.FromType(method.GenericParameters[t.GenericParameterPosition]);
				}

				Debug.Fail("Cannot find matching method");
				return null;
			}
			else
			{
				return GenericTypeParameterData.FromType(declaringType.GenericParameters[t.GenericParameterPosition]);
			}
		}

		/// <summary>
		/// Gets the derived <see cref="GenericTypeParameterData"/> instance representing the specified type.
		/// </summary>
		/// <returns>The derived <see cref="GenericTypeParameterData"/> instance.</returns>
		internal static GenericTypeParameterData FromType(GenericParameter t)
		{
			return AssemblyData.FromAssembly(t.GetDeclaringAssembly()).GetGenericTypeParameterData(t);
		}

		

		#endregion // Public Methods

		#region Internal Methods

		#region FinalizeDefinition

#if DEBUG
		/// <summary>
		/// Populates the type with additional information which can't be loaded when the type is created (due to potential circularities in item dependencies).
		/// </summary>
		/// <param name="underlyingType">The underlying type this instance represents.</param>
#endif
		internal void FinalizeDefinition(GenericParameter underlyingType)
		{
			foreach (var type in underlyingType.Constraints)
				this.Constraints.Add(TypeData.FromType(type));
		}

		#endregion // FinalizeDefinition

		#region GetParameterListDisplayText

#if DEBUG
		/// <summary>
		/// Gets the display text for the type parameter when it is being displayed in a parameter list.
		/// </summary> 
#endif
		internal string GetParameterListDisplayText()
		{
			switch (this.GenericParameterAttributes & System.Reflection.GenericParameterAttributes.VarianceMask)
			{
				case System.Reflection.GenericParameterAttributes.None:
					return this.Name;

				case System.Reflection.GenericParameterAttributes.Covariant:
					return GenericTypeParameterData.OutVarianceModifier + this.Name;

				case System.Reflection.GenericParameterAttributes.Contravariant:
					return GenericTypeParameterData.InVarianceModifier + this.Name;

				default:
					Debug.Fail("Unknown GenericParameterAttributes: " + this.GenericParameterAttributes);
					return this.Name;
			}
		}

		#endregion // GetParameterListDisplayText

		#region IsGenericTypeArgumentVariant

#if DEBUG
		/// <summary>
		/// Determines whether the variance of the type parameter allows the source type in the parameter's position to vary to the target type when the declaring
		/// generic of one construction is trying to be converted to a another construction.
		/// </summary>
		/// <param name="targetArgument">The type in this parameter's position in the target constructed generic type.</param>
		/// <param name="sourceArgument">The type in this parameter's position in the source constructed generic type.</param>
		/// <param name="context">Information about the context of the IsAssignableFrom invocation.</param>
#endif
		internal bool IsGenericTypeArgumentVariant(TypeData targetArgument, TypeData sourceArgument, IsAssignableFromContext context)
		{
			var variance = this.GenericParameterAttributes & System.Reflection.GenericParameterAttributes.VarianceMask;
			switch (variance)
			{
				case System.Reflection.GenericParameterAttributes.None:
					return targetArgument.IsEquivalentTo(sourceArgument, context.NewAssemblyFamily, context.IsSourceTypeOld);

				case System.Reflection.GenericParameterAttributes.Contravariant:
					return sourceArgument.IsAssignableFrom(targetArgument, new IsAssignableFromContext(context.NewAssemblyFamily, context.IsSourceTypeOld, onlyReferenceAndIdentityConversions: true));

				case System.Reflection.GenericParameterAttributes.Covariant:
					return targetArgument.IsAssignableFrom(sourceArgument, new IsAssignableFromContext(context.NewAssemblyFamily, context.IsSourceTypeOld, onlyReferenceAndIdentityConversions: true));

				default:
					Debug.Fail("Unknown variance: " + variance);
					return false;
			}
		}

		#endregion // IsGenericTypeArgumentVariant

		#endregion // Internal Methods

		#endregion // Methods

		#region Properties

		/// <summary>
		/// Gets the set of constraints imposed on the generic type parameter.
		/// </summary>
		public List<TypeData> Constraints { get; private set; }

		/// <summary>
		/// Gets the method or delegate which defines the generic type parameter.
		/// </summary>
		public MemberDataBase GenericDeclaringMember { get; internal set; } // TODO_Serialize: Test and round-trip

		/// <summary>
		/// Gets the attributes (variance and additional constraints) of the generic type parameter.
		/// </summary>
		public System.Reflection.GenericParameterAttributes GenericParameterAttributes { get; private set; }

		/// <summary>
		/// Gets the 0-based position of the parameter in the declaring type's generic type parameter list.
		/// </summary>
		public int GenericParameterPosition { get; private set; }

		#endregion // Properties
	}
}
