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
    internal class SpannerStringTrimTranslator : IMethodCallTranslator
    {
        private static readonly MethodInfo s_trim
            = typeof(string).GetRuntimeMethod(nameof(string.Trim), new Type[0]);

        private static readonly MethodInfo s_trimWithChars
            = typeof(string).GetRuntimeMethod(nameof(string.Trim), new[] {typeof(char[])});

        // The following exists as an optimization in netcoreapp20
        private static readonly MethodInfo s_trimWithSingleChar
            = typeof(string).GetRuntimeMethod(nameof(string.Trim), new[] {typeof(char)});

        public virtual Expression Translate(MethodCallExpression methodCallExpression)
        {
            if (methodCallExpression.Method.Equals(s_trim))
            {
                // Note that PostgreSQL TRIM() does spaces only, not all whitespace, so we use a regex
                return new SqlFunctionExpression(
                    "TRIM",
                    typeof(string),
                    new[]
                    {
                        methodCallExpression.Object
                    });
            }

            if (methodCallExpression.Method.Equals(s_trimWithChars))
            {
                var constantTrimChars = methodCallExpression.Arguments[0] as ConstantExpression;
                if (constantTrimChars == null)
                {
                    return null;
                }

                return new SqlFunctionExpression(
                    "TRIM",
                    typeof(string),
                    new[]
                    {
                        methodCallExpression.Object,
                        Expression.Constant(new string((char[]) constantTrimChars.Value))
                    });
            }

            if (methodCallExpression.Method.Equals(s_trimWithSingleChar))
            {
                var constantTrimChar = methodCallExpression.Arguments[0] as ConstantExpression;
                if (constantTrimChar == null)
                {
                    return null;
                }

                return new SqlFunctionExpression(
                    "TRIM",
                    typeof(string),
                    new[]
                    {
                        methodCallExpression.Object,
                        Expression.Constant(new string((char) constantTrimChar.Value, 1))
                    });
            }

            return null;
        }
    }
}