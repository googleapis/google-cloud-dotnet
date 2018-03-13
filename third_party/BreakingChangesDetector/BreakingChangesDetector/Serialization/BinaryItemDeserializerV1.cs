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

using BreakingChangesDetector.MetadataItems;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BreakingChangesDetector.Serialization
{
	internal class BinaryItemDeserializerV1
	{
		private readonly BinaryReader _reader;
		private readonly Dictionary<uint, TypeData> _typeTable;

		public BinaryItemDeserializerV1(Stream stream)
		{
			_reader = new BinaryReader(stream);
			_typeTable = new Dictionary<uint, TypeData>();

			// TODO_Serialize: Use a factory method instead of reading directly.
			var versionMarker = _reader.ReadByte();
			Debug.Assert(versionMarker == SerializationUtilities.Version1Marker, "Incorrect version");

			var assemblyCount = _reader.ReadUInt16();
			this.LoadedAssemblies = this.ReadAssemblyDataCollection(assemblyCount);
			this.ReadAdditionalData();
		}

		private void ReadAdditionalData()
		{
			var length = _reader.BaseStream.Length;
			while (_reader.BaseStream.Position < length)
			{
				var typeId = _reader.ReadUInt32();
				var typeBase = _typeTable[typeId];
				var type = typeBase as TypeDefinitionData;
				if (type != null)
				{
					// TODO_Serialize: Fix this
					//if (type.IsConstructedGenericType)
					//{
					//	var hasSpecialDecalringType = _reader.ReadBoolean();
					//	if (hasSpecialDecalringType)
					//	{
					//		var declaringType = _reader.ReadUInt32();
					//		type.DeclaringType = (TypeDefinitionData)_typeTable[declaringType];
					//	}
					//}

					var baseTypeId = _reader.ReadUInt32();

					if (baseTypeId != SerializationUtilities.NullTypeId)
						type.BaseType = (TypeDefinitionData)_typeTable[baseTypeId];

					var interfaceCount = _reader.ReadUInt16();
					var interfaceTypeIds = new uint[interfaceCount];
					for (int i = 0; i < interfaceCount; i++)
						interfaceTypeIds[i] = _reader.ReadUInt32();

					var implementedInterfaces = new ImplementedInterfacesCollection(interfaceTypeIds.Select(i => (DeclaringTypeData)_typeTable[i]));
					
					type.ImplementedInterfaces = implementedInterfaces;

					type.GenericParameters = this.ReadGenericParametersCollection();

					if (type.TypeKind == TypeKind.Delegate)
					{
						var returnTypeId = _reader.ReadUInt32();
						type.DelegateReturnType = _typeTable[returnTypeId];
						type.DelegateParameters = this.ReadParametersCollection(type.MetadataItemKind);
					}
					else
					{
						var memberCount = _reader.ReadInt32();
						for (int i = 0; i < memberCount; i++)
							type.AddMember(this.ReadMember(type));
					}
				}
				else
				{
					var genericTypeParameterData = (GenericTypeParameterData)typeBase;

					var constraintCount = _reader.ReadUInt16();
					for (int i = 0; i < constraintCount; i++)
					{
						var contraintTypeId = _reader.ReadUInt32();
						genericTypeParameterData.Constraints.Add(_typeTable[contraintTypeId]);
					}
				}
			}
		}

		private MemberDataBase ReadMember(TypeDefinitionData declaringType)
		{
			var memberItemKind = (MetadataItemKinds)_reader.ReadUInt16();
			if (memberItemKind == MetadataItemKinds.TypeDefinition)
			{
				var nestedTypeId = _reader.ReadUInt32();
				var nestedType = _typeTable[nestedTypeId];

				if (nestedType.DeclaringType == null)
					nestedType.DeclaringType = declaringType;

				return nestedType;
			}

			var name = _reader.ReadString();
			var accessibility = (MemberAccessibility)_reader.ReadByte();
			var memberFlags = (MemberFlags)_reader.ReadByte();

			if (memberItemKind == MetadataItemKinds.Constructor)
			{
				var parameters = this.ReadParametersCollection(memberItemKind);
				return new ConstructorData(name, accessibility, memberFlags, parameters)
				{
					DeclaringType = declaringType,
				};
			}

			var typeId = _reader.ReadUInt32();
			var type = _typeTable[typeId];

			switch (memberItemKind)
			{
				case MetadataItemKinds.Constant:
					object constantValue = null; // TODO_Serialize: get the real value here
					return new ConstantData(name, accessibility, memberFlags, type, false, constantValue)
					{
						DeclaringType = declaringType,
					};

				case MetadataItemKinds.Event:
					return new EventData(name, accessibility, memberFlags, type)
					{
						DeclaringType = declaringType,
					};

				case MetadataItemKinds.Field:
					{
						var isReadOnly = _reader.ReadBoolean();
						return new FieldData(name, accessibility, memberFlags, type, false, isReadOnly)
						{
							DeclaringType = declaringType,
						};
					}

				case MetadataItemKinds.Method:
					{
						var isExtensionMethod = _reader.ReadBoolean();
						var genericParameters = this.ReadGenericParametersCollection();
						var parameters = this.ReadParametersCollection(memberItemKind);
						return new MethodData(name, accessibility, memberFlags, type, false, genericParameters, isExtensionMethod, parameters)
						{
							DeclaringType = declaringType,
						};
					}

				case MetadataItemKinds.Operator:
					{
						var parameters = this.ReadParametersCollection(memberItemKind);
						return new OperatorData(name, accessibility, memberFlags, type, false, parameters)
						{
							DeclaringType = declaringType,
						};
					}

				case MetadataItemKinds.Indexer:
				case MetadataItemKinds.Property:
					{
						var getMethodAccessibilityTemp = _reader.ReadByte();
						var getMethodAccessibility = getMethodAccessibilityTemp == 0xFF
							? default(MemberAccessibility?)
							: (MemberAccessibility)getMethodAccessibilityTemp;
						var setMethodAccessibilityTemp = _reader.ReadByte();
						var setMethodAccessibility = setMethodAccessibilityTemp == 0xFF
							? default(MemberAccessibility?)
							: (MemberAccessibility)setMethodAccessibilityTemp;

						if (memberItemKind == MetadataItemKinds.Property)
						{
							return new PropertyData(name, accessibility, memberFlags, type, false, getMethodAccessibility, setMethodAccessibility)
							{
								DeclaringType = declaringType,
							};
						}
						else
						{
							var parameters = this.ReadParametersCollection(memberItemKind);
							return new IndexerData(name, accessibility, memberFlags, type, false, parameters, getMethodAccessibility, setMethodAccessibility)
							{
								DeclaringType = declaringType,
							};
						}
					}

				case MetadataItemKinds.Assembly:
				case MetadataItemKinds.GenericTypeParameter:
				case MetadataItemKinds.Parameter:
				default:
					Debug.Fail("Incorrect member type.");
					return null;
			}
		}

		private GenericTypeParameterCollection ReadGenericParametersCollection()
		{
			var genericParametersCount = _reader.ReadUInt16();

			if (genericParametersCount == 0)
				return GenericTypeParameterData.EmptyList;

			var genericParameterIds = new uint[genericParametersCount];
			for (int i = 0; i < genericParametersCount; i++)
				genericParameterIds[i] = _reader.ReadUInt32();

			return new GenericTypeParameterCollection(genericParameterIds.Select(i => (GenericTypeParameterData)_typeTable[i]));
		}

		private ParameterCollection ReadParametersCollection(MetadataItemKinds declaringMemberKind)
		{
			var parametersCount = _reader.ReadUInt16();

			var parameters = new ParameterCollection();
			for (int i = 0; i < parametersCount; i++)
				parameters.Add(this.ReadParameter(declaringMemberKind));

			return parameters;
		}

		private ParameterData ReadParameter(MetadataItemKinds declaringMemberKind)
		{
			var name = _reader.ReadString();
			var typeId = _reader.ReadUInt32();
			var modifier = (MetadataItems.ParameterModifier)_reader.ReadByte();
			var flags = (ParameterData.InternalFlags)_reader.ReadByte();
			
			object defaultValue = null;
			if ((flags & ParameterData.InternalFlags.IsOptional) != 0)
				defaultValue = this.ReadDefaultValue();

			return new ParameterData(declaringMemberKind, name, _typeTable[typeId], modifier, flags, defaultValue);
		}

		private AssemblyData[] ReadAssemblyDataCollection(int assemblyCount)
		{
			var family = new AssemblyFamily();

			var loadedAssemblies = new AssemblyData[assemblyCount];
			for (int i = 0; i < assemblyCount; i++)
				loadedAssemblies[i] = this.ReadAssemblyData(family);

			return loadedAssemblies;
		}

		private AssemblyData ReadAssemblyData(AssemblyFamily family)
		{
			var fullName = _reader.ReadString();
			var typeCount = _reader.ReadInt32();

			var assemblyData = new AssemblyData(fullName, null, null, null); // TODO_Serialize: pass the names here
			//for (int i = 0; i < typeCount; i++)
			//	assemblyData.AddType(this.ReadTypeDataBase(assemblyData));

			family.Add(assemblyData);
			return assemblyData;
		}

		private TypeData ReadTypeDataBase(AssemblyData assemblyData)
		{
			var typeId = _reader.ReadUInt32();
			var name = _reader.ReadString();
			var accessibility = (MemberAccessibility)_reader.ReadByte();
			var memberFlags = (MemberFlags)_reader.ReadByte();
			var typeKind = (TypeKind)_reader.ReadByte();
			var delegateReturnTypeIsDynamic = _reader.ReadBoolean();

			TypeData type;

			var isTypeData = _reader.ReadBoolean();
			if (isTypeData)
			{
				var typeFlags = (TypeDefinitionFlags)_reader.ReadByte();
				var hasFullName = _reader.ReadBoolean();
				var fullName = hasFullName ? _reader.ReadString() : null;

				type = new TypeDefinitionData(name, accessibility, memberFlags, typeKind, assemblyData, fullName, typeFlags, delegateReturnTypeIsDynamic);
			}
			else
			{
				var genericParameterAttributes = (GenericParameterAttributes)_reader.ReadInt32();
				var genericParameterPosition = (int)_reader.ReadUInt16();

				type = new GenericTypeParameterData(name, accessibility, memberFlags, typeKind, assemblyData, genericParameterAttributes, genericParameterPosition);
			}

			_typeTable.Add(typeId, type);
			return type;
		}

		private object ReadDefaultValue()
		{
			var hasNonNullValue = _reader.ReadBoolean();

			object value = null;
			if (hasNonNullValue)
			{
				var typeName = _reader.ReadString();

				if (typeName == typeof(bool).FullName)
					value = _reader.ReadBoolean();
				else if (typeName == typeof(byte).FullName)
					value = _reader.ReadByte();
				else if (typeName == typeof(char).FullName)
					value = _reader.ReadChar();
				else if (typeName == typeof(decimal).FullName)
					value = _reader.ReadDecimal();
				else if (typeName == typeof(double).FullName)
					value = _reader.ReadDouble();
				else if (typeName == typeof(float).FullName)
					value = _reader.ReadSingle();
				else if (typeName == typeof(int).FullName)
					value = _reader.ReadInt32();
				else if (typeName == typeof(long).FullName)
					value = _reader.ReadInt64();
				else if (typeName == typeof(sbyte).FullName)
					value = _reader.ReadSByte();
				else if (typeName == typeof(short).FullName)
					value = _reader.ReadInt16();
				else if (typeName == typeof(string).FullName)
					value = _reader.ReadString();
				else if (typeName == typeof(uint).FullName)
					value = _reader.ReadUInt32();
				else if (typeName == typeof(ulong).FullName)
					value = _reader.ReadUInt64();
				else if (typeName == typeof(ushort).FullName)
					value = _reader.ReadUInt16();
				else // The value is an enum and is encoded as a ulong
					value = _reader.ReadUInt64();
			}

			return value;
		}

		public AssemblyData[] LoadedAssemblies { get; private set; }
	}
}
