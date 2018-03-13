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
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BreakingChangesDetector.MetadataItems
{
	/// <summary>
	/// A collection of <see cref="ParameterData"/> instances representing method or indexer parameters
	/// </summary>
	public sealed class ParameterCollection : IEnumerable<ParameterData>
	{
		private readonly List<ParameterData> _parameters;
		private int _requiredArgumentCount;

		internal ParameterCollection()
		{
			_parameters = new List<ParameterData>();
		}

		internal ParameterCollection(IEnumerable<ParameterDefinition> underlyingParameters, MemberDataBase declaringMember)
		{
			_parameters = new List<ParameterData>();
			foreach (var parameter in underlyingParameters)
				this.Add(new ParameterData(parameter, declaringMember));
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return _parameters.GetEnumerator();
		}

		internal void Add(ParameterData parameterData)
		{
			if (parameterData.IsOptional == false && parameterData.IsParamsArray == false)
				_requiredArgumentCount++;

			_parameters.Add(parameterData);
		}

		internal bool DoesMatch(ParameterCollection other)
		{
			if (_requiredArgumentCount != other._requiredArgumentCount)
				return false;

			if (this.Count != other.Count)
				return false;

			for (int i = 0; i < this.Count; i++)
			{
				if (this[i].DoesMatch(other[i]) == false)
					return false;
			}

			return true;
		}

		/// <summary>
		/// Gets an enumerator capable of iterating the parameters.
		/// </summary>
		public IEnumerator<ParameterData> GetEnumerator()
		{
			return _parameters.GetEnumerator();
		}

#if DEBUG
		/// <summary>
		/// Indicates whether the specified collection has the same parameter types and modifiers in the same order as the current collection.
		/// </summary> 
#endif
		internal bool IsEquivalentTo(ParameterCollection other)
		{
			if (this.Count != other.Count)
				return false;

			for (int i = 0; i < this.Count; i++)
			{
				if (this[i].IsEquivalentTo(other[i]) == false)
					return false;
			}

			return true;
		}

#if DEBUG
		/// <summary>
		/// Indicates whether a new parameter collection is logically the same as the current parameter collection, just from a newer build.
		/// </summary>
		/// <param name="newParameters">The collection of newer parameters.</param>
		/// <param name="newAssemblyFamily">The assembly family in which new assemblies reside.</param>
		/// <param name="ignoreNewOptionalParameters">
		/// Indicates whether to ignore any new parameters at the end of the collection which are optional when comparing.
		/// </param>
#endif
		internal bool IsEquivalentToNewParameters(ParameterCollection newParameters, AssemblyFamily newAssemblyFamily, bool ignoreNewOptionalParameters)
		{
			if (ignoreNewOptionalParameters)
			{
				if (this.Count < newParameters.RequiredArgumentCount || newParameters.Count < this.Count)
					return false;
			}
			else
			{
				if (this.Count != newParameters.Count)
					return false;
			}

			for (int i = 0; i < this.Count; i++)
			{
				if (this[i].IsEquivalentToNewParameter(newParameters[i], newAssemblyFamily) == false)
					return false;
			}

			return true;
		}

		/// <summary>
		/// Gets the number of parameters in the collection.
		/// </summary>
		public int Count
		{
			get { return _parameters.Count; }
		}

		/// <summary>
		/// Gets the number of arguments required by callers to the entity owning the parameters.
		/// </summary>
		public int RequiredArgumentCount
		{
			get { return _requiredArgumentCount; }
		}

		/// <summary>
		/// Gets the parameter at the specified index in the collection.
		/// </summary>
		public ParameterData this[int index]
		{
			get { return _parameters[index]; }
		}

		/// <summary>
		/// Gets the display text of the parameter list, which is the C# code that represents it.
		/// </summary>
		/// <param name="isExtensionMethod">Indicates whether the entity owning the parameters collection is an extension method.</param>
		/// <param name="open">The character to use to open the parameter list.</param>
		/// <param name="close">The character to use to close the parameter list.</param>
		public string GetParameterListDisplayText(bool isExtensionMethod = false, char open = '(', char close = ')')
		{
			if (this.Count == 0)
				return open.ToString() + close;

			var sb = new StringBuilder();

			sb.Append(open);
			if (isExtensionMethod)
				sb.Append("this ");

			sb.Append(this[0].GetParameterListDisplayText());
			for (int i = 1; i < this.Count; i++)
			{
				sb.Append(", ");
				sb.Append(this[i].GetParameterListDisplayText());
			}

			sb.Append(close);
			return sb.ToString();
		}

#if DEBUG
		/// <summary>
		/// Replaces all type parameters used by the member with their associated generic arguments specified in a constructed generic type.
		/// </summary>
		/// <param name="declaringMemberKind">The type of member owning the parameter collection.</param>
		/// <param name="genericParameters">The generic parameters being replaced.</param>
		/// <param name="genericArguments">The generic arguments replacing the parameters.</param>
		/// <returns>A new member with the replaced type parameters or the current instance if the member does not use any of the generic parameters.</returns> 
#endif
		internal ParameterCollection ReplaceGenericTypeParameters(MetadataItemKinds declaringMemberKind, GenericTypeParameterCollection genericParameters, GenericTypeArgumentCollection genericArguments)
		{
			ParameterCollection replacedParameters = null;

			for (int i = 0; i < this.Count; i++)
			{
				var currentParameter = this[i];
				var replacedParameter = currentParameter.ReplaceGenericTypeParameters(declaringMemberKind, genericParameters, genericArguments);
				if (replacedParameter == currentParameter)
					continue;

				if (replacedParameters == null)
				{
					replacedParameters = new ParameterCollection();
					replacedParameters._parameters.AddRange(_parameters);
				}

				replacedParameters._parameters[i] = replacedParameter;
			}

			return replacedParameters ?? this;
		}
	}
}
