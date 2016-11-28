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

using Moq;
using System.Collections.Specialized;
using System.Web;
using Xunit;

namespace Google.Devtools.AspNet.Tests
{
    public class TraceHeaderContextTest
    {
        private static readonly HttpRequest Request = new HttpRequest("file_name", "https://www.google.com", "");
        private static readonly string TraceId = "105445aa7843bc8bf206b12000100f00";
        private static readonly ulong SpanId = 81237123;

        /// <summary>
        /// Create the string trace header value with an optional mask.
        /// </summary>
        private string CreateTraceHeaderValue(int? mask = null)
        {
            string headerValue = $"{TraceId}/{SpanId};";
            if (mask != null)
            {
                headerValue += "o=" + mask;
            }
            return headerValue;
        }

        /// <summary>
        /// Create a <see cref="NameValueCollection"/> with the trace header set.
        /// </summary>
        private HttpRequestWrapper CreateWrapperWithTraceHeader(string header)
        {
            NameValueCollection headers = new NameValueCollection();
            headers.Add(TraceHeaderContext.TraceHeader, header);
            Mock<HttpRequestWrapper> mockWrapper = new Mock<HttpRequestWrapper>(Request);
            mockWrapper.Setup(w => w.Headers).Returns(headers);
            return mockWrapper.Object;
        }

        /// <summary>
        /// Checks that a <see cref="TraceHeaderContext"/> has no span or trace id and
        /// should not trace.
        /// </summary>
        private void CheckInvalid(TraceHeaderContext context)
        {
            Assert.Null(context.SpanId);
            Assert.Null(context.TraceId);
            Assert.False(context.ShouldTrace);
        }

        [Fact]
        public void FromRequest_NoHeader()
        {
            CheckInvalid(TraceHeaderContext.FromRequest(Request));
        }

        [Fact]
        public void FromRequest_InvalidHeader()
        {
            HttpRequestWrapper wrapper = CreateWrapperWithTraceHeader("1234=0");
            CheckInvalid(TraceHeaderContext.FromWrapper(wrapper));
        }

        [Fact]
        public void FromRequest_Valid()
        {
            HttpRequestWrapper wrapper = CreateWrapperWithTraceHeader(CreateTraceHeaderValue());
            TraceHeaderContext context = TraceHeaderContext.FromWrapper(wrapper);

            Assert.True(SpanId == context.SpanId);
            Assert.Equal(TraceId, context.TraceId);
            Assert.False(context.ShouldTrace);

        }

        [Fact]
        public void FromRequest_ValidNoTrace()
        {
            HttpRequestWrapper wrapper = CreateWrapperWithTraceHeader(CreateTraceHeaderValue(0));
            TraceHeaderContext context = TraceHeaderContext.FromWrapper(wrapper);

            Assert.True(SpanId == context.SpanId);
            Assert.Equal(TraceId, context.TraceId);
            Assert.False(context.ShouldTrace);
        }

        [Fact]
        public void FromRequest_ValidTrace()
        {
            HttpRequestWrapper wrapper = CreateWrapperWithTraceHeader(CreateTraceHeaderValue(1));
            TraceHeaderContext context = TraceHeaderContext.FromWrapper(wrapper);

            Assert.True(SpanId == context.SpanId);
            Assert.Equal(TraceId, context.TraceId);
            Assert.True(context.ShouldTrace);
        }

    }
}