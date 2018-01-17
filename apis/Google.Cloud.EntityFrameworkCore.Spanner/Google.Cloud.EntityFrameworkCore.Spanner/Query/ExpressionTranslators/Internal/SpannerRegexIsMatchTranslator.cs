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

using System.Linq.Expressions;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore.Query.Expressions;

namespace Microsoft.EntityFrameworkCore.Query.ExpressionTranslators.Internal
{
    internal class SpannerRegexIsMatchTranslator : IMethodCallTranslator
    {
        private static readonly MethodInfo s_isMatch =
            typeof(Regex).GetRuntimeMethod(nameof(Regex.IsMatch), new[] {typeof(string), typeof(string)});

        public Expression Translate(MethodCallExpression methodCallExpression)
        {
            // Regex.IsMatch(string, string)
            if (methodCallExpression.Method.Equals(s_isMatch))
            {
                return new SqlFunctionExpression(
                    "REGEXP_CONTAINS",
                    methodCallExpression.Type,
                    methodCallExpression.Arguments);
            }
            return null;
        }
    }
}