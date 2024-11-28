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

using Google.Api.Gax.Grpc;
using Microsoft.Build.Locator;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Editing;
using Microsoft.CodeAnalysis.Formatting;
using Microsoft.CodeAnalysis.MSBuild;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using static Google.Cloud.Bigtable.V2.GenerateClient.RoslynHelpers;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;
using gax = Google.Api.Gax;

namespace Google.Cloud.Bigtable.V2.GenerateClient
{
    internal class Program
    {
        private const string AppProfileIdPropertyName = "AppProfileId";
        private const string CancellationTokenParameterName = "cancellationToken";
        private const string ClientFieldName = "_client";

        /// <summary>
        /// Information about how to modify stream methods from the underlying client when customizing them.
        /// </summary>
        private class CustomStreamMethodInfo
        {
            /// <summary>
            /// A collection of custom triple-slash docs to replace on the original stream method, keyed by the XML tag name.
            /// </summary>
            public readonly Dictionary<string, string> CustomDocs = new Dictionary<string, string>();

            /// <summary>
            /// Value indicating whether to split the synchronous stream method into synchronous and asynchronous methods.
            /// </summary>
            public bool SplitSyncAndAsync { get; set; }

            /// <summary>
            /// The name of the return type to replace in the stream method, or null to leave the return type unmodified.
            /// </summary>
            public string TypeName { get; set; }
        }

        /// <summary>
        /// Collection of stream methods from the underlying client that should be customized, keyed by the method name.
        /// </summary>
        private static readonly Dictionary<string, CustomStreamMethodInfo> s_customStreamMethods =
            new Dictionary<string, CustomStreamMethodInfo>
            {
                {
                    "ReadRows",
                    new CustomStreamMethodInfo
                    {
                        CustomDocs =
                        {
                            {
                                "summary",
                                "Streams back the contents of all requested rows in key order, optionally applying the same Reader filter to each."
                            }
                        },
                        TypeName = "ReadRowsStream"
                    }
                },
                {
                    "MutateRows",
                    new CustomStreamMethodInfo
                    {
                        CustomDocs =
                        {
                            {
                                "returns",
                                "The RPC response."
                            }
                        },
                        SplitSyncAndAsync = true,
                        TypeName = "MutateRowsResponse"
                    }
                }
            };

        private static async Task<int> Main(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine("Arguments: <project file> <api client name> <user client name>");
                return 1;
            }

            var projectFile = args[0];
            var apiClientName = args[1];
            var userClientName = args[2];

            MSBuildLocator.RegisterDefaults();
            var workspace = MSBuildWorkspace.Create(new Dictionary<string, string> { ["TargetFramework"] = "net45" });

            Project project;
            try
            {
                project = await workspace.OpenProjectAsync(projectFile);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"Could not find project file {projectFile}");
                return 2;
            }

            var compilation = await project.GetCompilationAsync();
            var symbols = compilation.GetSymbolsWithName(name => name == apiClientName, SymbolFilter.Type).ToList();
            if (symbols.Count != 1)
            {
                Console.WriteLine($"Could not find type {apiClientName}");

                var errors = compilation.GetDiagnostics().Where(d => d.Severity == DiagnosticSeverity.Error).ToList();
                if (errors.Count != 0)
                {
                    Console.WriteLine($"Errors: {errors.Count}, first error: {errors[0]}");
                }
                return 2;
            }

            var apiClientSymbol = (INamedTypeSymbol)symbols[0];

            // Find the API client from a generated file (there should be only one).
            var generatedApiClientSyntax = apiClientSymbol.DeclaringSyntaxReferences
                .Select(syntaxReference => syntaxReference.GetSyntax())
                .Cast<ClassDeclarationSyntax>()
                .SingleOrDefault(
                    syntax => syntax.SyntaxTree.GetRoot().GetLeadingTrivia().ToFullString().Contains("// Generated code. DO NOT EDIT!"));

            if (generatedApiClientSyntax == null)
            {
                Console.WriteLine($"Could not find an auto-generated file containing the {apiClientName} definition");
                return 3;
            }

            var syntaxTree = generatedApiClientSyntax.SyntaxTree;
            var semanticModel = compilation.GetSemanticModel(syntaxTree);
            var generator = SyntaxGenerator.GetGenerator(project.GetDocument(syntaxTree));
            var requestMethodRewriter = new RequestMethodRewriter(semanticModel);
            var nonRequestMethodRewriter = new ClientMethodRewriter(semanticModel);
            var requestMethodToImplRewriter = new RequestMethodToImplRewriter();
            var convertToAsyncCancellationTokenOverload = new ConvertToAsyncCancellationTokenOverloadRewriter();

            var userClientSyntax =
                (ClassDeclarationSyntax)generator.ClassDeclaration(
                    userClientName,
                    accessibility: Accessibility.Public,
                    modifiers: DeclarationModifiers.Partial)
                    .WithLeadingTrivia(generatedApiClientSyntax.GetLeadingTrivia());
            var userClientImplSyntax =
                (ClassDeclarationSyntax)generator.ClassDeclaration(
                    userClientName + "Impl",
                    accessibility: Accessibility.Public,
                    modifiers: DeclarationModifiers.Sealed | DeclarationModifiers.Partial,
                    baseType: ParseTypeName(userClientName))
                    .WithLeadingTrivia(generatedApiClientSyntax.GetLeadingTrivia());

            // Copy the request methods from the API client with the user client. We only require these to be copied since
            // we already have handwritten flattening overloads to change ByteString to BigtableByteString.
            foreach (var methodSyntax in generatedApiClientSyntax.Members.OfType<MethodDeclarationSyntax>())
            {
                var method = semanticModel.GetDeclaredSymbol(methodSyntax);
                if (method.DeclaredAccessibility != Accessibility.Public ||
                    method.Parameters.IsEmpty)
                {
                    continue;
                }

                if (method.Parameters.Length == 2 &&
                    method.Parameters[0].Type.Name.EndsWith("Request"))
                {
                    var clientMethod = (MethodDeclarationSyntax)requestMethodRewriter.Visit(methodSyntax);
                    userClientSyntax = userClientSyntax.AddMembers(clientMethod);

                    if (method.Parameters[1].Type.Name.EndsWith(nameof(CallSettings)))
                    {
                        var clientImplMethod = (MethodDeclarationSyntax)requestMethodToImplRewriter.Visit(clientMethod);

                        if (s_customStreamMethods.TryGetValue(method.Name, out var customStreamMethodInfo) &&
                            customStreamMethodInfo.SplitSyncAndAsync)
                        {
                            var asyncMethod = clientMethod.ToAsync();
                            userClientSyntax = userClientSyntax.AddMembers(asyncMethod);

                            var asyncMethodWithCancellationToken = (MethodDeclarationSyntax)convertToAsyncCancellationTokenOverload.Visit(asyncMethod);
                            userClientSyntax = userClientSyntax.AddMembers(asyncMethodWithCancellationToken);

                            var clientImplSyncMethod = clientImplMethod.WithBodySafe(
                                Task().Member(nameof(System.Threading.Tasks.Task.Run))
                                    .Invoke(Lambda(asyncMethod.Invoke(clientImplMethod.ParameterList.AsArguments())))
                                    .Member(nameof(gax::TaskExtensions.ResultWithUnwrappedExceptions)).Invoke());
                            userClientImplSyntax = userClientImplSyntax.AddMembers(clientImplSyncMethod);

                            var clientImplAsyncMethod = clientImplMethod.ToAsync();
                            userClientImplSyntax = userClientImplSyntax.AddMembers(clientImplAsyncMethod);
                        }
                        else
                        {
                            userClientImplSyntax = userClientImplSyntax.AddMembers(clientImplMethod);
                        }
                    }
                }
                else if (
                    method.Name != "Create" &&
                    method.Name != "CreateAsync" &&
                    !s_customStreamMethods.ContainsKey(method.Name) &&
                    !method.Parameters.Any(p => p.Type.Name == "ByteString"))
                {
                    // TODO: We could also have this remap to BigtableByteString automatically, but we currently
                    //       have some validations for most methods with ByteStrings which I think we's lose by
                    //       autogenerating at the moment.
                    // For any other methods which aren't custom streaming methods and which don't use ByteString,
                    // which we remap to BigtableByteString, copy them (with some small fix ups) into the generated
                    // client.
                    userClientSyntax = userClientSyntax.AddMembers(
                        (MethodDeclarationSyntax)nonRequestMethodRewriter.Visit(methodSyntax));
                }
            }

            // Create a CompilationUnitSyntax from the Usings node of the original file, which will also contain the
            // copyright notice and generated code warnings in its leading trivia.
            // We also need a using directive for GAX, so that we can use ResultWithUnwrappedExceptions.
            var usings = syntaxTree.GetCompilationUnitRoot().Usings
                .Add(UsingDirective(ParseName(typeof(gax::TaskExtensions).Namespace)));
            var compilationUnit = CompilationUnit().WithUsings(usings);

            // Add in the namespace with the ...Client and ...ClientImpl classes.
            compilationUnit = compilationUnit.AddMembers(
                (NamespaceDeclarationSyntax)generator.NamespaceDeclaration(
                    apiClientSymbol.ContainingNamespace.ToDisplayString(),
                    userClientSyntax,
                    userClientImplSyntax));

            // Use idiomatic formatting for the project.
            compilationUnit =
                (CompilationUnitSyntax)Formatter.Format(
                    compilationUnit,
                    workspace,
                    workspace.Options.WithChangedOption(FormattingOptions.NewLine, LanguageNames.CSharp, "\n"));

            var resultText = compilationUnit.ToFullString();

            try
            {
                var resultPath = Path.Combine(Path.GetDirectoryName(projectFile), $"{userClientName}.g.cs");
                File.WriteAllText(resultPath, resultText);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Could not write the auto-generated {userClientName}:\n{e}");
                return 4;
            }
            return 0;
        }

        /// <summary>
        /// Rewriter which takes a second pass at a split async method (<see cref="CustomStreamMethodInfo.SplitSyncAndAsync"/>)
        /// to convert the (request, callSettings) overload into a (request, cancellationToken) overload which delegates to the
        /// original.
        /// </summary>
        private class ConvertToAsyncCancellationTokenOverloadRewriter : CSharpSyntaxRewriter
        {
            private ParameterSyntax _callSettingsParameterSyntax;

            public ConvertToAsyncCancellationTokenOverloadRewriter() : base(visitIntoStructuredTrivia: true) { }

            public override SyntaxNode VisitMethodDeclaration(MethodDeclarationSyntax node)
            {
                var requestParameterSyntax = node.ParameterList.Parameters[0];
                _callSettingsParameterSyntax = node.ParameterList.Parameters[1];

                node = (MethodDeclarationSyntax)base.VisitMethodDeclaration(node);

                // Replace the body with an expression that delegated to the original method with a CallSettings created from cancellation token.
                node = node.WithBodySafe(
                    node.Invoke(
                        IdentifierName(requestParameterSyntax.Identifier),
                        ParseName($"gaxgrpc::{nameof(CallSettings)}").Member(Identifier(nameof(CallSettings.FromCancellationToken))).Invoke(IdentifierName(CancellationTokenParameterName))));

                return node;
            }

            public override SyntaxNode VisitParameter(ParameterSyntax node)
            {
                node = (ParameterSyntax)base.VisitParameter(node);

                if (node == _callSettingsParameterSyntax)
                {
                    // Replace the CallSettings parameter with a CancellationToken parameter which doesn't have a default value.
                    node = node
                        .WithType(ParseTypeName($"st::{nameof(CancellationToken)}")).WithLeadingTrivia(node.Type.GetLeadingTrivia())
                        .WithIdentifier(Identifier(CancellationTokenParameterName))
                        .WithDefault(null);
                }
                return node;
            }

            public override SyntaxNode VisitXmlElement(XmlElementSyntax node)
            {
                var originalNode = node;
                node = (XmlElementSyntax)base.VisitXmlElement(node);

                if (originalNode.StartTag.Name.LocalName.ToString() == "param" &&
                    originalNode.StartTag.Attributes.FirstOrDefault() is XmlNameAttributeSyntax paramNameSyntax &&
                    paramNameSyntax.Identifier.ToString() == _callSettingsParameterSyntax.Identifier.ToString())
                {
                    // Replace the parameter doc comments for the cancellation token.
                    node = node.WithContent(List(new XmlNodeSyntax[] {
                        XmlText("A "),
                        SeeTag(TypeCref(ParseTypeName($"st::{nameof(CancellationToken)}"))),
                        XmlText(XmlTextLiteral(" to use for this RPC.")) }));
                }

                return node;
            }

            public override SyntaxNode VisitXmlNameAttribute(XmlNameAttributeSyntax node)
            {
                node = (XmlNameAttributeSyntax)base.VisitXmlNameAttribute(node);

                if (((XmlElementStartTagSyntax)node.Parent).Name.LocalName.ToString() == "param" &&
                    node.Identifier.ToString() == _callSettingsParameterSyntax.Identifier.ToString())
                {
                    // Replace the parameter doc comment name attribute with the name of the new parameter.
                    node = node.WithIdentifier(IdentifierName(CancellationTokenParameterName));
                }

                return node;
            }
        }

        /// <summary>
        /// Rewriter which takes a first pass at the API client's methods to clean them up
        /// to be added to the user client.
        /// </summary>
        private class ClientMethodRewriter : CSharpSyntaxRewriter
        {
            private readonly SemanticModel _semanticModel;

            protected IMethodSymbol Method { get; private set; }

            public ClientMethodRewriter(SemanticModel semanticModel) :
                base(visitIntoStructuredTrivia: true)
            {
                _semanticModel = semanticModel;
            }

            public override SyntaxNode VisitMethodDeclaration(MethodDeclarationSyntax node)
            {
                try
                {
                    Method = _semanticModel.GetDeclaredSymbol(node);
                    node = (MethodDeclarationSyntax)base.VisitMethodDeclaration(node);

                    if (s_customStreamMethods.TryGetValue(Method.Name, out var customStreamMethodInfo) &&
                        customStreamMethodInfo.TypeName != null)
                    {
                        node = node.WithReturnType(ParseTypeName(customStreamMethodInfo.TypeName));
                    }
                    else if (SymbolEqualityComparer.Default.Equals(Method.ReturnType.ContainingType, Method.ContainingType))
                    {
                        // If the method's return type is defined in the underlying client's class, qualify the return type.
                        node = node.WithReturnType(
                            QualifiedName(
                                IdentifierName(Method.ContainingType.Name),
                                IdentifierName(Method.ReturnType.Name)));
                    }

                    return node;
                }
                finally
                {
                    Method = null;
                }
            }
        }

        /// <summary>
        /// Rewriter which takes a first pass at the API client's request methods to clean them up
        /// to be added to the user client.
        /// </summary>
        private class RequestMethodRewriter : ClientMethodRewriter
        {
            private ParameterSyntax _requestParameterSyntax;

            public RequestMethodRewriter(SemanticModel semanticModel) :
                base(semanticModel)
            {
            }

            public override SyntaxNode VisitMethodDeclaration(MethodDeclarationSyntax node)
            {
                try
                {
                    _requestParameterSyntax = node.ParameterList.Parameters[0];
                    return (MethodDeclarationSyntax)base.VisitMethodDeclaration(node);
                }
                finally
                {
                    _requestParameterSyntax = null;
                }
            }

            public override SyntaxNode VisitXmlElement(XmlElementSyntax node)
            {
                node = (XmlElementSyntax)base.VisitXmlElement(node);

                var content = node.Content;

                if (s_customStreamMethods.TryGetValue(Method.Name, out var customStreamMethodInfo) &&
                    customStreamMethodInfo.CustomDocs.TryGetValue(node.StartTag.Name.ToString(), out var comment))
                {
                    content = SingletonList((XmlNodeSyntax)XmlText(XmlTextLiteral(comment)));
                }
                else if (
                    node.StartTag.Name.LocalName.ToString() == "param" &&
                    node.StartTag.Attributes.FirstOrDefault() is XmlNameAttributeSyntax paramNameSyntax &&
                    paramNameSyntax.Identifier.ToString() == _requestParameterSyntax.Identifier.ToString())
                {
                    // Append request param tags with a note about how the AppProfileId will be added to the request object
                    // if unspecified.
                    var endingText = (XmlTextSyntax)content.Last();
                    content = content
                        .Replace(
                            endingText,
                            endingText.AddTextTokens(XmlTextLiteral(" If the ")))
                        .Add(
                            SeeTag(_requestParameterSyntax.Type.CrefMember(AppProfileIdPropertyName)))
                        .Add(XmlText(XmlTextLiteral(" has not been specified, it will be initialized from the value stored in the client.")));
                }

                return node.WithContent(content);
            }
        }

        /// <summary>
        /// Rewriter which takes a second pass at the cleaned up, user client method, to modify it
        /// slightly for the user ...ClientImpl class.
        /// </summary>
        private class RequestMethodToImplRewriter : CSharpSyntaxRewriter
        {
            public RequestMethodToImplRewriter() : base(visitIntoStructuredTrivia: true) { }

            public override SyntaxNode VisitMethodDeclaration(MethodDeclarationSyntax node)
            {
                node = (MethodDeclarationSyntax)base.VisitMethodDeclaration(node);

                // Replace the doc comments with <inheritdoc/>
                node = node.WithLeadingTrivia(ParseLeadingTrivia("/// <inheritdoc/>\n        "));

                // Replace the body with something like this:
                //------------------------------------------------------------------------
                //  => _client.MethodName(request, callSettings);
                //------------------------------------------------------------------------
                var appProfileIdProperty = node.ParameterList.Parameters[0].Identifier.Member(AppProfileIdPropertyName);
                ExpressionSyntax resultExpression;
                if (s_customStreamMethods.TryGetValue(node.Identifier.ToString(), out var customStreamMethodInfo))
                {
                    // If we have a custom implementation, pass all parameters to a method named "<method-name>Impl", which should be
                    // implemented manually.
                    resultExpression = IdentifierName(node.Identifier + "Impl").Invoke(node.ParameterList.AsArguments());
                }
                else
                {
                    var underlyingMethod = IdentifierName(ClientFieldName).Member(node.Identifier);
                    resultExpression = underlyingMethod.Invoke(node.ParameterList.AsArguments());
                }

                node = node.WithBodySafe(resultExpression);

                return node;
            }

            public override SyntaxToken VisitToken(SyntaxToken token)
            {
                // Change the 'virtual' modifier to 'override'.
                if (token.IsKind(SyntaxKind.VirtualKeyword))
                {
                    return Token(SyntaxKind.OverrideKeyword);
                }
                return base.VisitToken(token);
            }
        }
    }
}
