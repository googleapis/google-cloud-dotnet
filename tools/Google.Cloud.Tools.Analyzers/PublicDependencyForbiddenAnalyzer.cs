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
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace Google.Cloud.Tools.Analyzers
{
    /// <summary>
    /// Warns about deriving from or exposing types from namespaces which are not to be exposed as dependencies.
    /// </summary>
    [DiagnosticAnalyzer(LanguageNames.CSharp)]
    public class PublicDependencyForbiddenAnalyzer : DiagnosticAnalyzer
    {
        private static readonly ImmutableArray<string> ForbiddenNamespacePrefixes = ImmutableArray.Create("Google.Apis.");

        public const string DiagnosticId = "GCP0003";
        private const string Category = "Usage";

        private static readonly LocalizableString Title = "Publicly dependency to forbidden namespace";
        private static readonly LocalizableString MessageFormat = "The type '{0}' directly or indirectly depends on the forbidden namespace '{1}'";
        private static readonly LocalizableString Description = "Dependencies on certain namespaces should not be exposed publicly.";
        private static DiagnosticDescriptor Rule =
            new DiagnosticDescriptor(DiagnosticId, Title, MessageFormat, Category, DiagnosticSeverity.Hidden, isEnabledByDefault: true, description: Description);

        public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics { get { return ImmutableArray.Create(Rule); } }

        public override void Initialize(AnalysisContext context)
        {
            context.EnableConcurrentExecution();
            context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.Analyze | GeneratedCodeAnalysisFlags.ReportDiagnostics);
            context.RegisterSymbolAction(AnalyzeEvent, SymbolKind.Event);
            context.RegisterSymbolAction(AnalyzeField, SymbolKind.Field);
            context.RegisterSymbolAction(AnalyzeMethod, SymbolKind.Method);
            context.RegisterSymbolAction(AnalyzeNamedType, SymbolKind.NamedType);
            context.RegisterSymbolAction(AnalyzeProperty, SymbolKind.Property);
        }

        private static void AnalyzeEvent(SymbolAnalysisContext context)
        {
            var eventSymbol = (IEventSymbol)context.Symbol;
            var declNode = context.Symbol.DeclaringSyntaxReferences[0].GetSyntax(context.CancellationToken);
            if (declNode.IsKind(SyntaxKind.EventDeclaration))
            {
                CheckType<EventDeclarationSyntax>(
                    context,
                    eventSymbol.Type,
                    eventNode => eventNode.Type.GetLocation());
            }
            else
            {
                CheckType<VariableDeclaratorSyntax>(
                    context,
                    eventSymbol.Type,
                    variableDeclaratorNode => (variableDeclaratorNode.Parent as VariableDeclarationSyntax)?.Type.GetLocation());
            }
        }

        private static void AnalyzeField(SymbolAnalysisContext context)
        {
            var fieldSymbol = (IFieldSymbol)context.Symbol;
            CheckType<VariableDeclaratorSyntax>(
                context,
                fieldSymbol.Type,
                variableDeclaratorNode => (variableDeclaratorNode.Parent as VariableDeclarationSyntax)?.Type.GetLocation());
        }

        private static void AnalyzeMethod(SymbolAnalysisContext context)
        {
            var methodKind = ((IMethodSymbol)context.Symbol).MethodKind;
            switch (methodKind)
            {
                case MethodKind.AnonymousFunction:
                case MethodKind.DelegateInvoke:
                case MethodKind.Destructor:
                case MethodKind.EventAdd:
                case MethodKind.EventRaise:
                case MethodKind.EventRemove:
                case MethodKind.ExplicitInterfaceImplementation:
                case MethodKind.PropertyGet:
                case MethodKind.PropertySet:
                case MethodKind.StaticConstructor:
                case MethodKind.LocalFunction:
                    return;
            }

            var methodSymbol = (IMethodSymbol)context.Symbol;
            if (methodKind != MethodKind.Constructor)
            {
                CheckType<MethodDeclarationSyntax>(
                    context,
                    methodSymbol.ReturnType,
                    methodNode => methodNode.ReturnType.GetLocation());
            }

            for (int i = 0; i < methodSymbol.Parameters.Length; ++i)
            {
                if (methodKind == MethodKind.Constructor)
                {
                    CheckType<ConstructorDeclarationSyntax>(
                       context,
                       methodSymbol.Parameters[i].Type,
                       constructorNode => constructorNode.ParameterList.Parameters[i].Type.GetLocation());
                }
                else
                {
                    CheckType<MethodDeclarationSyntax>(
                       context,
                       methodSymbol.Parameters[i].Type,
                       methodNode => methodNode.ParameterList.Parameters[i].Type.GetLocation());
                }
            }
        }

        private static void AnalyzeNamedType(SymbolAnalysisContext context)
        {
            var typeSymbol = (INamedTypeSymbol)context.Symbol;
            CheckType<TypeDeclarationSyntax>(
                context,
                typeSymbol,
                methodNode => methodNode.BaseList.GetLocation());
        }

        private static void AnalyzeProperty(SymbolAnalysisContext context)
        {
            var propertySymbol = (IPropertySymbol)context.Symbol;
            CheckType<PropertyDeclarationSyntax>(
                context,
                propertySymbol.Type,
                propertyNode => propertyNode.Type.GetLocation());

            for (int i = 0; i < propertySymbol.Parameters.Length; ++i)
            {
                CheckType<IndexerDeclarationSyntax>(
                    context,
                    propertySymbol.Parameters[i].Type,
                    propertyNode => propertyNode.ParameterList.Parameters[i].Type.GetLocation());
            }
        }

        private static void CheckType<T>(SymbolAnalysisContext context, ITypeSymbol type, Func<T, Location> getErrorLocation)
            where T : CSharpSyntaxNode
        {
            if (!context.Symbol.IsExternallyVisible())
            {
                return;
            }

            if (ForbiddenNamespacePrefixes.Any(context.Symbol.ContainingSymbol.ToDisplayString().StartsWith))
            {
                // If a symbol is actually defined in a forbidden namespace, don't add an error to it.
                return;
            }

#pragma warning disable RS1024 // We're providing an appropriate symbol equality comparer, so all comparisons should be fine.
            var checkedTypes = new Dictionary<ITypeSymbol, TypeCheckResult>(SymbolEqualityComparer.Default);
#pragma warning restore RS1024
            var result = CheckType(type, checkedTypes);
            if (!result.IsTypeForbidden)
            {
                return;
            }

            if (context.Symbol.DeclaringSyntaxReferences.IsEmpty)
            {
                return;
            }

            T declaringNode = (T)context.Symbol.DeclaringSyntaxReferences.FirstOrDefault().GetSyntax(context.CancellationToken);
            context.ReportDiagnostic(
                Diagnostic.Create(
                    Rule,
                    getErrorLocation(declaringNode),
                    type.ToDisplayString(),
                    result.ForbiddenNamespace));
        }

        private static TypeCheckResult CheckType(ITypeSymbol type, Dictionary<ITypeSymbol, TypeCheckResult> checkedTypes)
        {
            if (!checkedTypes.TryGetValue(type, out var result))
            {
                // Add a placeholder before we do anything else to prevent recursion issues.
                checkedTypes.Add(type, TypeCheckResult.Allowed);

                result = CheckTypeImpl(type);
                checkedTypes[type] = result;
            }
            return result;

            TypeCheckResult CheckTypeImpl(ITypeSymbol currentType)
            {
                if (currentType.TypeKind == TypeKind.Array)
                {
                    return CheckType(((IArrayTypeSymbol)currentType).ElementType, checkedTypes);
                }

                if (currentType is INamedTypeSymbol namedType)
                {
                    if (namedType.TypeKind == TypeKind.Delegate)
                    {
                        var delegateResult = CheckType(namedType.DelegateInvokeMethod.ReturnType, checkedTypes);
                        if (!delegateResult.IsTypeForbidden) {
                            delegateResult =
                                    namedType.DelegateInvokeMethod.Parameters.
                                        Select(p => CheckType(p.Type, checkedTypes)).
                                        FirstOrDefault(c => c.IsTypeForbidden);
                        }

                        if (delegateResult?.IsTypeForbidden == true)
                        {
                            return TypeCheckResult.Forbidden(delegateResult.ForbiddenNamespace);
                        }
                    }
                    else
                    {
                        if (ForbiddenNamespacePrefixes.Any(namedType.ContainingNamespace.ToDisplayString().StartsWith))
                        {
                            return TypeCheckResult.Forbidden(namedType.ContainingNamespace.ToDisplayString());
                        }

                        var dependentTypeResult =
                            namedType.BaseType == null ? null : CheckType(namedType.BaseType, checkedTypes);

                        if (dependentTypeResult?.IsTypeForbidden != true)
                        {
                            dependentTypeResult =
                                namedType.Interfaces.Select(i => CheckType(i, checkedTypes)).FirstOrDefault(c => c.IsTypeForbidden);
                        }

                        if (dependentTypeResult?.IsTypeForbidden != true)
                        {
                            dependentTypeResult =
                                namedType.TypeArguments.Select(p => CheckType(p, checkedTypes)).FirstOrDefault(c => c.IsTypeForbidden);
                        }

                        if (dependentTypeResult?.IsTypeForbidden == true)
                        {
                            return TypeCheckResult.Forbidden(dependentTypeResult.ForbiddenNamespace);
                        }
                    }
                }

                return TypeCheckResult.Allowed;
            }
        }

        private class TypeCheckResult
        {
            public static readonly TypeCheckResult Allowed = new TypeCheckResult();

            public static TypeCheckResult Forbidden(string forbiddenNamespace) =>
                new TypeCheckResult
                {
                    IsTypeForbidden = true,
                    ForbiddenNamespace = forbiddenNamespace
                };

            private TypeCheckResult() { }

            public bool IsTypeForbidden { get; private set; }
            public string ForbiddenNamespace { get; private set; }
        }
    }
}
