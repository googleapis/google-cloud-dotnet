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
using System.Linq;
using System.Reflection;
using Xunit;

namespace Google.Storage.V1.Tests
{
    public class StorageClientTest
    {
        [Fact]
        public void AllMethodsThrowNotImplementedException()
        {
            var client = new DerivedStorageClient();
            var methods = typeof(StorageClient).GetTypeInfo().DeclaredMethods
                .Where(m => m.IsPublic && !m.IsStatic);
            foreach (var method in methods)
            {
                var arguments = method.GetParameters()
                    .Select(p => p.ParameterType)
                    .Select(t => t.GetTypeInfo().IsValueType ? Activator.CreateInstance(t) : null)
                    .ToArray();
                var exception = Assert.Throws<TargetInvocationException>(() => method.Invoke(client, arguments));
                Assert.IsType<NotImplementedException>(exception.InnerException);
            }
        }

        private object[] GetArguments(MethodInfo method)
        {
            return method.GetParameters()
                .Select(p => p.ParameterType)
                .Select(t => t.GetTypeInfo().IsValueType ? Activator.CreateInstance(t) : null)
                .ToArray();
        }

        private class DerivedStorageClient : StorageClient
        {
        }
    }
}
