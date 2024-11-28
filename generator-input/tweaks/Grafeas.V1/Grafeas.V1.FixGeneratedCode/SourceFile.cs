// Copyright 2019 Google LLC
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
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

// Note: this used to be in its own project, when it was used by multiple APIs.
// It may still contain more code than is needed by Grafeas, but that doesn't add
// a maintenance burden, and it allows the code to be moved back to a common project
// later if we ever want to.
namespace Grafeas.V1.FixGeneratedCode
{
    /// <summary>
    /// A text file, parsed as C# source code, with methods to simplify manipulation.
    /// </summary>
    public class SourceFile
    {
        private readonly string _path;
        private readonly SyntaxNode _root;

        private SourceFile(string path, SyntaxNode root)
        {
            _path = path;
            _root = root;
        }

        /// <summary>
        /// Loads a source file from the given path.
        /// </summary>
        public static SourceFile Load(string path)
        {
            var text = File.ReadAllText(path);
            var syntax = CSharpSyntaxTree.ParseText(text);
            return new SourceFile(path, syntax.GetRoot());
        }

        /// <summary>
        /// Saves the source file back to the original path.
        /// </summary>
        public void Save()
        {
            using (var writer = File.CreateText(_path))
            {
                _root.WriteTo(writer);
            }
        }

        /// <summary>
        /// Removes all using directives for the given namespace.
        /// </summary>
        /// <returns>The modified source file.</returns>
        public SourceFile RemoveImport(string ns)
        {
            return Rewrite(new UsingDirectiveRewriter(LocalRemoveImport));

            SyntaxNode LocalRemoveImport(UsingDirectiveSyntax node) =>
                node.Name?.GetText().ToString() == ns ? null : node;
        }

        /// <summary>
        /// Removes all using alias directives for the given alias.
        /// </summary>
        /// <returns>The modified source file.</returns>
        public SourceFile RemoveAlias(string alias)
        {
            return Rewrite(new UsingDirectiveRewriter(LocalRemoveAlias));

            SyntaxNode LocalRemoveAlias(UsingDirectiveSyntax node) =>
                node.Alias?.Name?.Identifier.Text == alias ? null : node;
        }

        /// <summary>
        /// Replaces all using alias directives with a new one for the given namespace.
        /// </summary>
        /// <returns>The modified source file.</returns>
        public SourceFile RewriteAlias(string alias, string ns)
        {
            return Rewrite(new UsingDirectiveRewriter(LocalRewriteAlias));

            SyntaxNode LocalRewriteAlias(UsingDirectiveSyntax node) =>
                node.Alias?.Name?.Identifier.Text == alias ? node.WithName(SyntaxFactory.ParseName(ns)) : node;
        }

        /// <summary>
        /// Removes the specified method, with the given parameter types.
        /// </summary>
        /// <returns>The new object, for chaining.</returns>
        public SourceFile RemoveMethod(string typeName, string methodName, params string[] parameterTypes)
        {
            var methods = _root.DescendantNodes().OfType<TypeDeclarationSyntax>()
                .Where(typeDeclaration => typeDeclaration.Identifier.Text == typeName)
                .SelectMany(typeDeclaration => typeDeclaration.ChildNodes().OfType<MethodDeclarationSyntax>())
                .ToList();
            var matchingMethods = methods
                .Where(method => method.Identifier.Text == methodName)
                .Where(method => method.ParameterList.Parameters.Count == parameterTypes.Length &&
                    method.ParameterList.Parameters.Zip(parameterTypes, (actual, expected) => (actual, expected))
                        .All(pair => ParameterMatches(pair.actual, pair.expected)))
                .ToList();
            if (matchingMethods.Count != 1)
            {
                string friendlyName = $"{typeName}.{methodName}({string.Join(", ", parameterTypes)})";
                throw new Exception($"Expected to find one method matching {friendlyName}; found {matchingMethods.Count}");
            }
            return WithNodesRemoved(matchingMethods[0]);

            bool ParameterMatches(ParameterSyntax syntax, string expectedType)
            {
                switch (syntax.Type)
                {
                    case AliasQualifiedNameSyntax alias:
                        return alias.Name.Identifier.Text == expectedType;
                    case IdentifierNameSyntax identifier:
                        return identifier.Identifier.Text == expectedType;
                    case PredefinedTypeSyntax predefined:
                        return predefined.Keyword.Text == expectedType;
                    case QualifiedNameSyntax qualified:
                        // This is pretty permissive, but unlikely to cause problems
                        return qualified.Right.Identifier.Text == expectedType;
                    default:
                        throw new Exception($"Unexpected parameter type syntax: {syntax.Type.Kind()}");
                }
            }
        }

        /// <summary>
        /// Removes the specified property.
        /// </summary>
        /// <returns>The modified source file.</returns>
        public SourceFile RemoveProperty(string typeName, string propertyName)
        {
            var matchingProperties = _root.DescendantNodes().OfType<TypeDeclarationSyntax>()
                .Where(typeDeclaration => typeDeclaration.Identifier.Text == typeName)
                .SelectMany(typeDeclaration => typeDeclaration.ChildNodes().OfType<PropertyDeclarationSyntax>())
                .Where(property => property.Identifier.Text == propertyName)
                .ToList();
            if (matchingProperties.Count != 1)
            {
                throw new Exception($"Expected to find one property matching {typeName}.{propertyName}; found {matchingProperties.Count}");
            }
            return WithNodesRemoved(matchingProperties[0]);
        }

        /// <summary>
        /// Removes the specified field.
        /// </summary>
        /// <returns>The modified source file.</returns>
        public SourceFile RemoveField(string typeName, string fieldName)
        {
            var matchingFields = _root.DescendantNodes().OfType<TypeDeclarationSyntax>()
                .Where(typeDeclaration => typeDeclaration.Identifier.Text == typeName)
                .SelectMany(typeDeclaration => typeDeclaration.ChildNodes().OfType<FieldDeclarationSyntax>())
                .Where(field => field.Declaration.Variables.Any(v => v.Identifier.Text == fieldName))
                .ToList();
            if (matchingFields.Count != 1)
            {
                throw new Exception($"Expected to find one field matching {typeName}.{fieldName}; found {matchingFields.Count}");
            }
            if (matchingFields[0].Declaration.Variables.Count != 1)
            {
                throw new Exception("Cannot remove a field from a declaration with multiple declarators.");
            }
            return WithNodesRemoved(matchingFields[0]);
        }

        /// <summary>
        /// Removes all declarations for the specified type name within the source file.
        /// </summary>
        /// <returns>The modified source file.</returns>
        public SourceFile RemoveType(string typeName)
        {
            var typeDeclarations = _root.DescendantNodes().OfType<TypeDeclarationSyntax>()
                .Where(typeDeclaration => typeDeclaration.Identifier.Text == typeName)
                .ToList();
            if (typeDeclarations.Count == 0)
            {
                throw new Exception($"Expected to find at least one type declaration of {typeName}");
            }
            return WithNodesRemoved(typeDeclarations);
        }

        /// <summary>
        /// Rewrites the specified type (or namespace) name in a new form.
        /// </summary>
        /// <param name="oldTypeName">The old type name; may include an alias (e.g. foo::TypeName)</param>
        /// <param name="newTypeName">The new type name; may include an alias (e.g. foo::TypeName)</param>
        /// <returns>The modified source file.</returns>
        public SourceFile RewriteTypeName(string oldTypeName, string newTypeName) =>
            Rewrite(new TypeNameRewriter(oldTypeName, newTypeName));

        /// <summary>
        /// Replaces one member access expression with another.
        /// </summary>
        /// <param name="oldAccessExpression">The expression to replace</param>
        /// <param name="newAccessExpression">The new expression</param>
        /// <returns>The modified source file.</returns>
        public SourceFile RewriteMemberAccess(string oldAccessExpression, string newAccessExpression) =>
            Rewrite(new MemberAccessRewriter(oldAccessExpression, newAccessExpression));

        /// <summary>
        /// Replaces one member access expression with another expression.
        /// </summary>
        /// <param name="oldAccessExpression">The expression to replace</param>
        /// <param name="newAccessExpression">The new expression</param>
        /// <returns>The modified source file.</returns>
        public SourceFile RewriteIdentifierName(string oldIdentifierName, string newExpression) =>
            Rewrite(new IdentifierNameRewriter(oldIdentifierName, newExpression));

        /// <summary>
        /// Rewrites the source code using the given rewriter.
        /// </summary>
        /// <returns>The modified source file.</returns>
        public SourceFile Rewrite(CSharpSyntaxRewriter rewriter)
        {
            var newRoot = rewriter.Visit(_root);
            // If we didn't find anything to change, that's almost always due to a bug, so fail quickly.
            if (newRoot == _root)
            {
                throw new Exception("Rewriter made no changes");
            }
            return WithRootNode(newRoot);
        }

        /// <summary>
        /// Returns the source file with a new root syntax node
        /// </summary>
        /// <returns>The modified source file.</returns>
        public SourceFile WithRootNode(SyntaxNode newRoot) =>
            new SourceFile(_path, newRoot);

        /// <summary>
        /// Returns the source file with the given syntax nodes removed.
        /// </summary>
        /// <returns>The modified source file.</returns>
        public SourceFile WithNodesRemoved<T>(params T[] nodesToRemove) where T : SyntaxNode =>
            WithNodesRemoved((IEnumerable<T>) nodesToRemove);

        /// <summary>
        /// Returns the source file with the given syntax nodes removed.
        /// </summary>
        /// <returns>The modified source file.</returns>
        public SourceFile WithNodesRemoved<T>(IEnumerable<T> nodesToRemove) where T : SyntaxNode =>
            WithRootNode(_root.RemoveNodes(nodesToRemove, SyntaxRemoveOptions.KeepDirectives));

        private class TypeNameRewriter : CSharpSyntaxRewriter
        {
            private readonly string _oldTypeName;
            private readonly string _newTypeName;

            public TypeNameRewriter(string oldTypeName, string newTypeName)
                : base(visitIntoStructuredTrivia: true)
            {
                _oldTypeName = oldTypeName;
                _newTypeName = newTypeName;
            }

            public override SyntaxNode VisitXmlCrefAttribute(XmlCrefAttributeSyntax node)
            {
                string existingName = node.Cref.ToString();
                return existingName == _oldTypeName
                    ? node.WithCref(SyntaxFactory.NameMemberCref(SyntaxFactory.ParseName(_newTypeName)))
                    : node;
            }

            public override SyntaxNode VisitAliasQualifiedName(AliasQualifiedNameSyntax node) =>
                MaybeReplaceName(node);

            public override SyntaxNode VisitQualifiedName(QualifiedNameSyntax node) =>
                MaybeReplaceName(node);

            private SyntaxNode MaybeReplaceName(NameSyntax node)
            {
                var existingName = node.ToString();
                return existingName == _oldTypeName
                    ? SyntaxFactory.ParseName(_newTypeName).WithTriviaFrom(node)
                    : node;
            }
        }

        private class MemberAccessRewriter : CSharpSyntaxRewriter
        {
            private readonly string _oldAccessExpression;
            private readonly string _newAccessExpression;

            public MemberAccessRewriter(string oldAccessExpression, string newAccessExpression)
                : base(visitIntoStructuredTrivia: false)
            {
                _oldAccessExpression = oldAccessExpression;
                _newAccessExpression = newAccessExpression;
            }

            public override SyntaxNode VisitMemberAccessExpression(MemberAccessExpressionSyntax node)
            {
                var existingAccessExpression = node.GetText().ToString();
                return existingAccessExpression == _oldAccessExpression
                    ? SyntaxFactory.ParseExpression(_newAccessExpression).WithTriviaFrom(node)
                    : node;
            }
        }

        private class IdentifierNameRewriter : CSharpSyntaxRewriter
        {
            private readonly string _oldIdentifierName;
            private readonly string _newExpression;

            public IdentifierNameRewriter(string oldIdentifierName, string newExpression)
                : base(visitIntoStructuredTrivia: false)
            {
                _oldIdentifierName = oldIdentifierName;
                _newExpression = newExpression;
            }

            public override SyntaxNode VisitIdentifierName(IdentifierNameSyntax node)
            {
                var existingExpression = node.GetText().ToString();
                return existingExpression == _oldIdentifierName
                    ? SyntaxFactory.ParseExpression(_newExpression).WithTriviaFrom(node)
                    : node;
            }
        }

        private class UsingDirectiveRewriter : CSharpSyntaxRewriter
        {
            private readonly Func<UsingDirectiveSyntax, SyntaxNode> _rewriter;

            public UsingDirectiveRewriter(Func<UsingDirectiveSyntax, SyntaxNode> rewriter) : base(false)
            {
                _rewriter = rewriter;
            }

            public override SyntaxNode VisitUsingDirective(UsingDirectiveSyntax node) =>
                _rewriter(node);
        }
    }
}
