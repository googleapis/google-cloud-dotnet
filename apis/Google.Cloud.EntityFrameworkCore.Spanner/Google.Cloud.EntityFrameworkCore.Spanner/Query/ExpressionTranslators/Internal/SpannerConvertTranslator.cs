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
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Microsoft.EntityFrameworkCore.Query.Expressions;

namespace Microsoft.EntityFrameworkCore.Query.ExpressionTranslators.Internal
{
    internal class SpannerConvertTranslator : IMethodCallTranslator
    {
        private static readonly Dictionary<string, string> s_typeMapping = new Dictionary<string, string>
        {
            [nameof(Convert.ToBoolean)] = "BOOL",
            [nameof(Convert.ToByte)] = "INT64",
            [nameof(Convert.ToDecimal)] = "FLOAT64",
            [nameof(Convert.ToDouble)] = "FLOAT64",
            [nameof(Convert.ToInt16)] = "INT64",
            [nameof(Convert.ToInt32)] = "INT64",
            [nameof(Convert.ToInt64)] = "INT64",
            [nameof(Convert.ToString)] = "STRING"
        };

        private static readonly List<Type> s_supportedTypes = new List<Type>
        {
            typeof(bool),
            typeof(byte),
            typeof(decimal),
            typeof(double),
            typeof(float),
            typeof(int),
            typeof(long),
            typeof(short),
            typeof(string)
        };

        private static readonly IEnumerable<MethodInfo> s_supportedMethods
            = s_typeMapping.Keys
                .SelectMany(
                    t => typeof(Convert).GetTypeInfo().GetDeclaredMethods(t)
                        .Where(
                            m => m.GetParameters().Length == 1
                                 && s_supportedTypes.Contains(m.GetParameters().First().ParameterType)));

        public virtual Expression Translate(MethodCallExpression methodCallExpression)
            => s_supportedMethods.Contains(methodCallExpression.Method)
                ? new SqlFunctionExpression(
                    "CAST",
                    methodCallExpression.Type,
                    new[]
                    {
                        methodCallExpression.Arguments[0],
                        new SqlFragmentExpression(s_typeMapping[methodCallExpression.Method.Name])
                    })
                : null;
    }
}