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
using System.Text;
using System.Threading.Tasks;

namespace BreakingChangesDetector.Serialization
{
	internal class BinaryItemSerializerV1
	{
		/*
		 * File structure
		 * ***************************************************************************
		 * byte: Version1 marker
		 * ushort: Count of assemblies in assembly table
		 * ------ For each AssemblyData in assembly table ----------------------------
		 *		string FullName
		 *		int: Count of types in AssemblyData
		 *		------ For each TypeDataBase in AssemblyData -------------------------
		 *			uint: id in type table
		 *			string: Name
		 *			byte: Accessibility
		 *			byte: MemberFlags
		 *			byte: TypeKind
		 *			bool: (type is TypeData)
		 *			------ If (type is TypeData) -------------------------------------
		 *				byte: TypeFlags
		 *				bool: (FullName != null)
		 *				------ If (FullName != null) ---------------------------------
		 *					string: FullName
		 *				------ End If ------------------------------------------------
		 *			------ Else ------------------------------------------------------
		 *				int: GenericParameterAttributes
		 *				ushort: GenericParameterPosition
		 *			------ End If ----------------------------------------------------
		 *		------ End for each --------------------------------------------------
		 * ------ End for each -------------------------------------------------------
		 * ------ For each TypeDataBase in type table (non-constructed types 1st) ----
		 *		uint: id in type table
		 *		------ If (TypeDataBase is TypeData) ---------------------------------
		 *			------ If (IsConstructedGenericType) -----------------------------
		 *				bool: (DeclaringType != null)
		 *				------ If (DeclaringType != null) ----------------------------
		 *					uint: id of DeclaringType in type table
		 *				------ End If ------------------------------------------------
		 *			------ End If ----------------------------------------------------
		 *			uint: id of BaseType in type table (0 for null)
		 *			ushort: Count of ImplementedInterfaces
		 *			------ For each TypeData in ImplementedInterfaces ----------------
		 *				uint: id of TypeData in type table
		 *			----- End for each -----------------------------------------------
		 *			(GenericParameters : GenericParameters)
		 *			------ If (TypeKind == Delegate) ---------------------------------
		 *				uint: id of DelegateReturnType in type table
		 *				(ParameterCollection : DelegateParameters)
		 *			------ Else ------------------------------------------------------
		 *				int: Count of members in TypeData
		 *				------ For each MemberDataBase in members --------------------
		 *					ushort: MetadataItemKind
		 *					----- If (MetadataItemKind == Type) ----------------------
		 *						uint: id of TypeData in type table
		 *					----- Else -----------------------------------------------
		 *						string: Name
		 *						byte: Accessibility
		 *						byte: MemberFlags
		 *						----- If (MetadataItemKind == Constructor) -----------
		 *							(ParameterCollection : Parameters)
		 *						----- Else If (MetadataItemKind == Operator) ---------
		 *							uint: id of Type in type table
		 *							(ParameterCollection : Parameters)
		 *						----- Else If (MetadataItemKind == Method) -----------
		 *							uint: id of Type in type table
		 *							bool: IsExtensionMethod
		 *							(GenericParameters : GenericParameters)
		 *							(ParameterCollection : Parameters)
		 *						----- Else If (MetadataItemKind == Constant) ---------
		 *							uint: id of Type in type table
		 *						----- Else If (MetadataItemKind == Field) ------------
		 *							uint: id of Type in type table
		 *							bool: IsReadOnly
		 *						----- Else If (MetadataItemKind == Event) ------------
		 *							uint: id of Type in type table
		 *						----- Else If (MetadataItemKind == Indexer) ----------
		 *							uint: id of Type in type table
		 *							byte: GetMethodAccessibility (0xFF for null)
		 *							byte: SetMethodAccessibility (0xFF for null)
		 *							(ParameterCollection : Parameters)
		 *						----- Else If (MetadataItemKind == Property) ---------
		 *							uint: id of Type in type table
		 *							byte: GetMethodAccessibility (0xFF for null)
		 *							byte: SetMethodAccessibility (0xFF for null)
		 *						----- End If -----------------------------------------
		 *					----- End If ---------------------------------------------
		 *				----- End for each -------------------------------------------
		 *			------ End If ----------------------------------------------------
		 *		------ Else ----------------------------------------------------------
		 *			ushort: Constraints.Count
		 *			------ For each TypeDataBase in Constraints ----------------------
		 *				uint: id of TypeDataBase in type table
		 *			------ End for each ----------------------------------------------
		 *		------ End If --------------------------------------------------------
		 * ------ End for each -------------------------------------------------------
		 * ***************************************************************************
		 * ------ Helper (ParameterCollection) ---------------------------------------
		 *		ushort: Count of parameters in Parameters
		 *		------ For each ParameterData in Parameters --------------------------
		 *			string: Name
		 *			uint: id of Type in type table
		 *			byte: Modifier
		 *			bool: IsParamsArray
		 *			bool: HasDefaultValue
		 *			------ If (HasDefaultValue) --------------------------------------
		 *				bool: (Value != null)
		 *				------ If (Value != null) ------------------------------------
		 *					string: TypeFullName
		 *					(type specific Value)
		 *				------ End If ------------------------------------------------
		 *			------ End If ----------------------------------------------------
		 *		----- End for each ---------------------------------------------------
		 * ----- End ParameterCollection ---------------------------------------------
		 * ***************************************************************************
		 * ------ Helper (GenericParameters) -----------------------------------------
		 *		ushort: Count of parameters in GenericParameters
		 *		------ For each GenericTypeParameterData in GenericParameters --------
		 *			uint: id of GenericTypeParameterData in type table
		 *		----- End for each ---------------------------------------------------
		 * ----- End GenericParameters -----------------------------------------------
		 * ***************************************************************************
		 */

		private readonly AdditionalDataWriter _additionalDataWriter;
		private uint _nextTypeId = SerializationUtilities.FirstTypeId;
		private readonly Dictionary<TypeData, uint> _typeTable;
		private readonly BinaryWriter _writer;

		public BinaryItemSerializerV1(Stream stream, AssemblyData[] assemblies)
		{
			_additionalDataWriter = new AdditionalDataWriter(this);
			_typeTable = new Dictionary<TypeData, uint>();
			_writer = new BinaryWriter(stream);

			// TODO_Serialize: Use a factory method instead of writing directly.
			_writer.Write(SerializationUtilities.Version1Marker);

			this.WriteTypeTable(assemblies);
			this.WriteAdditionalInfo();
		}

		private uint GetTypeId(TypeData type)
		{
			if (type == null)
				return SerializationUtilities.NullTypeId;

			uint id;
			if (_typeTable.TryGetValue(type, out id) == false)
				Debug.Fail("Could not find the type in the table.");

			return id;
		}

		#region WriteAdditionalInfo

		private void WriteAdditionalInfo()
		{
			foreach (var pair in _typeTable.Where(p => IsConstructedGenericType(p.Key) == false))
				this.WriteAdditionalInfoHelper(pair.Key, pair.Value);

			foreach (var pair in _typeTable.Where(p => IsConstructedGenericType(p.Key)))
				this.WriteAdditionalInfoHelper(pair.Key, pair.Value);
		}

		private static bool IsConstructedGenericType(TypeData typeBase)
		{
			return typeBase is ConstructedGenericTypeData;
		}

		private void WriteAdditionalInfoHelper(TypeData typeBase, uint typeId)
		{
			_writer.Write(typeId);

			var type = typeBase as TypeDefinitionData;
			if (type != null)
			{
				// TODO_Serialize: Fix this
				//if (type.IsConstructedGenericType)
				//{
				//	var hasSpecialDecalringType = type.DeclaringType != null;
				//	_writer.Write(hasSpecialDecalringType);
				//	if (hasSpecialDecalringType)
				//		_writer.Write(this.GetTypeId(type.DeclaringType));
				//}

				_writer.Write(this.GetTypeId(type.BaseType));

				_writer.Write((ushort)type.ImplementedInterfaces.Count);
				for (int i = 0; i < type.ImplementedInterfaces.Count; i++)
					_writer.Write(this.GetTypeId(type.ImplementedInterfaces[i]));

				this.WriteAdditionalInfoHelper(type.GenericParameters);

				if (type.TypeKind == TypeKind.Delegate)
				{
					_writer.Write(this.GetTypeId(type.DelegateReturnType));
					this.WriteAdditionalInfoHelper(type.DelegateParameters);
				}
				else
				{
					var members = type.GetMembers().ToArray();
					_writer.Write(members.Length);
					for (int i = 0; i < members.Length; i++)
						members[i].Accept(_additionalDataWriter);
				}
			}
			else
			{
				var genericTypeParameterData = (GenericTypeParameterData)typeBase;
				_writer.Write((ushort)genericTypeParameterData.Constraints.Count);
				for (int i = 0; i < genericTypeParameterData.Constraints.Count; i++)
					_writer.Write(this.GetTypeId(genericTypeParameterData.Constraints[i]));
			}
		}

		private void WriteAdditionalInfoHelper(ParameterCollection paramters)
		{
			_writer.Write((ushort)paramters.Count);
			for (int i = 0; i < paramters.Count; i++)
				paramters[i].Accept(_additionalDataWriter);
		}

		private void WriteAdditionalInfoHelper(GenericTypeParameterCollection genericParamters)
		{
			_writer.Write((ushort)genericParamters.Count);
			for (int i = 0; i < genericParamters.Count; i++)
				_writer.Write(this.GetTypeId(genericParamters[i]));
		}

		#endregion // WriteAdditionalInfo

		#region WriteTypeTable

		private void WriteTypeTable(AssemblyData[] assemblies)
		{
			_writer.Write((ushort)assemblies.Length);
			foreach (var assemblyData in assemblies)
				this.WriteTypeTableHelper(assemblyData);
		}

		private void WriteTypeTableHelper(AssemblyData assembly)
		{
			var types = assembly.GetTypeDatas();

			_writer.Write(assembly.FullName);
			_writer.Write(types.Count);
			for (int i = 0; i < types.Count; i++)
				this.WriteTypeTableHelper(types[i]);
		}

		private void WriteTypeTableHelper(TypeData typeBase)
		{
			var typeId = _nextTypeId++;
			_typeTable[typeBase] = typeId;

			var type = typeBase as TypeDefinitionData;
			var isTypeData = type != null;

			_writer.Write(typeId);
			_writer.Write(typeBase.Name);
			_writer.Write((byte)typeBase.Accessibility);
			_writer.Write((byte)typeBase.MemberFlags);
			_writer.Write((byte)typeBase.TypeKind);
			_writer.Write(isTypeData);

			if (isTypeData)
			{
				_writer.Write((byte)type.TypeDefinitionFlags);
				_writer.Write(type.FullName);
			}
			else
			{
				var genericTypeParameterData = (GenericTypeParameterData)typeBase;
				_writer.Write((int)genericTypeParameterData.GenericParameterAttributes);
				_writer.Write((ushort)genericTypeParameterData.GenericParameterPosition);
			}
		}

		#endregion // WriteTypeTable

		private class AdditionalDataWriter : MetadataItemVisitor
		{
			public BinaryItemSerializerV1 _owner;

			public AdditionalDataWriter(BinaryItemSerializerV1 owner)
			{
				_owner = owner;
			}

			public override void DefaultVisit(MetadataItemBase item)
			{
				Debug.Fail("Unhandled item:" + item.GetType().Name);
			}

			public override void VisitConstantData(ConstantData item)
			{
				this.WriteMemberHeader(item);
				_owner._writer.Write(_owner.GetTypeId(item.Type));
			}

			public override void VisitConstructorData(ConstructorData item)
			{
				this.WriteMemberHeader(item);
				_owner.WriteAdditionalInfoHelper(item.Parameters);
			}

			public override void VisitFieldData(FieldData item)
			{
				this.WriteMemberHeader(item);
				_owner._writer.Write(_owner.GetTypeId(item.Type));
				_owner._writer.Write(item.IsReadOnly);
			}

			public override void VisitEventData(EventData item)
			{
				this.WriteMemberHeader(item);
				_owner._writer.Write(_owner.GetTypeId(item.Type));
			}

			public override void VisitMethodData(MethodData item)
			{
				this.WriteMemberHeader(item);
				_owner._writer.Write(_owner.GetTypeId(item.Type));
				_owner._writer.Write(item.IsExtensionMethod);
				_owner.WriteAdditionalInfoHelper(item.GenericParameters);
				_owner.WriteAdditionalInfoHelper(item.Parameters);
			}

			public override void VisitIndexerData(IndexerData item)
			{
				this.WriteMemberHeader(item);
				_owner._writer.Write(_owner.GetTypeId(item.Type));
				_owner._writer.Write(((byte?)item.GetMethodAccessibility).GetValueOrDefault(0xFF));
				_owner._writer.Write(((byte?)item.SetMethodAccessibility).GetValueOrDefault(0xFF));
				_owner.WriteAdditionalInfoHelper(item.Parameters);
			}

			public override void VisitOperatorData(OperatorData item)
			{
				this.WriteMemberHeader(item);
				_owner._writer.Write(_owner.GetTypeId(item.Type));
				_owner.WriteAdditionalInfoHelper(item.Parameters);
			}

			public override void VisitParameterData(ParameterData item)
			{
				_owner._writer.Write(item.Name);
				_owner._writer.Write(_owner.GetTypeId(item.Type));
				_owner._writer.Write((byte)item.Modifer);
				_owner._writer.Write(item.IsParamsArray);
				_owner._writer.Write(item.IsOptional);
				if (item.IsOptional)
					this.WriteDefaultValue(item.DefaultValue);
			}

			public override void VisitPropertyData(PropertyData item)
			{
				this.WriteMemberHeader(item);
				_owner._writer.Write(_owner.GetTypeId(item.Type));
				_owner._writer.Write(((byte?)item.GetMethodAccessibility).GetValueOrDefault(0xFF));
				_owner._writer.Write(((byte?)item.SetMethodAccessibility).GetValueOrDefault(0xFF));		
			}

			public override void VisitTypeDefinitionData(TypeDefinitionData item)
			{
				_owner._writer.Write((ushort)item.MetadataItemKind);
				_owner._writer.Write(_owner.GetTypeId(item));
			}

			private void WriteMemberHeader(MemberDataBase item)
			{
				_owner._writer.Write((ushort)item.MetadataItemKind);
				_owner._writer.Write(item.Name);
				_owner._writer.Write((byte)item.Accessibility);
				_owner._writer.Write((byte)item.MemberFlags);
			}

			private void WriteDefaultValue(object value)
			{
				var hasNonNullValue = value != null;
				_owner._writer.Write(hasNonNullValue);

				if (hasNonNullValue)
				{
					_owner._writer.Write(value.GetType().FullName);

					if (value is bool)
						_owner._writer.Write((bool)value);
					else if (value is byte)
						_owner._writer.Write((byte)value);
					else if (value is char)
						_owner._writer.Write((char)value);
					else if (value is decimal)
						_owner._writer.Write((decimal)value);
					else if (value is double)
						_owner._writer.Write((double)value);
					else if (value is float)
						_owner._writer.Write((float)value);
					else if (value is int)
						_owner._writer.Write((int)value);
					else if (value is long)
						_owner._writer.Write((long)value);
					else if (value is sbyte)
						_owner._writer.Write((sbyte)value);
					else if (value is short)
						_owner._writer.Write((short)value);
					else if (value is string)
						_owner._writer.Write((string)value);
					else if (value is uint)
						_owner._writer.Write((uint)value);
					else if (value is ulong)
						_owner._writer.Write((ulong)value);
					else if (value is ushort)
						_owner._writer.Write((ushort)value);
				}
			}
		}
	}
}
