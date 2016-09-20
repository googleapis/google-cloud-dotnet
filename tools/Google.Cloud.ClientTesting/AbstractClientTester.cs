// Copyright 2016 Google Inc. All Rights Reserved.
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
using System.Reflection;
using Xunit;

namespace Google.Cloud.ClientTesting
{
    /// <summary>
    /// Helper code for our "abstract base class where all methods throw NotImplementedException".
    /// </summary>
    public abstract class AbstractClientTester<TAbstract, TConcrete> where TConcrete : TAbstract, new()
    {
        public static IEnumerable<object[]> AllInstanceMethods =>
            typeof(TAbstract).GetTypeInfo().DeclaredMethods
                .Where(m => m.IsPublic && !m.IsStatic && !m.IsSpecialName)
                .Select(m => new object[] { m });

        protected void AssertNotImplemented(MethodInfo method)
        {
            var client = new TConcrete();
            var arguments = method.GetParameters()
                .Select(GetArgument)
                .ToArray();
            var exception = Assert.Throws<TargetInvocationException>(() => method.Invoke(client, arguments));
            Assert.IsType<NotImplementedException>(exception.InnerException);
        }

        protected virtual object GetArgument(ParameterInfo parameter)
        {
            var type = parameter.ParameterType;
            if (type.GetTypeInfo().IsValueType)
            {
                return Activator.CreateInstance(type);
            }
            if (type == typeof(string))
            {
                return "x";
            }
            return null;
        }
    }
}
