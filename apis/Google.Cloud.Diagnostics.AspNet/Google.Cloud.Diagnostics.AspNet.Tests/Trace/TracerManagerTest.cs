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

using System.IO;
using System.Web;
using Xunit;

namespace Google.Cloud.Diagnostics.AspNet.Tests
{
    public class TracerManagerTest
    {
        [Fact]
        public void CurrentTracer()
        {
            HttpRequest request = new HttpRequest("file_name", "https://www.google.com", "");
            HttpResponse response = new HttpResponse(new StringWriter());
            HttpContext.Current = new HttpContext(request, response);

            Assert.Null(TracerManager.GetCurrentTracer());
            TracerManager.SetCurrentTracer(DoNothingTracer.Instance);
            Assert.Equal(DoNothingTracer.Instance, TracerManager.GetCurrentTracer());
            TracerManager.SetCurrentTracer(null);
            Assert.Null(TracerManager.GetCurrentTracer());
        }
    }
}