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
    internal class SpannerStringIndexOfTranslator : IMethodCallTranslator
    {
        private static readonly MethodInfo s_indexOfString
            = typeof(string).GetRuntimeMethod(nameof(string.IndexOf), new[] {typeof(string)});

        private static readonly MethodInfo s_indexOfChar
            = typeof(string).GetRuntimeMethod(nameof(string.IndexOf), new[] {typeof(char)});

        public virtual Expression Translate(MethodCallExpression methodCallExpression)
        {
            if (!s_indexOfString.Equals(methodCallExpression.Method) &&
                !s_indexOfChar.Equals(methodCallExpression.Method))
            {
                return null;
            }

            return Expression.Subtract(
                new SqlFunctionExpression(
                    "STRPOS",
                    methodCallExpression.Type,
                    new[] {methodCallExpression.Object}.Concat(methodCallExpression.Arguments)),
                Expression.Constant(1)
            );
        }
    }
}