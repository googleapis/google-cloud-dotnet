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
using Xunit;

#if NET451
using System.Web;
#else
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
#endif

namespace Google.Cloud.Diagnostics.Common.Tests
{
    public class TraceDecisionPredicateTest
    {
        private HttpRequest CreateRequest(string path)
        {
#if NET451
            return new HttpRequest("somefile", $"https://www.google.com{path}", "");
#else
            return new DefaultHttpRequest(new DefaultHttpContext())
            {
                Path = path
            };
#endif
        }

        [Fact]
        public void ShouldTrace_HealthCheck_NoFallback_Null()
        {
            var request = CreateRequest("/this/path");
            Assert.Null(TraceDecisionPredicate.Default.ShouldTrace(request));
        }

        [Fact]
        public void ShouldTrace_HealthCheck_NoFallback_False()
        {
            var request = CreateRequest("/_ah/health");
            Assert.False(TraceDecisionPredicate.Default.ShouldTrace(request));
        }

        [Fact]
        public void ShouldTrace_NoHealthCheck_NoFallback_Null()
        {
            var request = CreateRequest("/_ah/health");
            Assert.Null(TraceDecisionPredicate.DoNothing.ShouldTrace(request));
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        [InlineData(null)]
        public void ShouldTrace_NoHealthCheck_Fallback(bool? returnValue)
        {
            var request = CreateRequest("/_ah/health");
            Func<HttpRequest, bool?> fallback = (HttpRequest r) => returnValue;
            var predicate = TraceDecisionPredicate.Create(fallback, ignoreHealthChecks: false);
            Assert.Equal(returnValue, predicate.ShouldTrace(request));
        }

        [Fact]
        public void ShouldTrace_HealthCheck_Fallback()
        {
            var request = CreateRequest("/_ah/health");
            Func<HttpRequest, bool?> fallback = (HttpRequest r) => true;
            var predicate = TraceDecisionPredicate.Create(fallback);
            Assert.False(predicate.ShouldTrace(request));
        }

        [Fact]
        public void ShouldTrace_HealthCheck_Fallback_UseFunc()
        {
            var request = CreateRequest("/this/path");
            Func<HttpRequest, bool?> fallback = (HttpRequest r) => true;
            var predicate = TraceDecisionPredicate.Create(fallback);
            Assert.True(predicate.ShouldTrace(request));
        }
    }
}
