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
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BreakingChangesDetector.MetadataItems
{
	/// <summary>
	/// Abstract base class representing metadata for externally visible members declared within a type.
	/// </summary>
	public abstract class MemberDataBase : MetadataItemBase
	{
		#region Constants

		internal const BindingFlags DeclaredOnlyFlags =
			BindingFlags.Public | BindingFlags.NonPublic |
			BindingFlags.Instance | BindingFlags.Static |
			BindingFlags.DeclaredOnly;

		#endregion // Constants

		#region Static Variables

		internal static readonly List<MemberDataBase> EmptyList = new List<MemberDataBase>();

		#endregion // Static Variables

		#region Constructor

		internal MemberDataBase(string name, MemberAccessibility accessibility, MemberFlags memberFlags)
		{
			this.Accessibility = accessibility;
			this.MemberFlags = memberFlags;
			this.Name = name;
		}

		internal MemberDataBase(MemberReference underlyingMember, MemberAccessibility accessibility, MemberFlags memberFlags, DeclaringTypeData declaringType)
		{
			this.Accessibility = accessibility;
			this.DeclaringType = declaringType;
			this.MemberFlags = memberFlags;
			this.Name = underlyingMember.Name;
		}

		#endregion // Constructor

		#region Base Class Overrides

		#region DisplayName

		/// <summary>
		/// Gets the name to use for this item in messages.
		/// </summary>
		public override string DisplayName
		{
			get { return this.Name; }
		}

		#endregion // DisplayName

		#region DoesMatch

		internal override bool DoesMatch(MetadataItemBase other)
		{
			if (base.DoesMatch(other) == false)
				return false;

			var otherTyped = other as MemberDataBase;
			if (otherTyped == null)
				return false;

			if (this.Accessibility != otherTyped.Accessibility)
				return false;

			if (this.DeclaringType == null ^ otherTyped.DeclaringType == null)
				return false;

			if (this.DeclaringType != null && this.DeclaringType.DisplayName != otherTyped.DeclaringType.DisplayName)
				return false;

			if (this.MemberFlags != otherTyped.MemberFlags)
				return false;

			if (this.Name != otherTyped.Name)
				return false;

			return true;
		}

		#endregion // DoesMatch

		#endregion // Base Class Overrides

		#region Methods

		#region CanOverrideMember

#if DEBUG
		/// <summary>
		/// Indicates whether the current member can override the specified member from a base type.
		/// </summary>
		/// <param name="baseMember">The member from the base type.</param>
		/// <returns>True if the current member can override the base member; False otherwise.</returns>  
#endif
		internal virtual bool CanOverrideMember(MemberDataBase baseMember)
		{
			// Static members cannot be overridden
			if (this.IsStatic || baseMember.IsStatic)
				return false;

			// Members which are not virtual, abstract, or override cannot be overridden.
			if (this.IsVirtualCallType == false || baseMember.IsVirtualCallType == false)
				return false;

			return
				this.Accessibility == baseMember.Accessibility &&
				this.Name == baseMember.Name;
		}

		#endregion // CanOverrideMember

		#region GetBaseMember

#if DEBUG
		/// <summary>
		/// Gets the base member this member overrides, or null if this member doesn't override anything.
		/// </summary>
		/// <returns></returns>  
#endif
		internal MemberDataBase GetBaseMember()
		{
			if (this.DeclaringType == null || this.IsOverride == false)
				return null;

			var baseType = this.DeclaringType.BaseType;
			while (baseType != null)
			{
				var members = baseType.GetMembers(this.Name).Where(m => m.MetadataItemKind == this.MetadataItemKind && m.CanBeOverridden);
				foreach (var member in members)
				{
					if (this.CanOverrideMember(member))
						return member;
				}

				baseType = baseType.BaseType;
			}

			return null;
		}

		#endregion // GetBaseMember

		#region IsEquivalentToNewMember

#if DEBUG
		/// <summary>
		/// Indicates whether a new member of the same type and name is logically the same member as the current member, just from a newer build.
		/// </summary> 
#endif
		internal virtual bool IsEquivalentToNewMember(MemberDataBase newMember, AssemblyFamily newAssemblyFamily)
		{
			if (this.IsNameUsedToVerifyEquivalence && this.Name != newMember.Name)
				return false;

			return this.MetadataItemKind == newMember.MetadataItemKind;
		}

		#endregion // IsEquivalentToNewMember

		#region MemberDataFromReflection

		internal static MemberDataBase MemberDataFromReflection(MemberReference member, DeclaringTypeData declaringType)
		{
			try
			{
				switch (member.MetadataToken.TokenType)
				{
					case TokenType.TypeDef:
						return declaringType.AssemblyData.GetTypeData((TypeDefinition)member);

					case TokenType.Method:
						{
							var method = (MethodDefinition)member;

							if (method.IsConstructor)
								return ConstructorData.ConstructorDataFromReflection(method, declaringType);

							if (method.IsSpecialName)
							{
								if (method.IsPublic && method.IsStatic && method.Name.StartsWith("op_"))
									return new OperatorData(method, declaringType);

								return null;
							}

							return MethodData.MethodDataFromReflection(method, declaringType);
						}

					case TokenType.Field:
						{
							var field = (FieldDefinition)member;

							// Filter out the "value__" field on enums
							if (declaringType.TypeKind == TypeKind.Enum && field.IsStatic == false)
								return null;

							if (field.IsLiteral && field.IsInitOnly == false)
								return ConstantData.ConstantDataFromReflection(field, declaringType);

							return FieldData.FieldDataFromReflection(field, declaringType);
						}

					case TokenType.Event:
						return EventData.EventDataFromReflection((EventDefinition)member, declaringType);

					case TokenType.Property:
						{
							var property = (PropertyDefinition)member;
							if (property.HasParameters)
								return IndexerData.IndexerDataFromReflection(property, declaringType);

							return PropertyData.PropertyDataFromReflection(property, declaringType);
						}

					default:
						Debug.Fail("Unknown TokenType: " + member.MetadataToken.TokenType);
						return null;
				}
			}
			catch (AssemblyResolutionException ex)
			{
				// TODO: How should we handle this? This happens when an assembly reference cant be found.
				Debug.Fail("Could not load assembly: " + ex.ToString());
				return null;
			}
		}

		#endregion // MemberDataFromReflection

		#region ReplaceGenericTypeParameters

#if DEBUG
		/// <summary>
		/// Replaces all type parameters used by the member with their associated generic arguments specified in a constructed generic type.
		/// </summary>
		/// <param name="genericParameters">The generic parameters being replaced.</param>
		/// <param name="genericArguments">The generic arguments replacing the parameters.</param>
		/// <returns>A new member with the replaced type parameters or the current instance if the member does not use any of the generic parameters.</returns> 
#endif
		internal abstract MemberDataBase ReplaceGenericTypeParameters(GenericTypeParameterCollection genericParameters, GenericTypeArgumentCollection genericArguments);

		#endregion // ReplaceGenericTypeParameters

		#endregion // Methods

		#region Properties

		#region Public Properties

		/// <summary>
		/// Gets the external accessibility of the member, which indicates whether it is public or protected.
		/// </summary>
		public MemberAccessibility Accessibility { get; private set; }

		/// <summary>
		/// Gets the <see cref="T:AssemblyData"/> representing the assembly in which the member is defined.
		/// </summary>
		public virtual AssemblyData AssemblyData { get { return this.DeclaringType == null ? null : this.DeclaringType.AssemblyData; } }

		/// <summary>
		/// Gets the value indicating whether the member can be overridden in derived types.
		/// </summary>
		public bool CanBeOverridden { get { return this.IsSealed == false && this.IsVirtualCallType; } }

		/// <summary>
		/// Gets the type in which this member is declared.
		/// </summary>
		public DeclaringTypeData DeclaringType { get; internal set; } // TODO: Make private?

		/// <summary>
		/// Gets the value indicating whether the member is marked abstract.
		/// </summary>
		public bool IsAbstract { get { return this.MemberFlags.HasFlag(MemberFlags.Abstract); } }

		/// <summary>
		/// Gets the value indicating whether the member is and instance member.
		/// </summary>
		public bool IsInstance { get { return this.IsStatic == false; } }

		/// <summary>
		/// Gets the value indicating whether the <see cref="Name"/> of the member is primarily used to determine whether it is equivalent to another member.
		/// </summary>
		public virtual bool IsNameUsedToVerifyEquivalence { get { return true; } }

		/// <summary>
		/// Gets the value indicating whether the member overrides another.
		/// </summary>
		public bool IsOverride { get { return this.MemberFlags.HasFlag(MemberFlags.Override); } }

		/// <summary>
		/// Gets the value indicating whether the member is marked sealed.
		/// </summary>
		public bool IsSealed { get { return this.MemberFlags.HasFlag(MemberFlags.Sealed); } }

		/// <summary>
		/// Gets the value indicating whether the member is marked static.
		/// </summary>
		public bool IsStatic { get { return this.MemberFlags.HasFlag(MemberFlags.Static); } }

		/// <summary>
		/// Gets the value indicating whether the member is marked virtual.
		/// </summary>
		public bool IsVirtual { get { return this.MemberFlags.HasFlag(MemberFlags.Virtual); } }

		/// <summary>
		/// Gets the value indicating whether the member uses a virtual call type (is marked virtual, abstract, or override).
		/// </summary>
		public bool IsVirtualCallType { get { return (this.MemberFlags & (MemberFlags.Virtual | MemberFlags.Abstract | MemberFlags.Override)) != 0; } }

		/// <summary>
		/// Gets the name of the member.
		/// </summary>
		public string Name { get; private set; }

		#endregion // Public Properties

		#region Internal Properties

		internal MemberFlags MemberFlags { get; private set; }

		#endregion // Internal Properties

		#endregion // Properties
	}
}
