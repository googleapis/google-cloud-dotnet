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
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;

using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Google.Cloud.Bigtable.V2.GenerateClient
{
    /// <summary>
    /// Internal helpers and extension methods which allow for a fluent style of code generation.
    /// </summary>
    internal static class RoslynHelpers
    {
        internal static ArgumentSyntax Argument(SyntaxToken identifier) =>
            SyntaxFactory.Argument(IdentifierName(identifier));

        internal static AssignmentExpressionSyntax AssignFrom(this ExpressionSyntax left, string right) =>
            left.AssignFrom(IdentifierName(right));

        internal static AssignmentExpressionSyntax AssignFrom(this ExpressionSyntax left, ExpressionSyntax right) =>
            AssignmentExpression(SyntaxKind.SimpleAssignmentExpression, left, right);

        internal static QualifiedCrefSyntax CrefMember(this TypeSyntax type, string name) =>
            QualifiedCref(type.WithoutTrivia(), NameMemberCref(ParseTypeName(name)));

        internal static BinaryExpressionSyntax EqualTo(this ExpressionSyntax left, ExpressionSyntax right) =>
            BinaryExpression(SyntaxKind.EqualsExpression, left, right);

        internal static IfStatementSyntax If(ExpressionSyntax condition, params StatementSyntax[] statements) =>
            IfStatement(condition, Block(statements));

        internal static InvocationExpressionSyntax Invoke(this ExpressionSyntax expression, params ArgumentSyntax[] arguments) =>
            expression.Invoke((IEnumerable<ArgumentSyntax>)arguments);

        internal static InvocationExpressionSyntax Invoke(this ExpressionSyntax expression, IEnumerable<ArgumentSyntax> arguments) =>
            InvocationExpression(expression, ArgumentList(SeparatedList(arguments)));

        internal static MemberAccessExpressionSyntax Member(this SyntaxToken identifier, string name) =>
            IdentifierName(identifier).Member(name);

        internal static MemberAccessExpressionSyntax Member(this ExpressionSyntax expression, string name) =>
            MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression, expression, IdentifierName(name));

        internal static MemberAccessExpressionSyntax Member(this ExpressionSyntax expression, SyntaxToken name) =>
            MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression, expression, IdentifierName(name));

        internal static LiteralExpressionSyntax Null() =>
            LiteralExpression(SyntaxKind.NullLiteralExpression);

        internal static XmlEmptyElementSyntax SeeTag(CrefSyntax cref) =>
            XmlEmptyElement("see").AddAttributes(XmlCrefAttribute(cref));

        internal static ExpressionStatementSyntax ToStatement(this ExpressionSyntax expression) =>
            ExpressionStatement(expression);
    }
}
