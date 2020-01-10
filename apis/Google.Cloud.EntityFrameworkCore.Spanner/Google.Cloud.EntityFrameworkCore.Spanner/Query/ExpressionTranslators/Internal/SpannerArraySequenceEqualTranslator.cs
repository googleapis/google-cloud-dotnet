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

namespace Microsoft.EntityFrameworkCore.Query.ExpressionTranslators.Internal
{
    /// <summary>
    /// Translate Enumerable.SequenceEqual on arrays into equality.
    /// </summary>
    internal class SpannerArraySequenceEqualTranslator : IMethodCallTranslator
    {
        private static readonly MethodInfo s_sequenceEqualMethodInfo = typeof(Enumerable).GetTypeInfo()
            .GetDeclaredMethods(nameof(Enumerable.SequenceEqual)).Single(m =>
                m.IsGenericMethodDefinition &&
                m.GetParameters().Length == 2
            );

        public Expression Translate(MethodCallExpression methodCallExpression)
        {
            var method = methodCallExpression.Method;
            if (method.IsGenericMethod &&
                ReferenceEquals(method.GetGenericMethodDefinition(), s_sequenceEqualMethodInfo) &&
                methodCallExpression.Arguments.All(a => a.Type.IsArray))
            {
                return Expression.MakeBinary(ExpressionType.Equal,
                    methodCallExpression.Arguments[0],
                    methodCallExpression.Arguments[1]);
            }

            return null;
        }
    }
}