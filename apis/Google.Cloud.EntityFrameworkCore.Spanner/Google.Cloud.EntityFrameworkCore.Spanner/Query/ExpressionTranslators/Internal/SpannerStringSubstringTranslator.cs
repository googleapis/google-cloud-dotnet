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

using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Microsoft.EntityFrameworkCore.Query.Expressions;

namespace Microsoft.EntityFrameworkCore.Query.ExpressionTranslators.Internal
{
    internal class SpannerStringSubstringTranslator : IMethodCallTranslator
    {
        private static readonly MethodInfo s_methodInfo = typeof(string).GetTypeInfo()
            .GetDeclaredMethods(nameof(string.Substring))
            .Single(m => m.GetParameters().Length == 2);

        /// <summary>
        /// This API supports the Entity Framework Core infrastructure and is not intended to be used
        /// directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public virtual Expression Translate(MethodCallExpression methodCallExpression)
            => methodCallExpression.Method.Equals(s_methodInfo)
                ? new SqlFunctionExpression(
                    "SUBSTR",
                    methodCallExpression.Type,
                    new[]
                    {
                        methodCallExpression.Object,
                        // Accommodate for SQL Server assumption of 1-based string indexes
                        methodCallExpression.Arguments[0].NodeType == ExpressionType.Constant
                            ? (Expression) Expression.Constant(
                                (int) ((ConstantExpression) methodCallExpression.Arguments[0]).Value + 1)
                            : Expression.Add(
                                methodCallExpression.Arguments[0],
                                Expression.Constant(1)),
                        methodCallExpression.Arguments[1]
                    })
                : null;
    }
}