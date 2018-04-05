// Copyright 2018 Google LLC
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

using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Text;

namespace Google.Cloud.Diagnostics.AspNetCore.Analyzers
{
    internal static class RoslynHelpers
    {
        internal static ITypeSymbol Type(this ISymbol symbol)
        {
            switch (symbol.Kind)
            {
                case SymbolKind.Event: return ((IEventSymbol)symbol).Type;
                case SymbolKind.Field: return ((IFieldSymbol)symbol).Type;
                case SymbolKind.Local: return ((ILocalSymbol)symbol).Type;
                case SymbolKind.Method: return ((IMethodSymbol)symbol).ReturnType;
                case SymbolKind.Parameter: return ((IParameterSymbol)symbol).Type;
                case SymbolKind.Property: return ((IPropertySymbol)symbol).Type;
            }
            return null;
        }
    }
}
