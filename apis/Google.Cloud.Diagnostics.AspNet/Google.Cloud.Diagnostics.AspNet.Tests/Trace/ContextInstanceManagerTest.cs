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
// limitations under the License.using Microsoft.VisualStudio.TestTools.UnitTesting;

using Google.Cloud.Diagnostics.Common;
using System.IO;
using System.Web;
using Xunit;

namespace Google.Cloud.Diagnostics.AspNet.Tests
{
    public class ContextInstanceManagerTest
    {
        [Fact]
        public void SingleType()
        {
            HttpContext.Current = CreateHttpContext();

            Assert.Null(ContextInstanceManager.Get<IManagedTracer>());
            ContextInstanceManager.Set<IManagedTracer>(NullManagedTracer.Instance);
            Assert.Equal(NullManagedTracer.Instance, ContextInstanceManager.Get<IManagedTracer>());
            ContextInstanceManager.Set<IManagedTracer>(null);
            Assert.Null(ContextInstanceManager.Get<IManagedTracer>());
        }

        [Fact]
        public void MultipleTypes()
        {
            HttpContext.Current = CreateHttpContext();

            ContextInstanceManager.Set("some string");
            ContextInstanceManager.Set(123);
            Assert.Equal("some string", ContextInstanceManager.Get<string>());
            Assert.Equal(123, ContextInstanceManager.Get<int>());
        }

        private HttpContext CreateHttpContext()
        {
            var request = new HttpRequest("file_name", "https://www.google.com", "");
            var response = new HttpResponse(new StringWriter());
            return new HttpContext(request, response);
        }
    }
}