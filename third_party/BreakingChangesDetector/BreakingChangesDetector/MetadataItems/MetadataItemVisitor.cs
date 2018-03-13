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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingChangesDetector.MetadataItems
{
	/// <summary>
	/// Abstract base class for a visitor of <see cref="MetadataItemBase"/> instances.
	/// </summary>
	public abstract class MetadataItemVisitor
	{
		/// <summary>
		/// The default visit implementation for all items.
		/// </summary>
		public virtual void DefaultVisit(MetadataItemBase item) { }

		/// <summary>
		/// The visit implementation for <see cref="AssemblyData"/> instances.
		/// </summary>
		public virtual void VisitAssemblyData(AssemblyData item) { this.DefaultVisit(item); }

		/// <summary>
		/// The visit implementation for <see cref="ConstantData"/> instances.
		/// </summary>
		public virtual void VisitConstantData(ConstantData item) { this.DefaultVisit(item); }

		/// <summary>
		/// The visit implementation for <see cref="ConstructedGenericTypeData"/> instances.
		/// </summary>
		public virtual void VisitConstructedGenericTypeData(ConstructedGenericTypeData item) { this.DefaultVisit(item); }

		/// <summary>
		/// The visit implementation for <see cref="EventData"/> instances.
		/// </summary>
		public virtual void VisitEventData(EventData item) { this.DefaultVisit(item); }

		/// <summary>
		/// The visit implementation for <see cref="ConstructorData"/> instances.
		/// </summary>
		public virtual void VisitConstructorData(ConstructorData item) { this.DefaultVisit(item); }

		/// <summary>
		/// The visit implementation for <see cref="FieldData"/> instances.
		/// </summary>
		public virtual void VisitFieldData(FieldData item) { this.DefaultVisit(item); }

		/// <summary>
		/// The visit implementation for <see cref="MethodData"/> instances.
		/// </summary>
		public virtual void VisitMethodData(MethodData item) { this.DefaultVisit(item); }

		/// <summary>
		/// The visit implementation for <see cref="OperatorData"/> instances.
		/// </summary>
		public virtual void VisitOperatorData(OperatorData item) { this.DefaultVisit(item); }

		/// <summary>
		/// The visit implementation for <see cref="ParameterData"/> instances.
		/// </summary>
		public virtual void VisitParameterData(ParameterData item) { this.DefaultVisit(item); }

		/// <summary>
		/// The visit implementation for <see cref="IndexerData"/> instances.
		/// </summary>
		public virtual void VisitIndexerData(IndexerData item) { this.DefaultVisit(item); }

		/// <summary>
		/// The visit implementation for <see cref="PropertyData"/> instances.
		/// </summary>
		public virtual void VisitPropertyData(PropertyData item) { this.DefaultVisit(item); }

		/// <summary>
		/// The visit implementation for <see cref="GenericTypeParameterData"/> instances.
		/// </summary>
		public virtual void VisitGenericTypeParameterData(GenericTypeParameterData item) { this.DefaultVisit(item); }

		/// <summary>
		/// The visit implementation for <see cref="TypeDefinitionData"/> instances.
		/// </summary>
		public virtual void VisitTypeDefinitionData(TypeDefinitionData item) { this.DefaultVisit(item); }

		/// <summary>
		/// The visit implementation for <see cref="TypeWithElementData"/> instances.
		/// </summary>
		public virtual void VisitTypeWithElementData(TypeWithElementData item) { this.DefaultVisit(item); }
	}
}
