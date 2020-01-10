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

using System;
using System.Linq.Expressions;
using System.Reflection;
using Microsoft.EntityFrameworkCore.Query.Expressions;

namespace Microsoft.EntityFrameworkCore.Query.ExpressionTranslators.Internal
{
    internal class SpannerStringTrimEndTranslator : IMethodCallTranslator
    {
        private static readonly MethodInfo s_trimEndWithChars
            = typeof(string).GetRuntimeMethod(nameof(string.TrimEnd), new[] {typeof(char[])});

        // The following exists as an optimization in netcoreapp20
        private static readonly MethodInfo s_trimEndNoParam
            = typeof(string).GetRuntimeMethod(nameof(string.TrimEnd), new Type[0]);

        // The following exists as an optimization in netcoreapp20
        private static readonly MethodInfo s_trimEndSingleChar
            = typeof(string).GetRuntimeMethod(nameof(string.TrimEnd), new[] {typeof(char)});

        public virtual Expression Translate(MethodCallExpression methodCallExpression)
        {
            if (!methodCallExpression.Method.Equals(s_trimEndWithChars) &&
                !methodCallExpression.Method.Equals(s_trimEndNoParam) &&
                !methodCallExpression.Method.Equals(s_trimEndSingleChar))
            {
                return null;
            }

            char[] trimChars;

            if (methodCallExpression.Method.Equals(s_trimEndSingleChar))
            {
                var constantTrimChars = methodCallExpression.Arguments[0] as ConstantExpression;
                if (constantTrimChars == null)
                {
                    return null; // Don't translate if trim chars isn't a constant
                }

                var trimChar = (char) constantTrimChars.Value;
                return new SqlFunctionExpression(
                    "RTRIM",
                    typeof(string),
                    new[]
                    {
                        methodCallExpression.Object,
                        Expression.Constant(new string(trimChar, 1))
                    });
            }

            if (methodCallExpression.Method.Equals(s_trimEndNoParam))
            {
                trimChars = null;
            }
            else if (methodCallExpression.Method.Equals(s_trimEndWithChars))
            {
                var constantTrimChars = methodCallExpression.Arguments[0] as ConstantExpression;
                if (constantTrimChars == null)
                {
                    return null; // Don't translate if trim chars isn't a constant
                }
                trimChars = (char[]) constantTrimChars.Value;
            }
            else
            {
                throw new Exception(
                    $"{nameof(SpannerStringTrimEndTranslator)} does not support {methodCallExpression}");
            }

            if (trimChars == null || trimChars.Length == 0)
            {
                return new SqlFunctionExpression(
                    "RTRIM",
                    typeof(string),
                    new[]
                    {
                        methodCallExpression.Object
                    });
            }

            return new SqlFunctionExpression(
                "RTRIM",
                typeof(string),
                new[]
                {
                    methodCallExpression.Object,
                    Expression.Constant(new string(trimChars))
                });
        }
    }
}