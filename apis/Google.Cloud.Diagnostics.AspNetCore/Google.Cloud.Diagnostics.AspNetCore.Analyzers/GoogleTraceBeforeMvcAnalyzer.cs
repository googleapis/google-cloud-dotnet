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

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;

namespace Google.Cloud.Diagnostics.AspNetCore.Analyzers
{
    // TODO: Support for VB as well?
    // TODO: Add a code fix provider?

    /// <summary>
    /// Analyzer which checks to make sure the earliest usage of the UseGoogleTrace extension method on
    /// an IApplicationBuilder symbol happens before the earliest usage any UseMvc... extension method
    /// on the same symbol. Chains of method calls all on an IApplicationBuilder are assumed to all be
    /// called on the same instance.
    /// </summary>
    [DiagnosticAnalyzer(LanguageNames.CSharp)]
    public class GoogleTraceBeforeMvcAnalyzer : DiagnosticAnalyzer
    {
        public const string RuleId = "GCP0005";

        private const string IApplicationBuilderFullName = "Microsoft.AspNetCore.Builder.IApplicationBuilder";
        private const string UseGoogleTrace = "UseGoogleTrace";
        private const string UseMvc = "UseMvc";

        private static readonly LocalizableString Title =
            "Add Google trace before MVC";
        private static readonly LocalizableString MessageFormat =
            $"{UseGoogleTrace} should be used before {{0}} so requests can be traced";
        private static readonly LocalizableString Description =
            "Google trace middleware should be added before MVC to the request pipeline.";

        private static DiagnosticDescriptor Rule =
            new DiagnosticDescriptor(
                RuleId,
                Title,
                MessageFormat,
                category: "Usage",
                defaultSeverity: DiagnosticSeverity.Warning,
                isEnabledByDefault: true,
                description: Description,
                helpLinkUri: "http://googlecloudplatform.github.io/google-cloud-dotnet/docs/Google.Cloud.Diagnostics.AspNetCore/#initializing-tracing");

        public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics => ImmutableArray.Create(Rule);

        public override void Initialize(AnalysisContext context)
        {
            context.EnableConcurrentExecution();
            context.ConfigureGeneratedCodeAnalysis(
                GeneratedCodeAnalysisFlags.Analyze | GeneratedCodeAnalysisFlags.ReportDiagnostics);
            context.RegisterSyntaxNodeAction(AnalyzeSyntaxNode, SyntaxKind.InvocationExpression);
        }

        // Visible for testing
        internal static readonly ConditionalWeakTable<ISymbol, ApplicationBuilderSymbolInfo> _applicationBuilderSymbolInfos =
            new ConditionalWeakTable<ISymbol, ApplicationBuilderSymbolInfo>();

        private static void AnalyzeSyntaxNode(SyntaxNodeAnalysisContext context)
        {
            // Skip invocations that aren't made on member access expressions.
            // We want something like app.Xyz()
            var invocationNode = (InvocationExpressionSyntax)context.Node;
            if (!(invocationNode.Expression is MemberAccessExpressionSyntax memberAccess))
            {
                return;
            }
            
            var name = memberAccess.Name.ToString();
            GetAccessInfoDelegate getAccessInfo =
                name == UseGoogleTrace ? scopeInfo => ref scopeInfo.UseGoogleTraceAccessInfo :
                name.StartsWith(UseMvc) ? scopeInfo => ref scopeInfo.UseMvcAccessInfo :
                default(GetAccessInfoDelegate);
            if (getAccessInfo == null)
            {
                return;
            }

            // Walk up a chain of method calls on IApplicationBuilder (if there is one), and see if
            // there is a local/parameter/field/property symbol at the end of the chain. If so, record
            // the name access for that symbol.
            var nameAccessNode = memberAccess.Name;
            var semanticModel = context.SemanticModel;
            do
            {
                var symbol = semanticModel.GetSymbolInfo(memberAccess.Expression).Symbol;

                // TODO: Do we want to support things that are reference convertible to IApplicationBuilder as well?
                // All receivers of the method invocations must be of type IApplicationBuilder.
                if (symbol?.Type()?.ToDisplayString() != IApplicationBuilderFullName)
                {
                    break;
                }

                switch (symbol?.Kind)
                {
                    case SymbolKind.Local:
                    case SymbolKind.Field:
                    case SymbolKind.Parameter:
                    case SymbolKind.Property:
                        UpdateInvocationLocation(context, symbol, nameAccessNode, getAccessInfo);
                        return;
                    case SymbolKind.Method:
                        // Walk up the chain...
                        memberAccess =
                            (memberAccess.Expression as InvocationExpressionSyntax)?.Expression as MemberAccessExpressionSyntax;
                        break;
                }
            }
            while (memberAccess != null);
        }

        private static void UpdateInvocationLocation(
            SyntaxNodeAnalysisContext context,
            ISymbol symbol,
            SimpleNameSyntax currentAccessNode,
            GetAccessInfoDelegate getAccessInfo)
        {
            var symbolInfo = _applicationBuilderSymbolInfos.GetOrCreateValue(symbol);

            lock (symbolInfo)
            {
                var scopeEnclosingNode =
                    currentAccessNode.FirstAncestorOrSelf<CSharpSyntaxNode>(IsScopeEnclosingNode);
                if (!symbolInfo.Scopes.TryGetValue(scopeEnclosingNode, out var scopeInfo))
                {
                    symbolInfo.Scopes[scopeEnclosingNode] = scopeInfo = new ScopeInfo();
                }

                if (scopeInfo.DiagnosticReported)
                {
                    return;
                }

                ref var existingAccessInfo = ref getAccessInfo(scopeInfo);

                if (existingAccessInfo.location == null ||
                    currentAccessNode.GetLocation().SourceSpan.Start < existingAccessInfo.location.SourceSpan.Start)
                {
                    existingAccessInfo = (currentAccessNode.GetLocation(), currentAccessNode.ToString());
                    VerifyInvocationOrder(context, scopeInfo);
                }
            }
        }

        private static void VerifyInvocationOrder(
            SyntaxNodeAnalysisContext context, ScopeInfo scopeInfo)
        {
            if (scopeInfo.UseMvcAccessInfo.location == null ||
                scopeInfo.UseGoogleTraceAccessInfo.location == null)
            {
                return;
            }

            if (scopeInfo.UseMvcAccessInfo.location.SourceTree !=
                scopeInfo.UseGoogleTraceAccessInfo.location.SourceTree)
            {
                throw new InvalidOperationException("Unexpected: the same scope spanned two different files");
            }

            if (scopeInfo.UseMvcAccessInfo.location.SourceSpan.Start <
                scopeInfo.UseGoogleTraceAccessInfo.location.SourceSpan.Start)
            {
                context.ReportDiagnostic(
                    Diagnostic.Create(
                        Rule,
                        scopeInfo.UseGoogleTraceAccessInfo.location,
                        scopeInfo.UseMvcAccessInfo.name));
                scopeInfo.DiagnosticReported = true;
            }
        }

        private static bool IsScopeEnclosingNode(CSharpSyntaxNode node)
        {
            switch (node.Kind())
            {
                case SyntaxKind.MethodDeclaration:
                case SyntaxKind.AnonymousMethodExpression:
                case SyntaxKind.ParenthesizedLambdaExpression:
                case SyntaxKind.SimpleLambdaExpression:
                case SyntaxKind.LocalFunctionStatement:
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Information regarding a single IApplicationBuilder symbol's accesses across various scopes.
        /// </summary>
        public class ApplicationBuilderSymbolInfo
        {
            // TODO: Assignments to a symbol should split a scope area into two, but I don't
            //       know if that will be possible given how the analyzer is invoked.

            // A collection of scopes keyed by the immediate enclosing node of that scope.
            public readonly Dictionary<CSharpSyntaxNode, ScopeInfo> Scopes =
                new Dictionary<CSharpSyntaxNode, ScopeInfo>();
        }

        /// <summary>
        /// Information about a single IApplicationBuilder symbol's accesses within in single scope.
        /// </summary>
        public class ScopeInfo
        {
            public bool DiagnosticReported;
            public (Location location, string name) UseGoogleTraceAccessInfo;
            public (Location location, string name) UseMvcAccessInfo;
        }

        /// <summary>
        /// Delegate to gets a reference to the information for a single access of either UseMvc... or UseGoogleTrace.
        /// </summary>
        private delegate ref (Location location, string name) GetAccessInfoDelegate(ScopeInfo scopeInfo);
    }
}
