// Copyright 2017 Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;

namespace Google.Cloud.Tools.Analyzers
{
    internal static class SymbolExtensions
    {
        private static readonly HashSet<SpecialType> s_primitiveTypes = new HashSet<SpecialType> {
            SpecialType.System_Boolean,
            SpecialType.System_Char,
            SpecialType.System_SByte,
            SpecialType.System_Byte,
            SpecialType.System_Int16,
            SpecialType.System_UInt16,
            SpecialType.System_Int32,
            SpecialType.System_UInt32,
            SpecialType.System_Int64,
            SpecialType.System_UInt64,
            SpecialType.System_Single,
            SpecialType.System_Double
        };

        internal static ITypeSymbol GetVariableType(this ISymbol symbol)
        {
            switch (symbol)
            {
                case ILocalSymbol local: return local.Type;
                case IParameterSymbol parameter: return parameter.Type;
                case IFieldSymbol field: return field.Type;
                default: throw new ArgumentException("The specified symbol is not a variable.", nameof(symbol));
            }
        }

        internal static bool IsExternallyVisible(this ISymbol symbol)
        {
            switch (symbol.DeclaredAccessibility)
            {
                case Accessibility.Public:
                case Accessibility.Protected:
                case Accessibility.ProtectedOrInternal:
                    return symbol.ContainingType?.IsExternallyVisible() ?? true;
                default:
                    return false;
            }
        }

        internal static bool IsPrimitive(this ITypeSymbol type)
        {
            return s_primitiveTypes.Contains(type.SpecialType);
        }
    }
}
